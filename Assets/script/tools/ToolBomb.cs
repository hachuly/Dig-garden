using UnityEngine;
using System;
using System.Collections;

public class ToolBomb : MonoBehaviour {

    public GameObject objectItemManager;

    SEManager setAudio;
    Hitpoint def;
    Hitpoint penalty;
    ItemManager stateItems;

    float[] array_y_position;
    float[] array_x_position;

    int str;
    int layer;
    RaycastHit2D hit;

	// Use this for initialization
	void Start () {
        setAudio = GameObject.Find("SE-Manager").GetComponent<SEManager>();
        setupRayPosition();
        stateItems = objectItemManager.GetComponent<ItemManager>();
        str = 10;
	}

	// Update is called once per frame
	void Update () {

	}

    void OnMouseDown(){
        if(0 < stateItems.showItems()){
            loadBomb();

        }

    }



    public void loadBomb(){
        layer = 1 << 8;

        for(int y = 0; y < array_y_position.Length; y++){
            for(int x = 0; x <= array_y_position.Length; x++){
                try{
                    hit = Physics2D.Raycast(new Vector2(array_x_position[x],array_y_position[y]), Vector2.zero, 1, layer);
                    playAction(hit);
                    // effect.playAnimation(hit.collider.gameObject.transform.position);
                }catch(NullReferenceException error){}
            }
        }
    }

    private void playAction(RaycastHit2D ray){
        if(ray.collider.gameObject.tag == "tagSand"
            || ray.collider.gameObject.tag == "tagStone"){
            setAudio.setActive(ray.collider.gameObject.tag);
            def = ray.collider.gameObject.GetComponent<Hitpoint>();
            def.attackTratum(str);
        }else{
            if(ray.collider.gameObject.tag == "tagJewelry"){
                setAudio.setActive(ray.collider.gameObject.tag);
                penalty = ray.collider.gameObject.GetComponent<Hitpoint>();
                penalty.isPenaltyTrigger();
            }

        }

    }

    private void setupRayPosition(){
        array_y_position = new float[]{
            +0.065f,
            +0.035f,
            +0.005f,
            -0.025f,
            -0.055f,
            -0.085f,
        };

        array_x_position = new float[]{
            -0.135f,
            -0.105f,
            -0.075f,
            -0.045f,
            -0.015f,
            +0.015f,
            +0.045f,
        };

    }

}
