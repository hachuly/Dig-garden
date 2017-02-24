using UnityEngine;
using System;


public class ToolPickaxe : Tool {

    private void OnMouseUp(){
        loodTool();
    }

    protected void loodTool(){
        int layer = 1 << 8;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        tryRaycast(layer, ray);

    }

    private void tryRaycast(int layer, Ray ray){
        RaycastHit2D hit;
        GameObject obj;

        try{
            hit = Physics2D.Raycast((Vector2)ray.origin, Vector2.zero, 1, layer);
            obj = hit.collider.gameObject;
            damageDeclaration(obj);
        }catch(NullReferenceException error){
            Debug.Log(error);
        }

    }

}