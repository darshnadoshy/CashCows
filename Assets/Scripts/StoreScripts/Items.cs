using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Items : MonoBehaviour
{
    public int cost;
    public string itemName;

    public void bought()
    {
        if (GetComponentInParent<Store_ui>().money >= cost)
        {
            GetComponentInParent<Store_ui>().money = GetComponentInParent<Store_ui>().money -= cost;
            GetComponentInParent<Store_ui>().addItem(itemName);
        }
    }
}
