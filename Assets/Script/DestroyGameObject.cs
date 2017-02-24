using UnityEngine;

public class DestroyGameObject : MonoBehaviour {

    void OnAnimationFinish(){
        Destroy(gameObject);
    }
}
