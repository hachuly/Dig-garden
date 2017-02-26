using UnityEngine;
using System;
using System.Collections;

public class ToolHammer : Tool {

    [SerializeField]
    Vector2[] position;

    void OnMouseDown() {
        this.loadTool();

    }

    void loadTool(){
        int layer = 1 << 8;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector2 origin = (Vector2)ray.origin;

        this.tryRaycast(layer, origin);

    }

    void tryRaycast(int layer, Vector2 ray){
        RaycastHit2D hit;
        GameObject obj;

        for(int i = 0; i < this.position.Length; i++){
            try{

                hit = Physics2D.Raycast(new Vector2(ray.x + this.position[i].x, ray.y + this.position[i].y), new Vector2(0f,0f), 1, layer);
                obj = hit.collider.gameObject;

				damageDeclaration(obj, getDamagePoint());
				playEffect(obj);
                addEnergy();

            }catch(NullReferenceException error){
                Debug.Log("hummer : " + error);
            }

        }

    }

}
