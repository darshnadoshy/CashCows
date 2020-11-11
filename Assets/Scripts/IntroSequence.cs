using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroSequence : MonoBehaviour
{
    private Transform WelcomeScreen;
    private static int time = 0;

    // Start is called before the first frame update
    void Start()
    {
        WelcomeScreen = transform.Find("Welcome");
        WelcomeScreen.gameObject.SetActive(true);
        RectTransform WelcomeRectTransform = WelcomeScreen.GetComponent<RectTransform>();
        WelcomeRectTransform.anchoredPosition = new Vector2(0f,0f);
    }

    // Update is called once per frame
    void Update()
    {
        time += 1;
        if (time == 15){
            WelcomeScreen.gameObject.SetActive(false);
        }
    }
}
