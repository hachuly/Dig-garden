using UnityEngine;

public class OnAwakeAnimation : MonoBehaviour {

    public GameObject obj;
    private GameObject generat;

    public void playAnimation(Vector2 position){
		generat = Instantiate(obj) as GameObject;
        generat.transform.position = new Vector3(position.x, position.y, -0.5f);

    }
}
