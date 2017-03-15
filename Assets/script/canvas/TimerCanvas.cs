using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimerCanvas : MonoBehaviour {

    [SerializeField]
    GameObject result;
    [SerializeField]
    GameObject timer;
    [SerializeField]
    GameObject score;

    ResultScore show;

    [SerializeField]
    int seconds;
    [SerializeField]
    int minutes;

    int d_ff;
    int setTime;
    bool stop;

	// Use this for initialization
	void Start () {
        show = score.GetComponent<ResultScore>();

        timer = gameObject;
        d_ff = 0;
        setTime = 1;
        stop = true;
    }

	// Update is called once per frame
	void Update () {
        Clock(stop);

	}

    public void Clock(bool trigger){
        if(trigger){
            if(d_ff != (int)Time.time){
                d_ff = (int)Time.time;
                setTimer(setTime);
            }

        }

    }

    public void setTimer(int i){
        timer.GetComponent<Text>().text = setMinutes() + ":" + setSeconds(i) ;
        if(seconds == 0 && minutes == 0){
            stop = false;
            result.SetActive(true);
            show.getScore();

        }

    }

    private string setSeconds(int i){

        if(seconds == 0){
            seconds = 59;
        }else{
            seconds -= i;
        }

        if(seconds < 10){
            return "0" + seconds.ToString();
        }return seconds.ToString();

    }

    private string setMinutes(){
        if(seconds == 0){
            minutes = (minutes - 1);
        }

        if(minutes < 10){
            return "0" + minutes.ToString();
        }return minutes.ToString();

    }

}
