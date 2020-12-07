using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MilkCowScript : MonoBehaviour
{

    public Slider slider;

    public void SetMaxMilk(int milk){
        slider.maxValue = milk;
    }

    public void SetMilk(int milk){
        slider.value = milk;
    }
}
