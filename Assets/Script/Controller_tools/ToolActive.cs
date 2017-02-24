using UnityEngine;
using System.Collections;

public class ToolActive : MonoBehaviour {

    public GameObject isPickaxe;
    public GameObject isHammer;
    public GameObject isDorill;
    public GameObject isBomb;

	// Use this for initialization
	void Start () {
        isPickaxe = GameObject.Find("isPickaxe");
        isHammer = GameObject.Find("isHammer");
        isDorill = GameObject.Find("isDorill");
        isBomb = GameObject.Find("isBomb");

        isPickaxe.SetActive(false);
        isHammer.SetActive(false);
        isDorill.SetActive(false);
        isBomb.SetActive(false);
	}

	// Update is called once per frame
	void Update () {

	}

    public void setActive_tool(string tag, bool trigger){
        if(trigger){
            onActive(tag, trigger);
        }else{
            offActive(tag, trigger);
        }

    }

    private void onActive(string tag, bool trigger){
        switch(tag){
            case "tagPickaxe":
                isPickaxe.SetActive(trigger);
                break;
            case "tagHammer":
                isHammer.SetActive(trigger);
                break;
            case "tagDorill":
                isDorill.SetActive(trigger);
                break;
            case "tagBomb":
                isBomb.SetActive(trigger);
                break;
        }
    }

    private void offActive(string tag, bool trigger){

        switch(tag){
            case "tagPickaxe":
                isPickaxe.SetActive(trigger);
                break;
            case "tagHammer":
                isHammer.SetActive(trigger);
                break;
            case "tagDorill":
                isDorill.SetActive(trigger);
                break;
            case "tagBomb":
                isBomb.SetActive(trigger);
                break;
        }

    }

}
