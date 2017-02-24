using UnityEngine;
using System;
using System.Collections;

public class RelateSetting : MonoBehaviour{

	public void toParent(GameObject obj){
		obj.transform.parent = gameObject.transform;

    }

}
