using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Credit to help from N3K EN youtube channel

public class Swipe : MonoBehaviour
{
    private bool tap, swipeLeft, swipeRight, swipeDown, swipeUp;
    private Vector2 startTouch, swipeDelta;
    private bool isDragging = false;

    // Update is called once per frame
    void Update()
    {
        tap = swipeLeft = swipeRight = swipeDown = swipeUp = false;

        #region Mobile Inputs
        if(Input.touches.Length > 0){
            if(Input.touches[0].phase == TouchPhase.Began){
                tap = true;
                isDragging = true;
                startTouch = Input.touches[0].position;
            } else if(Input.touches[0].phase == TouchPhase.Ended || Input.touches[0].phase == TouchPhase.Canceled){
                isDragging = false;
                Reset();
            }
        }
        #endregion

        //calculate dragging distance
        swipeDelta = Vector2.zero;
        if(isDragging){
            swipeDelta = Input.touches[0].position - startTouch;
        } 
        
        //crossed dead zone
        if(swipeDelta.magnitude > 40){
            float x = swipeDelta.x;
            float y = swipeDelta.y;
            if(Mathf.Abs(x) > Mathf.Abs(y)){
                //left or right
                if(x < 0){
                    swipeLeft = true;
                } else {
                    swipeRight = true;
                }
            } else {
                //up or down
                if(y < 0){
                    swipeDown = true;
                } else {
                    swipeUp = true;
                }
            }

            Reset();
        }
    }

    void Reset(){
        startTouch = swipeDelta = Vector2.zero;
        isDragging = false;
    }

    public Vector2 SwipeDelta{ get {return swipeDelta; }}
    public bool SwipeLeft{ get {return swipeLeft; }}
    public bool SwipeRight{ get {return swipeRight; }}
    public bool SwipeDown{ get {return swipeDown; }}
    public bool SwipeUp{ get {return swipeUp; }}
}

