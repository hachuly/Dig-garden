using UnityEngine;
using System;

public class Tool : MonoBehaviour {

	[SerializeField]
    protected GameObject objectSE;
	[SerializeField]
    protected GameObject objectGauge;
	[SerializeField]
    protected GameObject objectSmokeAnimation;

	[SerializeField]
	int damage;
	[SerializeField]
	float energy;

	protected OnAwakeAnimation effect;
	protected Hitpoint penalty;
	protected Energy tank;
	protected SEManager sound;

	// Use this for initialization
	void Awake () {
        this.sound = objectSE.GetComponent<SEManager>();
        this.effect = objectSmokeAnimation.GetComponent<OnAwakeAnimation>();
        this.tank = objectGauge.GetComponent<Energy>();

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
            damageDeclaration(obj, getDamagePoint());
            playEffect(obj);
            addEnergy();
        }catch(NullReferenceException error){
            Debug.Log("tool : " + error);
        }

    }

    protected void damageDeclaration(GameObject obj, int damage){
        string objTag = obj.tag;
        penalty = obj.GetComponent<Hitpoint>();

        if(objTag == "tagSand" || objTag == "tagStone"){
            penalty.attackTratum(damage);
        }else if(objTag == "tagJewelry"){
            penalty.isPenaltyTrigger();
        }

    }

    protected void playEffect(GameObject obj){
        sound.setActive(obj.tag);
        effect.playAnimation(obj.transform.position);

    }

    protected int getDamagePoint(){
        return this.damage;

    }

    protected bool checkGaugeState(){
        return tank.getState();

    }

    protected void addEnergy(){
        tank.increaseMeter(this.energy);

    }

    protected void sumEnergy(){
        tank.decreaseMeter();

    }

}
