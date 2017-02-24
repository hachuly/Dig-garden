using UnityEngine;
using System.Collections;

public class ItemGenerator : Blueprint {

    private GameObject obj;

	// Use this for initialization
	void Start () {
        startGenerater(hasJewelry());
	}

	// Update is called once per frame
	void Update () {

	}

    private void startGenerater(bool trigger){
        if(trigger){
            this.obj = Instantiate(getResources()) as GameObject;

        }else{
            this.obj = Instantiate(getResource()) as GameObject;

        }
        this.obj.transform.position = findPosition(getBasicPosition());
        this.obj.transform.parent = gameObject.transform;

    }

    private Vector3 findPosition(Vector3 position){
        return new Vector3(
            position.x + Random.Range(1, 6)*0.03f,
            position.y + Random.Range(1, 5)*0.03f,
            position.z

        );

    }

}
