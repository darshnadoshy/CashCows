using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sizing : MonoBehaviour
{

    public GameObject BackgroundImage;
    public Camera mainCam;

    // Start is called before the first frame update
    void Start()
    {
        ScaleScreen();
    }

    void ScaleScreen(){
        Vector2 device = new Vector2(Screen.width, Screen.height);

        float height = Screen.height;
        float width = Screen.width;

        float DEVICE_ASPECT = width/height;

        mainCam.aspect = DEVICE_ASPECT;

        float camHeight = 100f + mainCam.orthographicSize + 2.0f;
        float camWidth = camHeight + DEVICE_ASPECT;
    }
}
