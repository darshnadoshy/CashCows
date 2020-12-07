using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanGame_Obstacle : MonoBehaviour
{
    int damage = 1;
    public int speed;

    void Update(){
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other){
        Debug.Log("Triggered");
        if(other.CompareTag("Player")){
            other.GetComponent<CleanGame_Player>().health -= damage;
            Debug.Log("damage: " + other.GetComponent<CleanGame_Player>().health.ToString());
            Destroy(gameObject);
        }
    }
}
