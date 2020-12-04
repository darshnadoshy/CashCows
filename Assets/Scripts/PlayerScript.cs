using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerScript : MonoBehaviour
{
    // STATIC Vars
    static public int checkingsMoola = 100;
    static public int savingsMoola = 0;
    static public List<CowObject> CowReferences; // THIS NEEDS TO BE A PLAYER PREF
    static private int countCows = 1; // TODO DELETE LATER - when names can be used

    //Vars
    public Text PlayerMoola;
    public GameObject CowPreFab;

    // Start is called before the first frame update
    void Start() //TODO THIS IS CREATING NEW COWS EVERY TIME PLAYER SCRIPT IS RUN
    {
        PlayerMoola.text = "" + checkingsMoola;
        CowReferences = new List<CowObject>();
        GameObject cowObj = (GameObject)Instantiate(CowPreFab, new Vector3(18.72f, 1.24f, 8.62f), Quaternion.identity);
        CowReferences.Add(new CowObject("Betsy", cowObj));
        // DELETE LATER - for testing /////////////////////
        GameObject cowObj2 = (GameObject)Instantiate(CowPreFab, new Vector3(19.72f, 1.24f, 8.62f), Quaternion.identity);
        CowReferences.Add(new CowObject("Donna", cowObj2));
    }

    // Update is called once per frame
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

    // HAVE TO TEST THIS CODE ONCE STORE IS READY -- TODO
    public void AddCow(GameObject cow){
        Vector3 RandomSpawn = new Vector3(Random.Range(18f, 20f), 1.24f, Random.Range(7.5f, 9.5f));
        GameObject cowRef = (GameObject)Instantiate(CowPreFab, RandomSpawn, Quaternion.identity);
        CowReferences.Add(new CowObject(cowRef));
        // HAVE TO TEST THIS CODE ONCE STORE IS READY -- TODO
        countCows += 1;
        string name = "Betsy" + countCows.ToString();
        PlayerPrefs.SetString(name, "false");
    }

    public void SubtractCow(GameObject cow){
        //TODO
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
