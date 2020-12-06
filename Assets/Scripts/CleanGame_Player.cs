using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Help from the Youtube Channel: Blackthornprod

public class CleanGame_Player : MonoBehaviour
{
    private Vector2 targetPos = new Vector2(-1, 1);
    public float YIncrement;

    public float speed;
    //public float maxY;
    //public float minY;

    public int health = 3;

    void Start(){
        transform.position = new Vector2(-1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed); //* Time.deltaTime);
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            targetPos = new Vector2(transform.position.x, transform.position.y + YIncrement);
        } else if(Input.GetKeyDown(KeyCode.DownArrow)){
            targetPos = new Vector2(transform.position.x, transform.position.y - YIncrement);
        }
    }
}
