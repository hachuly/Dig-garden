using UnityEngine;
using System;
using System.Collections;

public class ToolHammer : MonoBehaviour {

    public GameObject objectGauge;

    private SEManager setAudio;
    private Hitpoint def;
    private Hitpoint penalty;

    private float[,] array_position;

    private Vector2 ray_position;
    private int str;
    private int layer;
    private Ray ray;
    private RaycastHit2D hit;

    private SmokeAnimation effect;

    void Start(){

        effect = GameObject.Find("Generator_Smoke").GetComponent<SmokeAnimation>();
        setAudio = GameObject.Find("SE-Manager").GetComponent<SEManager>();

        str = 2;
        setupRayPosition();
    }

    public void OnMouseDown() {
        loadHammer();

    }

    public void loadHammer(){
        layer = 1 << 8;
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        ray_position = (Vector2)ray.origin;

        for(int i = 0; i < array_position.Length/2; i++){
            try{
                hit = Physics2D.Raycast(new Vector2(ray_position.x + array_position[i,0], ray_position.y + array_position[i,1]), Vector2.zero, 1, layer);
                playAction(hit);
                effect.playAnimation(hit.collider.gameObject.transform.position);

            }catch(NullReferenceException error){}

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
        objectGauge.GetComponent<toolGauge>().increaseMeter(0.005f);

    }

    private void setupRayPosition(){
        array_position = new float[,]{
            {+0.000f,+0.000f},//center
            {+0.000f,+0.03f},//top
            {+0.000f,-0.03f},//done
            {+0.03f,+0.000f},//right
            {-0.03f,+0.000f},//left


            // {+0.015f,+0.045f},
            // {-0.015f,+0.045f},

            // {+0.015f,-0.045f},
            // {-0.015f,-0.045f},

            // {+0.045f,+0.015f},
            // {+0.045f,-0.015f},

            // {-0.045f,+0.015f},
            // {-0.045f,-0.015f},
        };

    }

}
