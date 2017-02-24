using UnityEngine;
using System.Collections;

public class SEManager : MonoBehaviour {

    public GameObject SEStone;
    public GameObject SESand;
    public GameObject SEJewelry;
    public GameObject SEMoney;

    private AudioSource playStone;
    private AudioSource playSand;
    private AudioSource playJewelry;
    private AudioSource playMoney;

	// Use this for initialization
	void Start () {

        playSand = SESand.GetComponent<AudioSource>();
        playStone = SEStone.GetComponent<AudioSource>();
        playJewelry = SEJewelry.GetComponent<AudioSource>();
        playMoney = SEMoney.GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update () {

	}

    public void setActive(string tag){
        switch(tag){
            case "tagSand": playSand.PlayOneShot(playSand.clip);
                break;
            case "tagStone": playStone.PlayOneShot(playStone.clip);
                break;
            case "tagJewelry": playJewelry.PlayOneShot(playJewelry.clip);
                break;
            case "tagMoney": playMoney.PlayOneShot(playMoney.clip);
                break;
        }
    }
}
