using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatementsScript : MonoBehaviour
{
    public PlayerScript player;
    public Text message;

    public void HandleInputData(int value)
    {
        if (value == 1) //pull from income & expenses (savings)
        {
            message.text = "Date\t\t\tDescription\t\tAmount\n\n";
            for(int i = 0; i < PlayerScript.SavingTransactions.Count; i++){
                if(PlayerScript.SavingTransactions[i].cost == 0){
                    continue;
                }
                message.text = message.text + System.DateTime.Now.ToString("MMM ") + System.DateTime.Now.Month + "\t\t" + 
                PlayerScript.SavingTransactions[i].Item1 + "\t\t\t" + 
                PlayerScript.SavingTransactions[i].Item3 + 
                PlayerScript.SavingTransactions[i].Item2 + "\n";
            }
        }

        if (value == 2) //pull from income & expenses (checkings)
        {
            message.text = "Date\t\t\tDescription\t\tAmount\n\n";

            for(int i = 0; i < PlayerScript.CheckingTransactions.Count; i++){
                if(PlayerScript.CheckingTransactions[i].cost == 0){
                    continue;
                }
                message.text = message.text + System.DateTime.Now.ToString("MMM ") + System.DateTime.Now.Month + "\t\t" + 
                PlayerScript.CheckingTransactions[i].Item1 + "\t\t\t" + 
                PlayerScript.CheckingTransactions[i].Item3 + 
                PlayerScript.CheckingTransactions[i].Item2 + "\n";
            }
        }
    }
}
