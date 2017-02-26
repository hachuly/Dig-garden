using UnityEngine;
using System.Collections;

public class GenerateManager : MonoBehaviour {

    public GameObject[] resourcesStatum;
    public GameObject[] resourcesItems;

    private GameObject obj;
    private int lengthResources;
    private Blueprint paper;

	// Use this for initialization
	void Start () {
        startGenerate();

	}

	// Update is called once per frame
	void Update () {

	}

    private void startGenerate(){
        foreach(GameObject obj in resourcesStatum){
            this.obj = Instantiate(obj) as GameObject;
            this.obj.transform.parent = gameObject.transform;
        }
        foreach(GameObject obj in resourcesItems){
            this.obj = Instantiate(obj) as GameObject;
            this.obj.transform.parent = gameObject.transform;
        }

    }

}
