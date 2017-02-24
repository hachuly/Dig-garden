using UnityEngine;
using System.Collections;

public class StatumGenerator : Blueprint {

    private GameObject obj;

	// Use this for initialization
	void Start () {
        startGenerate(hasRandom());
	}

    private void startGenerate(bool trigger){
        for(int lhs = 0; lhs < 7; lhs++){
            for(int rhs  = 0; rhs < 6; rhs++){
                if(trigger){
                    generateRandom((float)lhs, (float)rhs);
                }else{
                    generateGeneral((float)lhs, (float)rhs);
                }
            }

        }

    }

    private void generateRandom(float lhs, float rhs){
        if(Random.Range(0, 2) == 1){
            this.obj = Instantiate(getResource()) as GameObject;
            this.obj.transform.position = findPosition(getBasicPosition(), lhs, rhs);
        }

    }

    private void generateGeneral(float lhs, float rhs){
        this.obj = Instantiate(getResource()) as GameObject;
        this.obj.transform.position = findPosition(getBasicPosition(), lhs, rhs);
    }

    private Vector3 findPosition(Vector3 position, float lhs, float rhs){
        return new Vector3(
            position.x + lhs * 0.03f,
            position.y + rhs * 0.03f,
            position.z
        );
    }



}
