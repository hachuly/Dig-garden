using UnityEngine;
using System.Collections;

public class findJewely : MonoBehaviour {

    private Hitpoint isJewelry;

    private SEManager setAudio;
    private bool trigger;

	// Use this for initialization
	void Start () {
        isJewelry = gameObject.GetComponent<Hitpoint>();
        setAudio = GameObject.Find("isSE").GetComponent<SEManager>();
        trigger = true;
	}

	// Update is called once per frame
	void Update () {
        if(trigger){
            rayJewelry();
        }

	}

    public void rayJewelry(){
        int layer = 1 << 8;
        Ray ray = new Ray(transform.position, transform.forward);
        Vector2 ray_position = (Vector2)ray.origin;
        RaycastHit2D[] hit = new RaycastHit2D[4];

        hit[0] = Physics2D.Raycast(new Vector2(ray_position.x + 0.015f, ray_position.y + 0.015f), Vector2.zero, 1, layer);
        hit[1] = Physics2D.Raycast(new Vector2(ray_position.x + 0.015f - 0.03f, ray_position.y + 0.015f), Vector2.zero, 1, layer);
        hit[2] = Physics2D.Raycast(new Vector2(ray_position.x, ray_position.y + 0.015f - 0.03f), Vector2.zero, 1, layer);
        hit[3] = Physics2D.Raycast(new Vector2(ray_position.x + 0.015f - 0.03f, ray_position.y + 0.015f - 0.03f), Vector2.zero, 1, layer);

        if(hit[0].collider.gameObject.tag == "tagJewelry"
        && hit[1].collider.gameObject.tag == "tagJewelry"
        && hit[2].collider.gameObject.tag == "tagJewelry"
        && hit[3].collider.gameObject.tag == "tagJewelry"
        ){
            isJewelry.getJewelry();
            trigger = false;
            setAudio.setActive(gameObject.tag);
        }
    }
}
