using UnityEngine;
using System.Collections;

public class WaveManager : MonoBehaviour {

    public GameObject Prefab;
    private GameObject Generator;

	// Use this for initialization
	void Start () {
        Generator = GameObject.Find("Generator_SetUp");
	}

    public void reset(){
        Destroy(Generator);
        Generator = Instantiate(Prefab) as GameObject;
        Generator.transform.parent = gameObject.transform;
    }

}
