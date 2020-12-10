using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanGame_Spawner : MonoBehaviour
{
    public GameObject[] obstaclePatterns;

    private float timeBtwnSpawn;
    public float startTimeBtwnSpawn = 1.75f;
    public float decreaseTime = 0;
    public float minTime = 0.75f;

    // Update is called once per frame
    void Update()
    {
        if(timeBtwnSpawn <= 0){
            int rand = Random.Range(0, obstaclePatterns.Length);
            Instantiate(obstaclePatterns[rand], transform.position, Quaternion.identity);
            timeBtwnSpawn = startTimeBtwnSpawn;
            if(startTimeBtwnSpawn >= minTime){
                startTimeBtwnSpawn -= decreaseTime;
            }
        } else {
            timeBtwnSpawn -= Time.deltaTime;
        }
    }
}
