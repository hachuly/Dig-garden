using UnityEngine;
using System.Collections;

public class DurableValueController : MonoBehaviour {

    public float durable;

    // マウスボタンが押された時にコールされる
    void OnMouseDown() {
        Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D other){
        // Debug.Log(other.gameObject.name);
    }

    void OnCollisionExit2D(Collision2D other){
        Debug.Log(other.gameObject.name);
    }

}
