using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CowScript : MonoBehaviour
{
    public int maxMilk = 5;
    public int currentMilk;
    public GameObject popUp;
    public MilkCowScript milkBar;
    public GameObject time;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        currentMilk = 0;
        milkBar.SetMaxMilk(maxMilk);
        PlayerPrefs.SetString("currentlyBeingMilked", "None");
        popUp.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            AddMilk();
            milkBar.SetMilk(currentMilk);
            if(currentMilk == maxMilk){
                player.GetComponent<PlayerScript>().AddMoola(100);
                popUp.SetActive(true);
                List<CowObject> list = player.GetComponent<PlayerScript>().GetListCows();

                // Find currently milked cow and set milked status to true, also start reset coroutine
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

    // Resets cow's milked status and lets button be interactable again
    IEnumerator ResetMilk(CowObject cowObj){
        yield return new WaitForSeconds(60);
        cowObj.SetMilkedStatus(false);
        cowObj.ChangeButtonInteractable(true);
    }

}
