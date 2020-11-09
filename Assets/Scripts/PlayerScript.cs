using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    // STATIC Vars
    static public int totalMoola = 200;
    static public List<GameObject> CowReferences;

    //Vars
    public Text PlayerMoola;
    public GameObject CowPreFab;

    // Start is called before the first frame update
    void Start()
    {
        PlayerMoola.text = "" + totalMoola;
        CowReferences = new List<GameObject>();
        CowReferences.Add((GameObject)Instantiate(CowPreFab, new Vector3(18.72f, 1.24f, 8.62f), Quaternion.identity));
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoola.text = "" + totalMoola;
    }

    public void AddMoola(int moola){
        totalMoola += moola;
    }

    public void SubtractMoola(int moola){
        if(totalMoola - moola < 0){
            Debug.Log("Not enough money");
        } else {
            totalMoola -= moola;
        }
    }

    public void AddCow(GameObject cow){ // TODO - TEST
        Vector3 RandomSpawn = new Vector3(Random.Range(18f, 20f), 1.24f, Random.Range(7.5f, 9.5f));
        CowReferences.Add((GameObject)Instantiate(CowPreFab, RandomSpawn, Quaternion.identity));
    }

    public void SubtractCow(GameObject cow){
        //TODO
    }
}
