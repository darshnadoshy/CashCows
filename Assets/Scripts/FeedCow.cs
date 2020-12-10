using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeedCow : MonoBehaviour
{
    public Slider slider;

    public void SetMaxFeed(int milk){
        slider.maxValue = milk;
    }

    public void SetFeed(int milk){
        slider.value = milk;
    }
}
