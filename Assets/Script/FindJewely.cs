using UnityEngine;

public class FindJewely : MonoBehaviour {

    private Hitpoint jewelry;
    private SoundEffect sound;
    private bool trigger;

	// Use this for initialization
	void Start () {
        jewelry = gameObject.GetComponent<Hitpoint>();
        sound = gameObject.GetComponent<SoundEffect>();
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
        Vector2 origin = (Vector2)ray.origin;
        RaycastHit2D[] hit = new RaycastHit2D[4];

        hit[0] = Physics2D.Raycast(new Vector2(origin.x + 0.015f, origin.y + 0.015f), Vector2.zero, 1, layer);
        hit[1] = Physics2D.Raycast(new Vector2(origin.x + 0.015f - 0.03f, origin.y + 0.015f), Vector2.zero, 1, layer);
        hit[2] = Physics2D.Raycast(new Vector2(origin.x, origin.y + 0.015f - 0.03f), Vector2.zero, 1, layer);
        hit[3] = Physics2D.Raycast(new Vector2(origin.x + 0.015f - 0.03f, origin.y + 0.015f - 0.03f), Vector2.zero, 1, layer);

        if(hit[0].collider.gameObject.tag == "tagJewelry"
        && hit[1].collider.gameObject.tag == "tagJewelry"
        && hit[2].collider.gameObject.tag == "tagJewelry"
        && hit[3].collider.gameObject.tag == "tagJewelry"
        ){
            jewelry.getJewelry();
            trigger = false;
            sound.playSoundEffect();
        }
    }
}
