using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatementsScript : MonoBehaviour
{
    public GameObject player;
    public Text message;

    public void HandleInputData(int value)
    {
        if (value == 1)
        {
            message.text = "Date\t\t\tDescription\t\tAmount\n\n\n" + "Dec 10\t\tTransfer\t\t\t+50" + 
                            "\n\n\n\t\t\t\tTotal = 50";
        }

        if (value == 2)
        {
            message.text = "Date\t\t\tDescription\t\tAmount\n\n\n" + "Dec 10\t\tTransfer\t\t\t-50\n\n" +
                            "Dec 10\t\tStore\t\t\t\t+90\n\n" + "Dec 10\t\tStore\t\t\t\t-190" + 
                            "\n\n\t\t\t\tTotal = 150";
        }
    }
}
