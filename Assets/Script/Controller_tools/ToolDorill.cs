using UnityEngine;
using System.Collections;
using System;

public class ToolDorill : Tool {
    [SerializeField]
    float recastcount;
    [SerializeField]
    private int damage_center, damage_plus, damage_cross;
    [SerializeField]
    Vector2[] position;

    bool state, click;
    float framerate;

    void Start(){
        state = true;
    }

	// Update is called once per frame
	void Update () {
        if(click){
            canDiging(this.state);

        }

	}

    void OnMouseUp(){
        click = false;

    }

    void OnMouseDown(){
        click = true;

    }

    void loadTool(){
        int layer = 1 << 8;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector2 origin = (Vector2)ray.origin;

        tryRayCast(layer, origin);

    }

    void tryRayCast(int layer, Vector2 ray){
        RaycastHit2D hit;
        GameObject obj;

        for(int i = 0; i < this.position.Length; i++){
            try{
                hit = Physics2D.Raycast(new Vector2(ray.x + this.position[i].x, ray.y + this.position[i].y), new Vector2(0f,0f), 1, layer);
                obj = hit.collider.gameObject;

                damageDeclaration(obj, selectDamagePoint(i));
                playEffect(obj);

            }catch(NullReferenceException error){
                Debug.Log(error);
            }

        }

    }

    int selectDamagePoint(int num){
        if(5 <= num){
            return damage_cross;
        }else if(1 <= num){
            return damage_plus;
        }else{
            return damage_center;
        }return 0;

    }

    void canDiging(bool state){
        if(state){
            if(framerate + 10 < Time.frameCount){
                framerate = Time.frameCount;
                if(checkGaugeState()){
                    loadTool();
                    sumEnergy();
                }

            }

        }

    }

}
