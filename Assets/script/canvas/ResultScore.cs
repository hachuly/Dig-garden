using UnityEngine;
using UnityEngine.UI;

public class ResultScore : MonoBehaviour {

    [SerializeField]
	GameObject objectScore;

	ScoreCanvas score;

	// Use this for initialization
	void Start () {
        score = objectScore.GetComponent<ScoreCanvas>();

	}

    public void getScore(){
        gameObject.GetComponent<Text>().text = score.inYen();

    }

}
