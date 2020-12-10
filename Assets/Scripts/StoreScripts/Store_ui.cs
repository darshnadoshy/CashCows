using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Store_ui : MonoBehaviour
{
    public GameObject player;
    public Inventory inventory;

    public int transactionCost = 0;
    public int money = 0;
    public Text moneyText;

    public void AddItem(string item)
    {
        Inventory.AddItemInventory(item);
    }
    
    public void AddTransactionCost (int cost)
    {
        transactionCost += cost;
    }
    public int GetTransactionCost ()
    {
        return transactionCost;
    }

    void Start(){
        money = player.GetComponent<PlayerScript>().GetCheckingsMoola();
    }

    void Update(){
        player.GetComponent<PlayerScript>().SetCheckingsMoola(money);
        moneyText.text = money.ToString();
    }
}
