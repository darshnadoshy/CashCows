using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanGame_Poop : MonoBehaviour
{
    int point = 1;
    public int speed;

    void Update(){
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
            other.GetComponent<CleanGame_Player>().points += point;
            Destroy(gameObject);
        } else if(other.CompareTag("Delete")){
            Destroy(gameObject);
        }
    }
}
