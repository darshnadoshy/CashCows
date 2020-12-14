using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransferMoneyScript : MonoBehaviour
{
    public GameObject player;
    public Text balance1, balance2, message;
    public int value1, value2;
        
    public void HandleInputData1(int val1)
    {
        value1 = val1;
        if (val1 == 1)
        {
            balance1.text = "Balance: " + player.GetComponent<PlayerScript>().GetSavingsMoola().ToString();
        }
        if (val1 == 2)
        {
            balance1.text = "Balance: " + player.GetComponent<PlayerScript>().GetCheckingsMoola().ToString();
        }
    }

    public void HandleInputData2(int val2)
    {
        value2 = val2;
        if (val2 == 1)
        {
            balance2.text = "Balance: " + player.GetComponent<PlayerScript>().GetCheckingsMoola().ToString();
        }
        if (val2 == 2)
        {
            balance2.text = "Balance: " + player.GetComponent<PlayerScript>().GetSavingsMoola().ToString();
        }
    }

    public void ResetValue()
    {
        message.text = "";
    }

    public void DoneMsg()
    {
        message.text = "Transfer Successful!";
        HandleInputData1(value1);
        HandleInputData2(value2);
    }

    public void Text_Changed(string newText)
    {
        int amount = int.Parse(newText);
        int savings, checkings;
        savings = player.GetComponent<PlayerScript>().GetSavingsMoola();
        checkings = player.GetComponent<PlayerScript>().GetCheckingsMoola();

        //Transfer from Savings to Checkings Account
        if (value1 == 1 && value2 == 1)  
        {
            if (amount != 0)
            {
                if (amount <= savings)
                {
                    //subtract from savings
                    player.GetComponent<PlayerScript>().SubtractSavings(amount);
                    player.GetComponent<PlayerScript>().AddSavingTransactions("Transfer", amount, "-");
                    //add to checkings
                    player.GetComponent<PlayerScript>().AddCheckings(amount);
                    player.GetComponent<PlayerScript>().AddCheckingTransactions("Transfer", amount, "+");
                }
                else 
                {
                    //TODO: change to pop up
                    message.text = "Insufficient Funds!";
                }
            }
            else
            {
                //TODO: change to pop up
                message.text = "Amount can't be 0!";
            }
        }

        //Transfer from Checkings to Savings Account
        if (value1 == 2 && value2 == 2)
        {
            if (amount != 0)
            {
                if (amount <= checkings)
                {
                    //subtract from checkings
                    player.GetComponent<PlayerScript>().SubtractCheckings(amount);
                    player.GetComponent<PlayerScript>().AddCheckingTransactions("Transfer", amount, "-");
                    //add to savings
                    player.GetComponent<PlayerScript>().AddSavings(amount);
                    player.GetComponent<PlayerScript>().AddSavingTransactions("Transfer", amount, "+");
                }
                else
                {
                    //TODO: change to pop up
                    message.text = "Insufficient Funds!";
                }
            }
            else
            {
                //TODO: change to pop up
                message.text = "Amount can't be 0!";
            }
        }

        //Invalid Input
        if ((value1 == 1 && value2 == 2) || (value1 == 2 && value2 == 1))
        {
            message.text = "Can not transfer to same account!";
        }
    }
}
