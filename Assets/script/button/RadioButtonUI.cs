using UnityEngine;

public class RadioButtonUI : MonoBehaviour {

    public GameObject[] objectButton;
    public string tag;

    private void Start(){
        ResetRadioButton();

    }

    public void onRadioButton(string tag){
        foreach(GameObject obj in objectButton){
            if(tag != obj.tag){
                obj.GetComponent<ButtonUI>().offState();

            }

        }

    }

    private void ResetRadioButton(){
        foreach(GameObject obj in objectButton){
            if(obj.tag == this.tag){
                obj.GetComponent<ButtonUI>().initalSettingState();

            }

        }

    }

}
