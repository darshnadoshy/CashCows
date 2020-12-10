using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSceneController : MonoBehaviour
{
    public GameObject player;
    public Achievements ach;
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    void Update()
    {
        if(player.GetComponent<PlayerScript>().GetCheckingsMoola() == 100){
            ach.increaseCount("A01");
        } 
        if(player.GetComponent<PlayerScript>().GetCheckingsMoola() == 500){
            ach.increaseCount("A02");
        } 
    }
}
