using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CowPopupButtonHandler : MonoBehaviour
{
    public void setCurrentlyMilked(Text Name){
        PlayerPrefs.SetString("currentlyBeingMilked", Name.ToString());
    }

    public void buttonOff(Button button){
        button.interactable = false;
    }
}
