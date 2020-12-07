using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Sell_ui : MonoBehaviour
{
    public Text inventory;
    public GameObject player;

    public int money = 0;
    public Text moneyText;

    public int num_cows = 0;
    public Text cowText;


    public int item_number_vege = 5;
    public Text item_number_vegeText;

    public int item_number_milk = 10;
    public Text item_number_milkText;


    public void addItem(string item)
    {
        moneyText.text = money.ToString();
        cowText.text = num_cows.ToString();
        item_number_milkText.text = item_number_milk.ToString();
        item_number_vegeText.text = item_number_vege.ToString();

        inventory.text += "\n" + item;
    }


    void Start()
    {
        money = player.GetComponent<PlayerScript>().GetCheckingsMoola();
    }

    void Update()
    {
        player.GetComponent<PlayerScript>().SetCheckingsMoola(money);
    }
}