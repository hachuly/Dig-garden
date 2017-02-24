using UnityEngine;

public class toolGauge : MonoBehaviour {

    public bool canActive;

    private float maxGauge;
    private float minGauge;

    void Start(){
        canActive = true;
        maxGauge = gameObject.transform.localScale.x;
        minGauge = 0f;
    }

    public void increaseMeter(float energy){

        if(!canActive){
            gameObject.transform.localScale = new Vector3(
                gameObject.transform.localScale.x + energy,
                gameObject.transform.localScale.y,
                gameObject.transform.localScale.z
            );

            if(maxGauge < gameObject.transform.localScale.x){
                gameObject.transform.localScale = new Vector3(
                    maxGauge,
                    gameObject.transform.localScale.y,
                    gameObject.transform.localScale.z
                );
                canActive = true;

            }

        }

    }

    public void decreaseMeter(){

        if(canActive){
            gameObject.transform.localScale = new Vector3(
                gameObject.transform.localScale.x - 0.03f,
                gameObject.transform.localScale.y,
                gameObject.transform.localScale.z
            );

            if(minGauge > gameObject.transform.localScale.x){
                gameObject.transform.localScale = new Vector3(
                    minGauge,
                    gameObject.transform.localScale.y,
                    gameObject.transform.localScale.z
                );
                canActive = false;
            }

        }

    }

}
