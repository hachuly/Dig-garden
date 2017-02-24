using UnityEngine;
using System.Collections;
using System;


public class ToolPickaxe : MonoBehaviour {

    public GameObject objectGauge;
    public GameObject objectSEManager;
    public GameObject objectSmokeAnimation;

    private SEManager sound;
    private Hitpoint def;
    private Hitpoint penalty;

    private SmokeAnimation effect;

    private int str;

	// Use this for initialization
	void Start () {
        sound = GameObject.Find("SE-Manager").GetComponent<SEManager>();
        effect = GameObject.Find("Generator-smoke").GetComponent<SmokeAnimation>();
        str = 5;
	}

    public void OnMouseUp() {
        loadPickaxe();


    }

    public void loadPickaxe(){
        int layer = 1 << 8;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector2 ray_position = (Vector2)ray.origin;
        RaycastHit2D hit;

        try{
            hit = Physics2D.Raycast((Vector2)ray.origin, Vector2.zero, 1, layer);
            playAction(hit);
            effect.playAnimation(hit.collider.gameObject.transform.position);
        }catch(NullReferenceException e){}



    }

    private void playAction(RaycastHit2D ray){
        if(ray.collider.gameObject.tag == "tagSand"
            || ray.collider.gameObject.tag == "tagStone"){
            sound.setActive(ray.collider.gameObject.tag);
            def = ray.collider.gameObject.GetComponent<Hitpoint>();
            def.attackTratum(str);
        }else{
            if(ray.collider.gameObject.tag == "tagJewelry"){
                sound.setActive(ray.collider.gameObject.tag);
                penalty = ray.collider.gameObject.GetComponent<Hitpoint>();
                penalty.isPenaltyTrigger();
            }

        }objectGauge.GetComponent<toolGauge>().increaseMeter(0.03f);

    }

}