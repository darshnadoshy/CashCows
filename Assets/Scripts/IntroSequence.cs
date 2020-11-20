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
    private Transform MoolaArrow;
    private Transform StoreTextIntroduction1;
    private Transform StoreArrow;
    private Transform CodexTextIntroduction1;
    private Transform CodexArrow;
    private Transform PastureTextIntroduction1;
    private Transform PastureArrow;
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
        MoolaArrow = Introduction.Find("MoolaArrow");
        StoreArrow = Introduction.Find("StoreArrow");
        CodexArrow = Introduction.Find("CodexArrow");
        PastureArrow = Introduction.Find("PastureArrow");

        PastureArrow.gameObject.SetActive(false);
        CodexArrow.gameObject.SetActive(false);
        StoreArrow.gameObject.SetActive(false);
        MoolaArrow.gameObject.SetActive(false);
        ExploreTextIntroduction.gameObject.SetActive(false);
        PastureTextIntroduction1.gameObject.SetActive(false);
        CodexTextIntroduction1.gameObject.SetActive(false);
        StoreTextIntroduction1.gameObject.SetActive(false);
        MoolaTextIntroduction2.gameObject.SetActive(false);
        MoolaTextIntroduction1.gameObject.SetActive(false);
        WelcomeTextIntroduction.gameObject.SetActive(false);
        Introduction.gameObject.SetActive(false);
        WelcomeScreen.gameObject.SetActive(false);
        
        RectTransform WelcomeRectTransform = WelcomeScreen.GetComponent<RectTransform>();
        WelcomeRectTransform.anchoredPosition = new Vector2(0f,0f);
    }

    //Notes//
    // TO show stuff on other screens (bank, store, codex), can take a screenshot of that and turn it
    // into an image. Use image to point stuff out to user for introduction sequence.

    // Update is called once per frame
    void Update()
    {
        time += 1;
        int flag = PlayerPrefs.GetInt("IntroFlag");

        if(flag == 0){
            if(time < 20){
                WelcomeScreen.gameObject.SetActive(true);
            }
            if (time == 20){
                WelcomeScreen.gameObject.SetActive(false);
                Introduction.gameObject.SetActive(true);
                WelcomeTextIntroduction.gameObject.SetActive(true);
            }
            if(time == 10){
                WelcomeTextIntroduction.gameObject.SetActive(false);
                MoolaTextIntroduction1.gameObject.SetActive(true);
                MoolaArrow.gameObject.SetActive(true);
            }
            if(time == 20){
                MoolaTextIntroduction1.gameObject.SetActive(false);
                MoolaTextIntroduction2.gameObject.SetActive(true);
            }
            if(time == 30){
                MoolaTextIntroduction2.gameObject.SetActive(false);
                MoolaArrow.gameObject.SetActive(false);
                StoreTextIntroduction1.gameObject.SetActive(true);
                StoreArrow.gameObject.SetActive(true);
            }
            if(time == 40){
                StoreTextIntroduction1.gameObject.SetActive(false);
                StoreArrow.gameObject.SetActive(false);
                CodexTextIntroduction1.gameObject.SetActive(true);
                CodexArrow.gameObject.SetActive(true);
            }
            if(time == 50){
                CodexTextIntroduction1.gameObject.SetActive(false);
                CodexArrow.gameObject.SetActive(false);
                PastureTextIntroduction1.gameObject.SetActive(true);
                PastureArrow.gameObject.SetActive(true);
            }
            if(time == 60){
                PastureTextIntroduction1.gameObject.SetActive(false);
                PastureArrow.gameObject.SetActive(false);
                ExploreTextIntroduction.gameObject.SetActive(true);
            }
            if(time == 70){
                ExploreTextIntroduction.gameObject.SetActive(false);
                Introduction.gameObject.SetActive(false);
                PlayerPrefs.SetInt("IntroFlag", 1);
            }
        }
    }
}
