using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanGame_SpawnPoint : MonoBehaviour
{
    public GameObject obstacle;

    void Start(){
        Instantiate(obstacle, transform.position, Quaternion.identity);
    }
}
