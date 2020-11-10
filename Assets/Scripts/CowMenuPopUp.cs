using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CowMenuPopUp : MonoBehaviour
{
    private Transform container;
    private Transform cowItemTemplate;
    private Transform cowText;
    private Transform cowBackground;
    
    public GameObject player; // for list of cows
    //static int flag = 0; //use to switch on and off? look up tutorial?

    private void Awake(){
        container = transform.Find("container");
        cowItemTemplate = container.Find("MenuObjTemplate");
        cowText = transform.Find("MilkCowText");
        cowBackground = transform.Find("MenuBackground");
        cowItemTemplate.gameObject.SetActive(false);
        cowText.gameObject.SetActive(false);
        cowBackground.gameObject.SetActive(false);
    }

    public void onTrigger(){
        cowText = transform.Find("MilkCowText");
        cowBackground = transform.Find("MenuBackground");
        cowText.gameObject.SetActive(true);
        cowBackground.gameObject.SetActive(true);

        for(int i = 0; i < player.GetComponent<PlayerScript>().GetListCows().Count; i++){
            CreateMenuItem(player.GetComponent<PlayerScript>().GetListCows()[i].Name, i+1);
        }
    }

    private void CreateMenuItem(string cowName, int positionIndex){
        Transform cowItemTransform = Instantiate(cowItemTemplate, container);
        cowItemTransform.gameObject.SetActive(true);
        RectTransform cowItemRectTransform = cowItemTransform.GetComponent<RectTransform>();

        float itemHeight = 50f;
        cowItemRectTransform.anchoredPosition = new Vector2(0, -itemHeight * positionIndex);
        cowItemTransform.Find("CowName").GetComponent<Text>().text = cowName;
    }
}
