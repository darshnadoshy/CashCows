using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Items : MonoBehaviour
{
    public int cost;
    public string itemName;
    public Inventory inventory;

    public void bought()
    {
        if (GetComponentInParent<Store_ui>().money >= cost)
        {
            GetComponentInParent<Store_ui>().money = GetComponentInParent<Store_ui>().money -= cost;
            GetComponentInParent<Store_ui>().AddItem(itemName);
            GetComponentInParent<Store_ui>().AddTransactionCost(cost);
        } else {
            Debug.Log("Not enough money");
        }
    }
    public void sold(){
        int CanSell = Inventory.SubtractItemInventory(itemName);
        if(CanSell == 1){ // if true
            GetComponentInParent<Store_ui>().money = GetComponentInParent<Store_ui>().money += cost;
            GetComponentInParent<Store_ui>().AddTransactionCost(cost);
        } else {
            Debug.Log("Cannot sell at this time.");
        }
    }
}
