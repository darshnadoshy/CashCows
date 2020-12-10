using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transactions : MonoBehaviour
{
    public PlayerScript player;
    public GameObject store;

    public void onClickToSell(){
        PlayerScript.Expenses.Add(store.GetComponent<Store_ui>().GetTransactionCost());
        SceneManager.LoadScene("sell");
    }
    public void onClickToBuy(){
        PlayerScript.Income.Add(store.GetComponent<Store_ui>().GetTransactionCost());
        SceneManager.LoadScene("store");
    }
    public void onClickHome(){
        PlayerScript.Expenses.Add(store.GetComponent<Store_ui>().GetTransactionCost());
        SceneManager.LoadScene("MainScene");
    }
}
