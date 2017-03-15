using UnityEngine;
using System.Collections;

public class ItemStock : MonoBehaviour {

    public GameObject objectToolBomb;
    private int str = 0;
    private ItemManager sender;

    void Start(){
        sender = objectToolBomb.GetComponent<ItemManager>();
    }

    public void getItem(){
        sender.addItems();
    }

    public void useItem(){
        sender.takeItems();
    }

}
