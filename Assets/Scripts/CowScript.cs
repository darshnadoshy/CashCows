using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CowScript : MonoBehaviour
{
    public int maxMilk = 5;
    public int currentMilk;

    public MilkCowScript milkBar;
    public Camera mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        currentMilk = 0;
        milkBar.SetMaxMilk(maxMilk);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            if(currentMilk == maxMilk){
                return;
            }
            AddMilk();
            milkBar.SetMilk(currentMilk);
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
