using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cow {
    public Cow(GameObject cowRef){
        CowRef = cowRef;
    }
    public Cow(string name, GameObject cowRef){
        Name = name;
        CowRef = cowRef;
    }
    public string Name;
    public GameObject CowRef;
    public bool milked = false;

    public string getName(){
        return Name;
    }

    public void setName(string name){
        Name = name;
    }

    // async Task ChangeMeAfter()
    // {
    //     await Task.Delay(TimeSpan.FromSeconds(10.0f));
    //     milked = false;
    //     return new Task();
    // }
}

public class PlayerScript : MonoBehaviour
{
    // STATIC Vars
    static public int checkingsMoola = 200;
    static public int savingsMoola = 0;
    static public List<Cow> CowReferences; // TODO switch to Cow object

    //Vars
    public Text PlayerMoola;
    public GameObject CowPreFab;

    // Start is called before the first frame update
    void Start()
    {
        PlayerMoola.text = "" + checkingsMoola;
        CowReferences = new List<Cow>();
        GameObject cowObj = (GameObject)Instantiate(CowPreFab, new Vector3(18.72f, 1.24f, 8.62f), Quaternion.identity);
        CowReferences.Add(new Cow("Betsy", cowObj));
        // DELETE LATER - for testing /////////////////////
        GameObject cowObj2 = (GameObject)Instantiate(CowPreFab, new Vector3(19.72f, 1.24f, 8.62f), Quaternion.identity);
        CowReferences.Add(new Cow("Donna", cowObj2));
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

    public void AddCow(GameObject cow){ // TODO - TEST
        Vector3 RandomSpawn = new Vector3(Random.Range(18f, 20f), 1.24f, Random.Range(7.5f, 9.5f));
        GameObject cowRef = (GameObject)Instantiate(CowPreFab, RandomSpawn, Quaternion.identity);
        CowReferences.Add(new Cow(cowRef));
    }

    public void SubtractCow(GameObject cow){
        //TODO
    }

    public List<Cow> GetListCows(){
        return CowReferences;
    }
}
