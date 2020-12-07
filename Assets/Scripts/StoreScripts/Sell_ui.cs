using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Sell_ui : MonoBehaviour
{

    public int money = 1000;
    public Text moneyText;


    public void addItem(string item)
    {
        moneyText.text = money.ToString();

    }
}