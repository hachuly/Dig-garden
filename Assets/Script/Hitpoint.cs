﻿using UnityEngine;
using System.Collections;

public class Hitpoint : MonoBehaviour {

    public GameObject objectSE;

    private WaveManager game;
    private ScoreManager adder;
    private SEManager sound;

    public int def;
    public int yen;

    private bool trigger;

	// Use this for initialization
	void Start () {
        adder = GameObject.Find("Score").GetComponent<ScoreManager>();
        // end = GameObject.Find("Script_StratumManager").GetComponent<WaveManager>();
        sound = objectSE.GetComponent<SEManager>();
	}

    public void attackTratum(int str){
        def -= str;
        if(def < 0){
            adder.addScore(yen);
            Destroy(gameObject);
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
        adder.addScore(yen);
        trigger = true;
        // end.reset();
    }

    public void isAnotherPenalty(){
        def--;
        yen /=2;
        adder.getPenalty(yen.ToString());
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
