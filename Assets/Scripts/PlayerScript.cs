using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerScript : MonoBehaviour
{
    // STATIC Vars
    static public int checkingsMoola = 100;
    static public int savingsMoola = 0;
    static public List<CowObject> CowReferences = new List<CowObject>();
    static private int countCows = 1; // TODO DELETE LATER - when names can be used
    static int TEMPFLAG = 0;
    
    //Vars
    public Text PlayerMoola;
    public GameObject CowPreFab;

    // Start is called before the first frame update
    void Start()                            //TODO THIS IS CREATING NEW COWS EVERY TIME PLAYER SCRIPT IS RUN
    {
        if(TEMPFLAG == 0){ // DELETE LATER
            PlayerPrefs.SetInt("Cows", 0);
            TEMPFLAG = 1;
        }
        PlayerMoola.text = "" + checkingsMoola;
        int flag = PlayerPrefs.GetInt("Cows");
        if(flag == 0){
            CowReferences.Add(new CowObject("Betsy"));
            // DELETE LATER - for testing /////////////////////
            CowReferences.Add(new CowObject("Donna"));
            PlayerPrefs.SetInt("Cows", 1);
        }
        for(int i = 0; i < CowReferences.Count; i++){
            Instantiate(CowPreFab, new Vector3(Random.Range(18f, 20f), 1.24f, Random.Range(7.5f, 9.5f)), Quaternion.identity);
        }
    }

    void Update()
    {
        PlayerMoola.text = "" + checkingsMoola;
    }

    public void AddMoola(int moola){
        checkingsMoola += moola;
    }

    public void SubtractMoola(int moola){
        if(checkingsMoola - moola < 0){
            Debug.Log("Not enough money");
        } else {
            checkingsMoola -= moola;
        }
    }

    public int GetCheckingsMoola(){
        return checkingsMoola;
    }

    //TODO test
    public int GetSavingsMoola(){
        return savingsMoola;
    }

    public void SetCheckingsMoola(int amount){
        checkingsMoola = amount;
    }

    //TODO test
    public void SetSavingsMoola(int amount){
        savingsMoola = amount;
    }

    // HAVE TO TEST THIS CODE ONCE STORE IS READY -- TODO
    public void AddCow(GameObject cow){
        Vector3 RandomSpawn = new Vector3(Random.Range(18.5f, 19.5f), 1.24f, Random.Range(8f, 9f));
        GameObject cowRef = (GameObject)Instantiate(CowPreFab, RandomSpawn, Quaternion.identity);
        // HAVE TO TEST THIS CODE ONCE STORE IS READY -- TODO
        countCows += 1;
        string name = "Betsy" + countCows.ToString();
        CowReferences.Add(new CowObject(name));
    }

    public void SubtractCow(string name){
        //CowReferences.DELETE(name);
    }

    public List<CowObject> GetListCows(){
        return CowReferences;
    }

    //Darshna's functions for Transfer Money

    public Text message;

    public void SubtractSavings(int amount)
    {
        //Testing - Remove message after testing
        message.text = savingsMoola.ToString() + amount.ToString();
        savingsMoola -= amount;
    }

    public void SubtractCheckings(int amount)
    {
        checkingsMoola -= amount;
    }

    public void AddSavings(int amount)
    {
        savingsMoola += amount;
    }

    public void AddCheckings(int amount)
    {
        checkingsMoola += amount;
    }
}
