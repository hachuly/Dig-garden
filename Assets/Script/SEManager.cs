using UnityEngine;
using System.Collections;

public class SEManager : MonoBehaviour {

    public GameObject objectStoneSE;
    public GameObject objectSandSE;
    public GameObject objectJewelrySE;
    public GameObject objectMoneySE;

    private SoundEffect stoneSE;
    private SoundEffect sandSE;
    private SoundEffect jewelrySE;
    private SoundEffect moneySE;

	// Use this for initialization
	void Start () {

        stoneSE = objectStoneSE.GetComponent<SoundEffect>();
        sandSE = objectSandSE.GetComponent<SoundEffect>();
        jewelrySE = objectJewelrySE.GetComponent<SoundEffect>();
        moneySE = objectMoneySE.GetComponent<SoundEffect>();
	}

    public void setActive(string tag){
        switch(tag){
            case "tagSand": stoneSE.playSoundEffect();
                break;
            case "tagStone": sandSE.playSoundEffect();
                break;
            case "tagJewelry": jewelrySE.playSoundEffect();
                break;
            case "tagMoney": moneySE.playSoundEffect();
                break;
        }

    }

}
