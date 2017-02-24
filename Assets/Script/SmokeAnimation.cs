using UnityEngine;

public class SmokeAnimation : MonoBehaviour {

    public GameObject objSmoke;
    private GameObject generat;

    public void playAnimation(Vector2 position){
        generat = Instantiate(objSmoke) as GameObject;
        generat.transform.position = new Vector3(position.x, position.y, -0.5f);

    }

}
