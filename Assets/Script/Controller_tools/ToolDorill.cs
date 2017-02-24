using UnityEngine;
using System.Collections;
using System;

public class ToolDorill : MonoBehaviour {

    public GameObject objectGauge;

    private SEManager setAudio;
    private Hitpoint def;
    private Hitpoint penalty;
    private toolGauge stateGauge;

    private Vector2 ray_position;
    private Ray ray;
    private RaycastHit2D hit;

    private float[,] array_position;

    private bool triggerFrame;
    private bool stateMouse;
    private int frameRate;
    private int str1,str2,str3;
    private int layer;


    private SmokeAnimation effect;

	// Use this for initialization
	void Start () {

        setAudio = GameObject.Find("SE-Manager").GetComponent<SEManager>();
        effect = GameObject.Find("Generator_Smoke").GetComponent<SmokeAnimation>();
        stateGauge = objectGauge.GetComponent<toolGauge>();

        setupRayPosition();


        str1 = 10;
        str2 = 3;
        str3 = 1;

        triggerFrame = true;
        stateMouse = false;

	}

	// Update is called once per frame
	void Update () {
        if(stateMouse){
            isFrame(triggerFrame);

        }

	}

    public void loadDorill(){
        layer = 1 << 8;
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        ray_position = (Vector2)ray.origin;

        for(int i = 0; i < array_position.Length/2; i++){
            try{
                hit = Physics2D.Raycast(new Vector2(ray_position.x + array_position[i,0], ray_position.y + array_position[i,1]), Vector2.zero, 1, layer);
                    if(5 <= i){
                        playAction(hit, str3);
                    }else if(1 <= i){
                        playAction(hit, str2);
                    }else{
                        playAction(hit, str1);
                    }

                effect.playAnimation(hit.collider.gameObject.transform.position);

            }catch(NullReferenceException error){}

        }

    }

    private void playAction(RaycastHit2D ray, int str){
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
        array_position = new float[,]{
            {+0.00f,+0.00f},//center
            {+0.00f,+0.03f},//top
            {+0.00f,-0.03f},//done
            {+0.03f,+0.00f},//right
            {-0.03f,+0.00f},//left

            {+0.03f,+0.03f},
            {+0.03f,-0.03f},
            {-0.03f,+0.03f},
            {-0.03f,-0.03f},

        };

    }

    void OnMouseDown(){
        stateMouse = true;
    }

    void OnMouseUp(){
        stateMouse = false;

    }

    public void isFrame(bool trigger){
        if(trigger){
            if(frameRate + 10 < Time.frameCount){
                frameRate = Time.frameCount;
                if(stateGauge.canActive){
                    loadDorill();
                    stateGauge.decreaseMeter();
                }

            }

        }

    }

}
