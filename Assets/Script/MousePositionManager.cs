using UnityEngine;
using System;
using System.Collections;

public class MousePositionManager : MonoBehaviour {

    void Start(){

    }

    public void OnMouseUp() {
        // inPosition(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        RayTest();
    }

    public void RayManager(){
            int layer = 1 << 8;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector2 ray_position = (Vector2)ray.origin;
            RaycastHit2D hit = Physics2D.Raycast((Vector2)ray.origin, Vector2.zero, 1, layer);
    }

    public void RayTest(){
        try{
            int layer = 1 << 8;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector2 ray_position = (Vector2)ray.origin;
            RaycastHit2D hit = Physics2D.Raycast((Vector2)ray.origin, Vector2.zero, 1, layer);

            //hummer
            hit = Physics2D.Raycast(new Vector2(ray_position.x + 0.015f, ray_position.y + 0.015f), Vector2.zero, 1, layer);
            Debug.Log(hit.collider.gameObject.name);
            Destroy(hit.collider.gameObject);
            hit = Physics2D.Raycast(new Vector2(ray_position.x + -0.015f, ray_position.y + 0.015f), Vector2.zero, 1, layer);
            Debug.Log(hit.collider.gameObject.name);
            Destroy(hit.collider.gameObject);
            hit = Physics2D.Raycast(new Vector2(ray_position.x + 0.015f, ray_position.y + -0.015f), Vector2.zero, 1, layer);
            Debug.Log(hit.collider.gameObject.name);
            Destroy(hit.collider.gameObject);
            hit = Physics2D.Raycast(new Vector2(ray_position.x + -0.015f, ray_position.y + -0.015f), Vector2.zero, 1, layer);
            Debug.Log(hit.collider.gameObject.name);
            Destroy(hit.collider.gameObject);

        }catch(NullReferenceException ex){
            Debug.Log("error");
        }
    }
}
