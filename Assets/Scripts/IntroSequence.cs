using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroSequence : MonoBehaviour
{
    private Transform WelcomeScreen;
    private Transform Introduction;
    private Transform WelcomeTextIntroduction;
    private Transform MoolaTextIntroduction1;
    private Transform MoolaTextIntroduction2;
    private Transform StoreTextIntroduction1;
    private Transform CodexTextIntroduction1;
    private Transform PastureTextIntroduction1;
    private Transform ExploreTextIntroduction;
    private static int time = 0;

    // Start is called before the first frame update
    void Start()
    {
        WelcomeScreen = transform.Find("Welcome");
        Introduction = transform.Find("Introduction");
        WelcomeTextIntroduction = Introduction.Find("WelcomeText");
        MoolaTextIntroduction1 = Introduction.Find("MoolaText1");
        MoolaTextIntroduction2 = Introduction.Find("MoolaText2");
        StoreTextIntroduction1 = Introduction.Find("StoreText1");
        CodexTextIntroduction1 = Introduction.Find("CodexText1");
        PastureTextIntroduction1 = Introduction.Find("PastureText1");
        ExploreTextIntroduction = Introduction.Find("ExploreText");

        ExploreTextIntroduction.gameObject.SetActive(false);
        PastureTextIntroduction1.gameObject.SetActive(false);
        CodexTextIntroduction1.gameObject.SetActive(false);
        StoreTextIntroduction1.gameObject.SetActive(false);
        MoolaTextIntroduction2.gameObject.SetActive(false);
        MoolaTextIntroduction1.gameObject.SetActive(false);
        WelcomeTextIntroduction.gameObject.SetActive(false);
        Introduction.gameObject.SetActive(false);
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
            Introduction.gameObject.SetActive(true);
            WelcomeTextIntroduction.gameObject.SetActive(true);
        }
        if(time == 30){
            WelcomeTextIntroduction.gameObject.SetActive(false);
            MoolaTextIntroduction1.gameObject.SetActive(true);
        }
        if(time == 50){
            MoolaTextIntroduction1.gameObject.SetActive(false);
            MoolaTextIntroduction2.gameObject.SetActive(true);
        }
        if(time == 75){
            MoolaTextIntroduction2.gameObject.SetActive(false);
            StoreTextIntroduction1.gameObject.SetActive(true);
        }
        if(time == 100){
            StoreTextIntroduction1.gameObject.SetActive(false);
            CodexTextIntroduction1.gameObject.SetActive(true);
        }
        if(time == 125){
            CodexTextIntroduction1.gameObject.SetActive(false);
            PastureTextIntroduction1.gameObject.SetActive(true);
        }
        if(time == 150){
            PastureTextIntroduction1.gameObject.SetActive(false);
            ExploreTextIntroduction.gameObject.SetActive(true);
        }
        if(time == 175){
            ExploreTextIntroduction.gameObject.SetActive(false);
        }
    }
}
