using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanGame_Obstacle : MonoBehaviour
{
    int damage = 1;
    public int speed = 5;

    void Update(){
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
            other.GetComponent<CleanGame_Player>().health -= damage;
            Destroy(gameObject);
        }
        else if(other.CompareTag("Delete")){
            Destroy(gameObject);
        }
    }
}
