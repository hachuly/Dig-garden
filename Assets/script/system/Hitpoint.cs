using UnityEngine;
using System.Collections;

public class Hitpoint : MonoBehaviour {

    [SerializeField]
    GameObject objectSE;
    [SerializeField]
    GameObject objectScore;
    [SerializeField]
    GameObject objectEnd;

    WaveManager game;
    ScoreCanvas score;
    SEManager sound;

    [SerializeField]
    int def;
    [SerializeField]
    int yen;

    bool trigger;

	// Use this for initialization
	void Start () {
        // end = GameObject.Find("Script_StratumManager").GetComponent<WaveManager>();
        score = objectScore.GetComponent<ScoreCanvas>();
        sound = objectSE.GetComponent<SEManager>();

	}

    public void attackTratum(int str){
        def -= str;
        if(def < 0){
            score.addScore(yen);

        }

    }

    public void isPenalty(){
        def--;
        yen /= 2;
        if(def < 0){
            // end.reset();
        }

    }

    public void getJewelry(){

        sound.setActive("tagMoney");
        score.addScore(yen);
        trigger = true;
        // end.reset();
    }

    public void isAnotherPenalty(){
        def--;
        yen /=2;
        score.getPenalty(yen.ToString());
        if(def < 0){
            Destroy(gameObject);
            // end.reset();
        }

    }

    public void isPenaltyTrigger(){
        if(trigger){
            isAnotherPenalty();
        }else{
            isPenalty();
        }

    }

}
