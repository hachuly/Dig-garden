using UnityEngine;
using System.Collections;

public class RandomSelectItems : MonoBehaviour {

    public GameObject[] jewelry;
    private GameObject sentObject;

    public GameObject randomSelect(){
        sentObject = jewelry[Random.Range(0, 3)];
        return sentObject;

    }

}
