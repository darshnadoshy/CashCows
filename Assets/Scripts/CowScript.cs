using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CowScript : MonoBehaviour
{
    public int maxMilk = 5;
    public int currentMilk;

    public MilkCowScript milkBar;
    public GameObject time;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        currentMilk = 0;
        milkBar.SetMaxMilk(maxMilk);
        PlayerPrefs.SetString("currentlyBeingMilked", "None");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            AddMilk();
            milkBar.SetMilk(currentMilk);
            if(currentMilk == maxMilk){
                player.GetComponent<PlayerScript>().AddMoola(100);
                List<CowObject> list = player.GetComponent<PlayerScript>().GetListCows();

                for(int i = 0; i < list.Count; i++){
                    if(list[i].getName() == PlayerPrefs.GetString("currentlyBeingMilked")){
                        list[i].SetMilkedStatus(true);
                        StartCoroutine(ResetMilk(list[i]));
                        break;
                    }
                }
                return;
            } 
        }
    }

    void AddMilk(){
        currentMilk += 1;
    }

    IEnumerator ResetMilk(CowObject cowObj){
        yield return new WaitForSeconds(60);
        cowObj.SetMilkedStatus(false);
        cowObj.ChangeButtonInteractable(true);
    }

}
