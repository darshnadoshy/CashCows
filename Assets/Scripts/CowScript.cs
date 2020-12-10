using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CowScript : MonoBehaviour
{
    public int maxMilk = 5;
    public int currentMilk;
    int milkingFlag;
    int feedingFlag;
    public GameObject popUp;
    public MilkCowScript milkScript;
    public GameObject time;
    public GameObject player;
    public GameObject milkContainer;
    public GameObject feedContainer;
    public GameObject buttonContainer;
    public GameObject BackButton;
    public GameObject FeedPopUp;
    public GameObject HayStack;
    public GameObject NoHayPopUp;
    public Inventory inventory;

    // Start is called before the first frame update
    void Start()
    {
        currentMilk = 0;
        milkScript.SetMaxMilk(maxMilk);
        popUp.SetActive(false);
        milkContainer.SetActive(false);
        buttonContainer.SetActive(true);
        BackButton.SetActive(false);
        FeedPopUp.SetActive(false);
        feedContainer.SetActive(false);
        HayStack.SetActive(false);
        NoHayPopUp.SetActive(false);
        milkingFlag = 0;
        feedingFlag = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(milkingFlag == 1){
            if (Input.GetMouseButtonDown(0)) {
                currentMilk += 1;
                milkScript.SetMilk(currentMilk);
                if(currentMilk == maxMilk){
                    popUp.SetActive(true);
                    Inventory.MilkCount++;
                    List<CowObject> list = player.GetComponent<PlayerScript>().GetListCows();

                    // Find currently milked cow and set milked status to true, also start reset coroutine
                    //Debug.Log("MILKED: " + PlayerPrefs.GetString("currentlyBeingMilked"));
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
        } else if(feedingFlag == 1){
            feedContainer.SetActive(true);
        }
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

    public void ClickFeedButton(){
        feedingFlag = 1;
        feedContainer.SetActive(true);
        BackButton.SetActive(true);
    }

    public void ClickBackButton(){
        buttonContainer.SetActive(true);
        milkContainer.SetActive(false);
        milkingFlag = 0;
        feedingFlag = 0;
        BackButton.SetActive(false);
        popUp.SetActive(false);
        FeedPopUp.SetActive(false);
        feedContainer.SetActive(false);
        NoHayPopUp.SetActive(false);
        //and feed & clean containers = false
    }

    public void HayButton(){
        if (Inventory.HayCount > 0) {
            Inventory.HayCount--;
            HayStack.SetActive(true);
            FeedPopUp.SetActive(true);
        } else {
            NoHayPopUp.SetActive(true);
        }
    }
}
