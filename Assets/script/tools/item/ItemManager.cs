using UnityEngine;

public class ItemManager : MonoBehaviour {

    public int items;

	// Use this for initialization
	void Start () {
        items = 0;
	}

    public void addItems(){
        items++;
    }

    public void takeItems(){
        items--;
    }

    public int showItems(){
        return items;
    }

}
