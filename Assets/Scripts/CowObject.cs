using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CowObject
{
    public CowObject(GameObject cowRef){
        CowRef = cowRef;
    }
    public CowObject(string name, GameObject cowRef){
        Name = name;
        CowRef = cowRef;
    }
    private string Name;
    private GameObject CowRef;
    private bool milked = false;

    // GET SET NAME
    public string getName(){
        return Name;
    }

    public void setName(string name){
        Name = name;
    }

    // GET SET MILK BOOLEAN
    public bool GetMilkedStatus(){
        return milked;
    }

    public void SetMilkedStatus(bool status){
        milked = status;
    }
}
