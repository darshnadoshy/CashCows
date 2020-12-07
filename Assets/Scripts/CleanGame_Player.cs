using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Help from the Youtube Channel: Blackthornprod

public class CleanGame_Player : MonoBehaviour
{
    private Vector2 targetPos = new Vector2(0, 1);
    public float YIncrement;

    public float speed;
    public float maxY;
    public float minY;
    
    private float maxPoints = 30;
    public int health = 3;
    public int points = 0;

    void Start(){
        transform.position = new Vector2(0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if(points == maxPoints){
            Debug.Log("YOU WON. TODO");
            SceneManager.LoadScene("MainScene");
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        if(Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y + YIncrement <= maxY){
            targetPos = new Vector2(transform.position.x, transform.position.y + YIncrement);
        } else if(Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y - YIncrement >= minY){
            targetPos = new Vector2(transform.position.x, transform.position.y - YIncrement);
        }
    }
}
