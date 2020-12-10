using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanGame_SpawnPointPOOP : MonoBehaviour
{
    public GameObject poop;

    void Start(){
        Instantiate(poop, transform.position, Quaternion.identity);
    }
}
