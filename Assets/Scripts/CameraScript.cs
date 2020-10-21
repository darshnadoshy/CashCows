using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
    public Camera mainCamera;
    public Camera PastureSideCamera;
    public Camera PastureOverheadCamera;

    public void Start(){
        mainCamera.enabled = true;
    }

    public void ShowMainView() {
        PastureSideCamera.enabled = false;
        PastureOverheadCamera.enabled = false;
        mainCamera.enabled = true;
    }
    
    public void ShowPastureSideView() {
        PastureSideCamera.enabled = true;
        PastureOverheadCamera.enabled = false;
        mainCamera.enabled = false;
    }

    public void ShowPastureOverheadView() {
        PastureSideCamera.enabled = false;
        PastureOverheadCamera.enabled = true;
        mainCamera.enabled = false;
    }
}
