using UnityEngine;
using System;

public class Tool : MonoBehaviour {

    public GameObject objectSE;
    public GameObject objectGauge;
    public GameObject objectSmokeAnimation;

    public int damage;
    public float energy;

    private OnAwakeAnimation effect;
    private Hitpoint penalty;
    private Gauge tank;
    private SEManager sound;

	// Use this for initialization
	void Start () {

        effect = objectSmokeAnimation.GetComponent<OnAwakeAnimation>();
        tank = objectGauge.GetComponent<Gauge>();
        sound = objectSE.GetComponent<SEManager>();

	}

	protected void loodTool(){
		int layer = 1 << 8;
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		tryRaycast(layer, ray);

	}

	private void tryRaycast(int layer, Ray ray){
		RaycastHit2D hit;
		GameObject obj;

		try{
			hit = Physics2D.Raycast((Vector2)ray.origin, Vector2.zero, 1, layer);
			obj = hit.collider.gameObject;
			damageDeclaration(obj);
		}catch(NullReferenceException error){
			Debug.Log(error);
		}

	}

    protected void damageDeclaration(GameObject obj){
        penalty = obj.GetComponent<Hitpoint>();
        playEffect(obj);
        // tank.increaseMeter(energy);
        if(obj.tag == "tagSand" || obj.tag == "tagStone"){
            penalty.attackTratum(damage);
        }else if(obj.tag == "tagJewelry"){
            penalty.isPenaltyTrigger();
        }

    }

    protected void playEffect(GameObject obj){
        effect.playAnimation(obj.transform.position);
        sound.setActive(obj.tag);

    }

}
