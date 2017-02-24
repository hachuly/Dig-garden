using UnityEngine;
using System.Collections;

public class HummerController : MonoBehaviour {

    public GameObject Prefab;
    private GameObject FlipFlop;

    void OnCollisionEnter2D(Collision2D other){
        // Destroy(other.gameObject);
        Debug.Log(other.gameObject.name);
    }

    public void inPosition(Vector2 Position){
        Instantiate(Prefab, new Vector3(Position.x,  Position.y, 0f), Quaternion.identity);
    }

}
