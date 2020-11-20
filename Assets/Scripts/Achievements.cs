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

    //Achievement Specific
    public GameObject ach01Image;
    public static int act01Count = 0;
    public int ach01Trigger = 1;
    public int ach01Code;

    // Update is called once per frame
    void Update()
    {
        ach01Code = PlayerPrefs.GetInt("Ach01");
        if(ach01Code == ach01Trigger & ach01Code != 1){
            StartCoroutine(TriggerAch01());
        }
    }

    IEnumerator TriggerAch01(){
        achActive = true;
        ach01Code = 1;
        PlayerPrefs.SetInt("Ach01", ach01Code);
        ach01Image.SetActive(true);
        achTitle.GetComponent<Text>().text = "FIRST ACHIEVEMENT";
        achDesc.GetComponent<Text>().text = "HERE'S THE TEXT";
        achNote.SetActive(true);
        yield return new WaitForSeconds(7);
        //Reset script
        achNote.SetActive(false);
        ach01Image.SetActive(false);
        achTitle.GetComponent<Text>().text = "";
        achDesc.GetComponent<Text>().text = "";
        achActive = false;
    }
}
