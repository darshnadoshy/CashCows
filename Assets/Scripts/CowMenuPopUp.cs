using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CowMenuPopUp : MonoBehaviour
{
    private Transform container;
    private Transform cowItemTemplate;
    private Transform cowText;
    private Transform cowBackground;
    private Transform backButton;
    public GameObject player; // for list of cows
    
    //static int flag = 0; //use to switch on and off? look up tutorial?
    private void Awake(){
        container = transform.Find("container");
        cowItemTemplate = container.Find("MenuObjTemplate");
        cowText = transform.Find("MilkCowText");
        cowBackground = transform.Find("MenuBackground");
        backButton = transform.Find("BackButtonMenu");
        cowItemTemplate.gameObject.SetActive(false);
        cowText.gameObject.SetActive(false);
        cowBackground.gameObject.SetActive(false);
        backButton.gameObject.SetActive(false);
    }

    public void onTrigger(){
        cowText = transform.Find("MilkCowText");
        cowBackground = transform.Find("MenuBackground");
        cowText.gameObject.SetActive(true);
        cowBackground.gameObject.SetActive(true);
        backButton.gameObject.SetActive(true);
        int count = 0;
        Debug.Log(count.ToString());

        for(int i = 0; i < player.GetComponent<PlayerScript>().GetListCows().Count; i++){
            if(!player.GetComponent<PlayerScript>().GetListCows()[i].GetMilkedStatus()){
                CreateMenuItem(player.GetComponent<PlayerScript>().GetListCows()[i], count);
                count++;
            }
        }
    }

    private void CreateMenuItem(CowObject cow, int positionIndex){
        Transform cowItemTransform = Instantiate(cowItemTemplate, container);
        cowItemTransform.gameObject.SetActive(true);
        RectTransform cowItemRectTransform = cowItemTransform.GetComponent<RectTransform>();

        float itemHeight = 50f;
        cowItemRectTransform.anchoredPosition = new Vector2(0, -itemHeight * positionIndex);
        cowItemTransform.Find("CowName").GetComponent<Text>().text = cow.getName();
        Debug.Log(cow.getName() + " milked: " + cow.GetMilkedStatus());
        if(cow.GetMilkedStatus() == true){ 
            cowItemTransform.Find("HiddenButtonMenuPopup").GetComponent<Button>().interactable = false;
        } else {
            cowItemTransform.Find("HiddenButtonMenuPopup").GetComponent<Button>().interactable = true;
        }
    }

    public void closeMenu(){
        container = transform.Find("container");
        cowText = transform.Find("MilkCowText");
        cowBackground = transform.Find("MenuBackground");
        backButton = transform.Find("BackButtonMenu");
        cowText.gameObject.SetActive(false);
        cowBackground.gameObject.SetActive(false);
        backButton.gameObject.SetActive(false);
        for(int i = 0; i < player.GetComponent<PlayerScript>().GetListCows().Count; i++){
            if(!player.GetComponent<PlayerScript>().GetListCows()[i].GetMilkedStatus()){
                Debug.Log("menuobjLOOP");
                cowItemTemplate = container.Find("MenuObjTemplate(Clone)");
                cowItemTemplate.gameObject.SetActive(false);
            }
        }
    }

}
