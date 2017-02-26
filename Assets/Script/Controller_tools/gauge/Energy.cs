using UnityEngine;

public class Energy : MonoBehaviour {

    [SerializeField]
    float fuel_consumption;

    bool state;

    float max;
    float min;

    void Start(){
        state = true;
        max = gameObject.transform.localScale.x;
        min = 0f;
    }

    public bool getState(){
        return state;
    }

    public void increaseMeter(float energy){

        if(!state){
            gameObject.transform.localScale = new Vector3(
                gameObject.transform.localScale.x + energy,
                gameObject.transform.localScale.y,
                gameObject.transform.localScale.z
            );

            if(max < gameObject.transform.localScale.x){
                gameObject.transform.localScale = new Vector3(
                    max,
                    gameObject.transform.localScale.y,
                    gameObject.transform.localScale.z
                );
                state = true;

            }

        }

    }

    public void decreaseMeter(){

        if(state){
            gameObject.transform.localScale = new Vector3(
                gameObject.transform.localScale.x - fuel_consumption,
                gameObject.transform.localScale.y,
                gameObject.transform.localScale.z
            );

            if(min > gameObject.transform.localScale.x){
                gameObject.transform.localScale = new Vector3(
                    min,
                    gameObject.transform.localScale.y,
                    gameObject.transform.localScale.z
                );
                state = false;
            }

        }

    }

}
