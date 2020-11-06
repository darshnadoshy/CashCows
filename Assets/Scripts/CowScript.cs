using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CowScript : MonoBehaviour
{
    public int maxMilk = 5;
    public int currentMilk;

    public MilkCowScript milkBar;
    public GameObject popUp;
    public GameObject player;

    private int milkBarFilledFlag = 0;

    // Start is called before the first frame update
    void Start()
    {
        currentMilk = 0;
        milkBar.SetMaxMilk(maxMilk);
       // popUp = GameObject.Find("PopUp");
        popUp.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(milkBarFilledFlag == 1){
            return;
        }
        if (Input.GetMouseButtonDown(0)) {
            AddMilk();
            milkBar.SetMilk(currentMilk);
            if(currentMilk == maxMilk){
                player.GetComponent<PlayerScript>().AddMoola(100);
                milkBarFilledFlag = 1;
                popUp.SetActive(true);
                return;
            } 
        }
    }

    // void onMouseDown(){
    //     if(currentMilk == maxMilk){
    //             return;
    //         }
    //         AddMilk();
    //         milkBar.SetMilk(currentMilk);
    // }

    void AddMilk(){
        currentMilk += 1;
    }
}
