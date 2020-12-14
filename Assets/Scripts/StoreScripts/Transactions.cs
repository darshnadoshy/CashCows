using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transactions : MonoBehaviour
{
    public PlayerScript player;
    public GameObject store;

    public void onClickToSell(){
        PlayerScript.CheckingTransactions.Add(("Store\t", store.GetComponent<Store_ui>().GetTransactionCost(), "-"));
        SceneManager.LoadScene("sell");
    }
    public void onClickToBuy(){
        PlayerScript.CheckingTransactions.Add(("Store\t", store.GetComponent<Store_ui>().GetTransactionCost(), "+"));
        SceneManager.LoadScene("store");
    }
    public void onClickHome(){
        PlayerScript.CheckingTransactions.Add(("Store\t", store.GetComponent<Store_ui>().GetTransactionCost(), "-"));
        SceneManager.LoadScene("MainScene");
    }
}
