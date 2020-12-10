using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Achievements : MonoBehaviour
{
    //General Variables // https://www.youtube.com/watch?v=-XuzwxkZ2Wk 
    public GameObject achNote;
    public bool achActive = false;
    public GameObject achTitle;
    public GameObject achDesc;
    public GameObject achImage;

    //Achievement Specific
    //A01
    public static int act01Count = 0;
    public int ach01Trigger = 1;
    public int ach01Code = 0;

    //A02
    public static int act02Count = 0;
    public int ach02Trigger = 1;
    public int ach02Code = 0;

    void Start(){
        achNote.SetActive(false);
        achImage.SetActive(false);
        achTitle.SetActive(false);
        achDesc.SetActive(false);
        achActive = false;
        PlayerPrefs.SetInt("Ach01", 0);
        PlayerPrefs.SetInt("Ach02", 0);
    }

    // Update is called once per frame
    void Update()
    {
        ach01Code = PlayerPrefs.GetInt("Ach01");
        if(act01Count == ach01Trigger && ach01Code != 1){
            StartCoroutine(TriggerAch01());
        }

        ach02Code = PlayerPrefs.GetInt("Ach02");
        if(act02Count == ach02Trigger && ach02Code != 1){
            StartCoroutine(TriggerAch02());
        }
    }

    // ACHIEVEMENT 1 — Milking First Cow
    IEnumerator TriggerAch01(){
        achActive = true;
        ach01Code = 1;
        PlayerPrefs.SetInt("Ach01", ach01Code);
        achImage.SetActive(true);
        achTitle.SetActive(true);
        achDesc.SetActive(true);
        achTitle.GetComponent<Text>().text = "ACHIEVEMENT: Sold Milk";
        achDesc.GetComponent<Text>().text = "Congrats! You have sold your first milk.";
        achNote.SetActive(true);
        yield return new WaitForSeconds(7);
        //Reset script
        achNote.SetActive(false);
        achImage.SetActive(false);
        achTitle.GetComponent<Text>().text = "";
        achDesc.GetComponent<Text>().text = "";
        achActive = false;
    }

    // ACHIEVEMENT 2 — 500 Moola
    IEnumerator TriggerAch02(){
        achActive = true;
        ach02Code = 1;
        PlayerPrefs.SetInt("Ach02", ach02Code);
        achImage.SetActive(true);
        achTitle.SetActive(true);
        achDesc.SetActive(true);
        achTitle.GetComponent<Text>().text = "ACHIEVEMENT: Moola";
        achDesc.GetComponent<Text>().text = "Congrats! You have reached 500 Moola.";
        achNote.SetActive(true);
        yield return new WaitForSeconds(7);
        //Reset script
        achNote.SetActive(false);
        achImage.SetActive(false);
        achTitle.GetComponent<Text>().text = "";
        achDesc.GetComponent<Text>().text = "";
        achActive = false;
    }

    public void increaseCount(string ach){
        if(ach.Equals("A01")){
            act01Count += 1;
        }
        if(ach.Equals("A02")){
            act02Count += 1;
        }
    }
}
