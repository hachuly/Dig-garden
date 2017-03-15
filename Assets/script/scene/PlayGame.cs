using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour {

	// Use this for initialization
    public void isStartGame(){
        SceneManager.LoadScene("GameScene");
    }
}
