using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Store_ui : MonoBehaviour
{
    public Text inventory;

    public int money = 1000;
    public Text moneyText;

    public int num_cows = 0;
    public Text cowText;

    public void addItem(string item)
    {
        moneyText.text = money.ToString();
        cowText.text = num_cows.ToString();

        inventory.text += "\n" + item;
    }
}
