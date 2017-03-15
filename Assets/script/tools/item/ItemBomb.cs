using UnityEngine;
using System;
using System.Collections;

public class ItemBomb : MonoBehaviour {

    public GameObject objectItemSender;

    private ItemStock sendItems;
    private bool trigger;

    void Start(){
        sendItems = objectItemSender.GetComponent<ItemStock>();
        trigger = true;
    }

    // Update is called once per frame
    void Update () {
        if(trigger){
            useRay();

        }

    }

    public void useRay(){
        int layer = 1 << 8;
        Ray ray = new Ray(transform.position, transform.forward);

        tryFindItem(ray, layer);
    }

    private void tryFindItem(Ray ray, int layer){
        try{
            RaycastHit2D hit = Physics2D.Raycast((Vector2)ray.origin, Vector2.zero, 1, layer);
            if(hit.collider.gameObject.tag == "itemBomb"){
                // sendItems.getItem();
                trigger = false;
                Debug.Log(trigger);


            }

        }catch(NullReferenceException error){}

    }

}
