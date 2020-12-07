using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Cow_item : MonoBehaviour
{
    public int cost;
    public string itemName;

    public void bought()
    {
        Debug.Log("money: " + GetComponentInParent<Store_ui>().money.ToString());
        if (GetComponentInParent<Store_ui>().money >= cost)
        {
            Debug.Log("hit");
            GetComponentInParent<Store_ui>().money = GetComponentInParent<Store_ui>().money -= cost;
            GetComponentInParent<Store_ui>().addItem(itemName);
            GetComponentInParent<Store_ui>().num_cows = GetComponentInParent<Store_ui>().num_cows += 1;
        }
    }
}
