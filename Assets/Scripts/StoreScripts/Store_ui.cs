using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Store_ui : MonoBehaviour
{
    public Text inventory;
    public GameObject player;

    public int money = 0;
    public Text moneyText;

    public int num_cows = 0;
    public Text cowText;

    public void addItem(string item)
    {
        moneyText.text = money.ToString();
        cowText.text = num_cows.ToString();

        inventory.text += "\n" + item;
    }

    void Start(){
        money = player.GetComponent<PlayerScript>().GetCheckingsMoola();
    }

    void Update(){
        player.GetComponent<PlayerScript>().SetCheckingsMoola(money);
    }
}
