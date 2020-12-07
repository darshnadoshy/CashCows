using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BankingScript : MonoBehaviour
{
    public GameObject player;
    public Text savings, checkings;
    // Start is called before the first frame update
    void Start()
    {
        savings.text = player.GetComponent<PlayerScript>().GetSavingsMoola().ToString();
        checkings.text = player.GetComponent<PlayerScript>().GetCheckingsMoola().ToString();
    }

    // Update is called once per frame
    void Update()
    {
        savings.text = player.GetComponent<PlayerScript>().GetSavingsMoola().ToString();
        checkings.text = player.GetComponent<PlayerScript>().GetCheckingsMoola().ToString();
    }
}
