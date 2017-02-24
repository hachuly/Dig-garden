using UnityEngine;
using System.Collections;

public class StatumGenerator : Blueprint {

	// Use this for initialization
	void Start () {
        startGenerate(hasRandom());
	}

    private void startGenerate(bool trigger){
        if(trigger){
            generateRandom(getResource(), getBasicPosition());
        }else{
            generateGeneral(getResource(), getBasicPosition());
        }

    }

    private void generateRandom(GameObject obj, Vector3 position){

    }

    private void generateGeneral(GameObject obj, Vector3 position){

    }

}
