using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public int totalMoola;
    //private static int minMoola;
    public Text PlayerMoola;

    // Start is called before the first frame update
    void Start()
    {
        totalMoola = 200;
        //minMoola = 0;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoola.text = "" + totalMoola;
    }

    // void updateMoola(){
        
    // }
}
