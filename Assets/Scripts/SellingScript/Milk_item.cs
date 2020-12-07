using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Milk_item : MonoBehaviour
{
    public int item_number_milk;
    public string itemName;

    public void Milk_sell()
    {
        Debug.Log("money: " + GetComponentInParent<Sell_ui>().money.ToString());
        GetComponentInParent<Sell_ui>().money = GetComponentInParent<Sell_ui>().money +=  60;
        GetComponentInParent<Sell_ui>().item_number_milk = GetComponentInParent<Sell_ui>().item_number_milk -= 1;
        GetComponentInParent<Sell_ui>().addItem(itemName);


}
}



