using UnityEngine;

public class ButtonUI : MonoBehaviour {

	public GameObject objectRadioButton, objectTool, objectBlackCellophane;

    private RadioButtonUI button;

    private void Start(){
        button = objectRadioButton.GetComponent<RadioButtonUI>();

    }

    private void OnMouseDown(){
		onState();

    }

    public void onState(){
        objectBlackCellophane.SetActive(false);
        objectTool.SetActive(true);
        button.onRadioButton(gameObject.tag);

    }

    public void offState(){
        objectBlackCellophane.SetActive(true);
        objectTool.SetActive(false);

    }

    public void initalSettingState(){
        objectBlackCellophane.SetActive(false);
        objectTool.SetActive(true);
        objectRadioButton.GetComponent<RadioButtonUI>().onRadioButton(gameObject.tag);

    }

}
