using UnityEngine;

public class Tool : MonoBehaviour {

    public GameObject objectSE;
    public GameObject objectGauge;
    public GameObject objectSmokeAnimation;

    public int damage;
    public float energy;

    private OnAwakeAnimation effect;
    private Hitpoint penalty;
    private toolGauge tank;
    private SEManager sound;

	// Use this for initialization
	void Start () {

        effect = objectSmokeAnimation.GetComponent<OnAwakeAnimation>();
        tank = objectGauge.GetComponent<toolGauge>();
        sound = objectSE.GetComponent<SEManager>();

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
