using UnityEngine;
using System.Collections;

public class DestroyStratum : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

    void OnCollisionStay2D(Collision2D other){
        if(other.gameObject.tag == "tagMud"
        || other.gameObject.tag == "tagJewelry"
        || other.gameObject.tag == "tagSand"
        || other.gameObject.tag == "tagStone_b"
        || other.gameObject.tag == "tagStone"
        ){
            Destroy(other.gameObject);
        }

    }

}
