using UnityEngine;
using System.Collections;

public class Blueprint : MonoBehaviour {

    public GameObject[] resources;
    public GameObject resource;
    public Vector3 basicPosition;
    public bool isRondom;
    public bool isJewelry;

    protected GameObject getResources(){
        if(isJewelry){
            return resources[Random.Range(0, resources.Length)];
        }else{
            Debug.Log("not item");
            return null;
        }

    }

    protected GameObject getResource(){
        return resource;
    }

    protected Vector3 getBasicPosition(){
        return basicPosition;
    }

    protected bool hasRandom(){
        return isRondom;
    }

    protected bool hasJewelry(){
        return isJewelry;
    }

}
