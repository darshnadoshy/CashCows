using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeScript : MonoBehaviour
{
    public void SceneChange(string scene){
        SceneManager.LoadScene(scene);
    }

    // public void SceneChangePopUpToCow(string scene){
    //     SceneManager.LoadScene(scene);
    // }

    // public void PopUp(GameObject obj){
    //     obj.enabled = true;
    // }
}
