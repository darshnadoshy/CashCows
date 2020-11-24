using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Time : MonoBehaviour
{
    private int playTime = 21600;
    private int seconds = 0;
    private int minutes = 0;
    private int hours = 0;
    private int days = 0;

    //Text
    public Text timeDisplay;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PlayTimer());
    }

    private IEnumerator PlayTimer(){
        while(true){
            yield return new WaitForSeconds(1);
            playTime += 1;
            seconds = playTime % 60;
            minutes = (playTime / 60) % 60;
            hours = (playTime / 3600) % 24;
            days = (playTime / 86400) % 365;
        }
    }

    void Update(){
        if(minutes < 10){
            timeDisplay.text = "Time: " + hours.ToString() + ":0" + minutes.ToString();
        } else {
            timeDisplay.text = "Time: " + hours.ToString() + ":" + minutes.ToString();
        }
    }
}
