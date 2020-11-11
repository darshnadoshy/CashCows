using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroSequence : MonoBehaviour
{
    private Transform IntroSeq;
    //private Transform WelcomeScreen;
    private static int time = 0;

    // Start is called before the first frame update
    void Start()
    {
        IntroSeq = transform.Find("IntroSequence");
        //WelcomeScreen = IntroSeq.Find("WelcomeScreen");
        IntroSeq.gameObject.SetActive(true);
        RectTransform IntroRectTransform = IntroSeq.GetComponent<RectTransform>();
        IntroRectTransform.anchoredPosition = new Vector2(0f,0f);
    }

    // Update is called once per frame
    void Update()
    {
        time += 1;
        if (time == 15){
            IntroSeq.gameObject.SetActive(false);
        }
    }
}
