using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPasture : MonoBehaviour
{
    public Camera mainCamera;
    public Camera PastureSideCamera;

    void onMouseDown(){
        Destroy(gameObject);
    }

    //create UI object for back button to go back to home screen
}
