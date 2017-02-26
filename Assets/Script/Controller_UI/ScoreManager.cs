using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour {

    private GameObject yen;

    private int c_yen;
    private int k_yen;
    private int m_yen;
    private int g_yen;

	// Use this for initialization
	void Start () {
        yen = gameObject;
        c_yen = 0;
        k_yen = 0;
        m_yen = 0;
        g_yen = 0;
	}

    public void addScore(int i){
        c_yen += i;
        if(999 < c_yen){
            k_yen++;
            c_yen = 0;
        }showScore();
    }

    private void showScore(){
        yen.GetComponent<Text>().text = setYen(g_yen) + ","+ setYen(m_yen) +","+ setYen(k_yen) +","+ setYen(c_yen);
    }

    private string setYen(int i){
        if(i < 10){
            return "00" + i;
        }else if(i < 100){
            return "0" + i;
        }return i.ToString();
    }

    public void getPenalty(string i){

        if(i.Length > 9){Debug.Log(i);
            g_yen = int.Parse(i.Remove(i.Length -9,i.Length -1));
            i = i.Remove(0,2);
        }if(i.Length > 6){Debug.Log(i);
            m_yen = int.Parse(i.Remove(i.Length -6,i.Length -1));
            i = i.Remove(0,2);
        }if(i.Length > 3){Debug.Log(i);
            k_yen = int.Parse(i.Remove(i.Length -3,i.Length -1));
            i = i.Remove(0,2);
        }Debug.Log(i);c_yen = int.Parse(i);

    }

    public string inYen(){
        return  setYen(g_yen) + ","+ setYen(m_yen) +","+ setYen(k_yen) +","+ setYen(c_yen)+"yen";
    }

}
