using UnityEngine;
using System.Collections;

public class ToolUIManager : MonoBehaviour {

    private PickaxeUIManager PickaxeUI;
    private HammerUIManager HammerUI;
    private DorillUIManager DorillUI;
    private BombUIManager BombUI;

    private bool isPickaxe;
    private bool isHammer;
    private bool isDorill;
    private bool isBomb;

	// Use this for initialization
	void Start () {
        PickaxeUI = GameObject.Find("UI_Pickaxe").GetComponent<PickaxeUIManager>();
        HammerUI = GameObject.Find("UI_Hammer").GetComponent<HammerUIManager>();
        DorillUI = GameObject.Find("UI_Dorill").GetComponent<DorillUIManager>();
        BombUI = GameObject.Find("UI_Bomb").GetComponent<BombUIManager>();

        isPickaxe = true;
        isHammer = true;
        isDorill = true;
        isBomb = true;

	}

    public void ToolManager(string tag){
        switch(tag){
            case "tagPickaxe":
                setPickaxe();
                break;
            case "tagHammer":
                setHammer();
                break;
            case "tagDorill":
                setDorill();
                break;
            case "tagBomb":
                setBomb();
                break;
        }
    }

    private void setPickaxe(){
        if(isPickaxe){
            PickaxeUI.setActive_shadow(isPickaxe = false);
            HammerUI.setActive_shadow(isHammer = true);
            DorillUI.setActive_shadow(isDorill = true);
            BombUI.setActive_shadow(isBomb = true);
        }

    }

    private void setHammer(){
        if(isHammer){
            PickaxeUI.setActive_shadow(isPickaxe = true);
            HammerUI.setActive_shadow(isHammer = false);
            DorillUI.setActive_shadow(isDorill = true);
            BombUI.setActive_shadow(isBomb = true);
        }

    }

    private void setDorill(){
        if(isDorill){
            PickaxeUI.setActive_shadow(isPickaxe = true);
            HammerUI.setActive_shadow(isHammer = true);
            DorillUI.setActive_shadow(isDorill = false);
            BombUI.setActive_shadow(isBomb = true);
        }

    }

    private void setBomb(){
        if(isBomb){
            PickaxeUI.setActive_shadow(isPickaxe = true);
            HammerUI.setActive_shadow(isHammer = true);
            DorillUI.setActive_shadow(isDorill = true);
            BombUI.setActive_shadow(isBomb = false);
        }

    }

}
