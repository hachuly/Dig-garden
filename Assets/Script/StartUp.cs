using UnityEngine;
using System.Collections;

public class StartUp : MonoBehaviour {

    public GameObject objectPrefabManager;

    private RelateSetting parent;
    private RandomSelectItems objectJewelry;

    private GameObject[] Generator_main;

    private Vector2 Base_position;
    private Vector3 positionJewelry;

	// Use this for initialization
	void Start () {
        objectJewelry = GameObject.Find("Scramble").GetComponent<RandomSelectItems>();
        parent = gameObject.GetComponent<RelateSetting>();
        Generator_main = new GameObject[42];

        // generateMain(Prefab.name, Prefab.tag6);

	}

    private void generateMain(string name, string tag){
        if(tag == "tagJewelry"){

            if(name == "L_Ruby" || name == "L_Sapphire" || name == "L_Emerald"){
                generateJewelry_sizeL(tag);

            }else if(name == "M_Ruby" || name == "M_Sapphire" || name == "M_Emerald" || name == "M_Scramble"){
                generateJewelry_sizeM(tag);

            }else if(name == "S_Ruby" || name == "S_Sapphire" || name == "S_Emerald"){
                generateJewelry_sizeS(tag);
            }
        }else if(tag == "tagStone" || tag == "tagSand" || tag == "tagMud"){
            generateStratum(tag);

        }else if(tag == "itemBomb"){
            // generateItem(objectItem);

        }

    }

    private void generateJewelry_sizeL(string tag){
        // Generator_main[0] = Instantiate(Prefab) as GameObject;
        Generator_main[0].transform.position = findPosition(tag, 6, 5, new Vector2(-0.105f, -0.055f));
        Generator_main[0].transform.parent = gameObject.transform;
        positionJewelry = Generator_main[0].transform.position;

    }

    private void generateJewelry_sizeM(string tag){
        Generator_main[0] = Instantiate(objectJewelry.randomSelect()) as GameObject;
        Generator_main[0].transform.position = findPosition(tag, 6, 5, new Vector2(-0.12f, -0.07f));
        Generator_main[0].transform.parent = gameObject.transform;

    }

    private void generateJewelry_sizeS(string tag){
        // Generator_main[0] = Instantiate(Prefab) as GameObject;
        // Generator_main[0].transform.position = find_gameobject(Prefab.tag, 7, 6, Vector2.);
        // Generator_main[0].transform.parent = gameObject.transform;

    }

    private void generateStone(int lhs, int rhs){
        if(Random.Range(0, 2) == 1){
            // Generator_main[rhs] = Instantiate(Prefab) as GameObject;
            // Generator_main[rhs].transform.position = findPosition(Prefab.tag, lhs, rhs, new Vector2(-0.135f, -0.085f));
            parent.toParent(Generator_main[rhs]);

        }

    }

    private void generateOther(int lhs, int rhs){
        // Generator_main[rhs] = Instantiate(Prefab) as GameObject;
        // Generator_main[rhs].transform.position = findPosition(Prefab.tag, lhs, rhs, new Vector2(-0.135f, -0.085f));
        Generator_main[rhs].name = Generator_main[rhs].name + lhs.ToString() + rhs.ToString();
        parent.toParent(Generator_main[rhs]);
    }

    private void generateStratum(string tag){
        for(int lhs = 0; lhs < 6; lhs++){
            for(int rhs = 0; rhs < 7; rhs++){
                switch(tag){
                    case "tagStone":
                        generateStone(lhs, rhs);
                        break;
                    case "tagSand":
                        generateOther(lhs, rhs);
                        break;
                    case "tagMud":
                        generateOther(lhs, rhs);
                        break;
                }

            }

        }

    }

    private void generateItem(GameObject item){
        Generator_main[1] = Instantiate(item) as GameObject;
        // Generator_main[1].transform.position = findPosition(Prefab.tag, 6, 5, new Vector2(-0.135f, -0.085f));
        Generator_main[1].transform.parent = gameObject.transform;

    }

    private Vector3 findPosition(string tag, int lhs, int rhs, Vector2 position){
        return new Vector3(
            position.x + Random.Range(1, lhs)*0.03f,
            position.y + Random.Range(1, rhs)*0.03f,
            findPosition_Z(tag));
    }

    private float findPosition_Z(string tag){
        switch(tag){
            case "tagMud":
                return 0.0f;
            case "tagJewely":
                return 0.1f;
            case "tagSand":
                return 0.2f;
            case "tagStone_b":
                return 0.3f;
            case "tagStone":
                return 0.4f;
        }
        return 0f;

    }

}
