using UnityEngine;
using System.Collections;

public class DorillUIManager : MonoBehaviour {

    private ToolUIManager isTrigger;
    private ToolActive isActive;

    private GameObject obj;

    // Use this for initialization
    void Start () {
        isTrigger = GameObject.Find("UI_Manager").GetComponent<ToolUIManager>();
        isActive = GameObject.Find("isActive").GetComponent<ToolActive>();

        obj = GameObject.Find("isShadow_d");
    }

    // Update is called once per frame
    void Update () {

    }

    void OnMouseDown(){
        isTrigger.ToolManager(gameObject.tag);
    }

    public void setActive_shadow(bool trigger){
        obj.SetActive(trigger);
        if(trigger){
            isActive.setActive_tool(gameObject.tag, false);
        }else{
            isActive.setActive_tool(gameObject.tag, true);

        }

    }

}
