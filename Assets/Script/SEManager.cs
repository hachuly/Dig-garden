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
            case "tagStone": Debug.Log(tag);
                stoneSE.playSoundEffect();
                break;
            case "tagSand": Debug.Log(tag);
                sandSE.playSoundEffect();
                break;
            case "tagJewelry": Debug.Log(tag);
                jewelrySE.playSoundEffect();
                break;
            case "tagMoney": Debug.Log(tag);
                moneySE.playSoundEffect();
                break;
        }

    }

}
