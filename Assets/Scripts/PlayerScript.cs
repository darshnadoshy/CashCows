using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    static public int totalMoola = 200;
    //private static int minMoola;
    public Text PlayerMoola;

    // Start is called before the first frame update
    void Start()
    {
        PlayerMoola.text = "" + totalMoola;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoola.text = "" + totalMoola;
    }

    public void AddMoola(int moola){
        totalMoola += moola;
    }

    public void SubtractMoola(int moola){
        if(totalMoola - moola < 0){
            Debug.Log("Not enough money");
        } else {
            totalMoola -= moola;
        }
    }
}
