using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ResultScore : MonoBehaviour {

	public GameObject objectScore;

	private ScoreManager score;

	// Use this for initialization
	void Start () {
        score = objectScore.GetComponent<ScoreManager>();

	}

    public void getScore(){
        gameObject.GetComponent<Text>().text = score.inYen();

    }

}
