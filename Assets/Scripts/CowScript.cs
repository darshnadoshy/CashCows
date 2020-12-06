using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CowScript : MonoBehaviour
{
    public int maxMilk = 5;
    public int currentMilk;
    int milkingFlag;
    public GameObject popUp;
    public MilkCowScript milkScript;
    public GameObject time;
    public GameObject player;
    public GameObject milkContainer;
    public GameObject buttonContainer;
    public GameObject BackButton;

    // Start is called before the first frame update
    void Start()
    {
        currentMilk = 0;
        milkScript.SetMaxMilk(maxMilk);
        popUp.SetActive(false);
        milkContainer.SetActive(false);
        buttonContainer.SetActive(true);
        BackButton.SetActive(false);
        milkingFlag = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(milkingFlag == 1){
            if (Input.GetMouseButtonDown(0)) {
                AddMilk();
                milkScript.SetMilk(currentMilk);
                if(currentMilk == maxMilk){
                    player.GetComponent<PlayerScript>().AddMoola(100);
                    popUp.SetActive(true);
                    List<CowObject> list = player.GetComponent<PlayerScript>().GetListCows();

                    // Find currently milked cow and set milked status to true, also start reset coroutine
                    Debug.Log("MILKED: " + PlayerPrefs.GetString("currentlyBeingMilked"));
                    for(int i = 0; i < list.Count; i++){
                        if(list[i].getName() == PlayerPrefs.GetString("currentlyBeingMilked")){
                            list[i].SetMilkedStatus(true);
                            PlayerPrefs.SetString("currentlyBeingMilked", "None");
                            StaticCoroutineRunner.RunCoroutine(ResetMilk(list[i]));
                            break;
                        }
                    }
                    return;
                } 
            }
        }
    }

    void AddMilk(){
        currentMilk += 1;
    }

    // Resets cow's milked status and lets button be interactable again
    IEnumerator ResetMilk(CowObject cowObj){
        yield return new WaitForSeconds(20);
        cowObj.SetMilkedStatus(false);
        Debug.Log("Hit 20 seconds. Milked status: " + cowObj.GetMilkedStatus());
    }

    public void Clicked(){
        buttonContainer.SetActive(false);
    }

    public void ClickMilkButton(){
        milkingFlag = 1;
        milkContainer.SetActive(true);
        BackButton.SetActive(true);
    }

    public void ClickCleanButton(){
        
    }

    public void ClickFeedButton(){

    }

    public void ClickBackButton(){
        buttonContainer.SetActive(true);
        milkContainer.SetActive(false);
        milkingFlag = 0;
        BackButton.SetActive(false);
        popUp.SetActive(false);
        //and feed & clean containers = false
    }
}
