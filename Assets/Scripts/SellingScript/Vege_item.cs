using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Vege_item : MonoBehaviour
{
    public int item_number_vege;
    public string itemName;

    public void Vege_sell()
    {
        Debug.Log("money: " + GetComponentInParent<Sell_ui>().money.ToString());
        GetComponentInParent<Sell_ui>().money = GetComponentInParent<Sell_ui>().money +=  60;
        GetComponentInParent<Sell_ui>().item_number_vege = GetComponentInParent<Sell_ui>().item_number_vege -= 1;
        GetComponentInParent<Sell_ui>().addItem(itemName);

    }
}
