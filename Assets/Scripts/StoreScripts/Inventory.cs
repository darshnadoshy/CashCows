using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    //Text variables
    public Text numberOfCorn;
    public Text numberOfApples;
    public Text numberOfCows;
    public Text numberOfHay;
    public Text numberOfMilk;
    public Text numberOfVeg;
    public Text numberOfTools;
    public Text numberOfSeeds;

    //Count variables
    public static int SeedCount;
    public static int ToolsCount;
    public static int VegCount;
    public static int MilkCount;
    public static int HayCount;
    public static int CowsCount;
    public static int ApplesCount;
    public static int CornCount;

    // Prices for Quick Reference //
    // SeedPrice = 20;
    // ToolsPrice = 100;
    // VegPrice = 50;
    // MilkPrice = 60;
    // HayPrice = 30;
    // CowsPrice = 200;
    // ApplesPrice = 50;
    // CornPrice = 60;

    //other variables
    public static int InventoryCount;

    //Player
    public PlayerScript player;

    public static void AddItemInventory(string item){
        if(item.Equals("corn")){
            CornCount++;
        } else if(item.Equals("apple")){
            ApplesCount++;
        } else if(item.Equals("hay")){
            HayCount++;
        } else if(item.Equals("milk")){
            MilkCount++;
        } else if(item.Equals("tool")){
            ToolsCount++;
        } else if(item.Equals("seed")){
            SeedCount++;
        } else if(item.Equals("cow")){
            CowsCount++;
        } else if(item.Equals("veg")){
            VegCount++;
        } else {
            //do nothing
            return;
        }
        InventoryCount++;
    }
    public static int SubtractItemInventory(string item){
        if(item.Equals("corn") && CornCount >= 1){
            CornCount--;
        } else if(item.Equals("apple") && ApplesCount >= 1){
            ApplesCount--;
        } else if(item.Equals("hay") && HayCount >= 1){
            HayCount--;
        } else if(item.Equals("milk") && MilkCount >= 1){
            MilkCount--;
        } else if(item.Equals("tool") && ToolsCount >= 1){
            ToolsCount--;
        } else if(item.Equals("seed") && SeedCount >= 1){
            SeedCount--;
        } else if(item.Equals("cow") && CowsCount >= 1){
            CowsCount--;
        } else if(item.Equals("veg") && VegCount >= 1){
            VegCount--;
        } else {
            return 0; //false
        }
        InventoryCount--;
        return 1; //true
    }

    void Update(){
        numberOfCorn.text = "" + CornCount.ToString();
        numberOfApples.text = "" + ApplesCount.ToString();
        numberOfHay.text = "" + HayCount.ToString();
        numberOfMilk.text = "" + MilkCount.ToString();
        numberOfTools.text = "" + ToolsCount.ToString();
        numberOfSeeds.text = "" + SeedCount.ToString();
        numberOfCows.text = "" + CowsCount.ToString();
        numberOfVeg.text = "" + VegCount.ToString();
    }
}
