using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Help from the Youtube Channel: Blackthornprod

public class CleanGame_Player : MonoBehaviour
{
    private Transform wonScreen;
    private Transform lostScreen;
    private Transform Canvas;
    private Transform Container;
    private Transform TimerImage;
    private Transform StatsScreen;

    public Text Timer;
    public Text Health;
    public Text Points;

    private Vector2 targetPos = new Vector2(0, 1);
    public float YIncrement = 4f;
    //public GameObject player;
    public Swipe swipeControls;

    public float speed = 12;
    public float maxY = 5;
    public float minY = -3;
    float stoppedTime;
    
    private float maxPoints = 20;
    public int health = 3;
    public int points = 0;
    int stop_flag = 0;

    private float timeElapsed;

    void Start(){
        transform.position = new Vector2(0, 1);
        Canvas = transform.Find("Canvas");
        Container = Canvas.Find("BackgroundContainer");
        wonScreen = Container.Find("WinnerBackground");
        lostScreen = Container.Find("LoserBackground");
        TimerImage = Canvas.Find("TimerImage");
        StatsScreen = Canvas.Find("StatsScreen");

        StatsScreen.gameObject.SetActive(true);
        TimerImage.gameObject.SetActive(true);
        wonScreen.gameObject.SetActive(false);
        lostScreen.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Health.text = "" + health.ToString();
        Points.text = "" + points.ToString();

        timeElapsed += Time.deltaTime;
        Timer.text = "" + Mathf.RoundToInt(timeElapsed);

        if(points >= maxPoints){
            if(stop_flag == 0)
            {
                stoppedTime = timeElapsed + 5f;
                //player.GetComponent<PlayerScript>().AddMoola(20);
                stop_flag = 1;
            }
            TimerImage.gameObject.SetActive(false);
            StatsScreen.gameObject.SetActive(false);
            wonScreen.gameObject.SetActive(true); 


            if(stoppedTime <= timeElapsed){
                SceneManager.LoadScene("MainScene");
            }
        } else if(health == 0 || timeElapsed > 60){
            timeElapsed = -1000f;
            TimerImage.gameObject.SetActive(false);
            StatsScreen.gameObject.SetActive(false);
            lostScreen.gameObject.SetActive(true);
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        if((Input.GetKeyDown(KeyCode.UpArrow) || swipeControls.SwipeUp) && transform.position.y + YIncrement <= maxY){
            targetPos = new Vector2(transform.position.x, transform.position.y + YIncrement);
        } else if((Input.GetKeyDown(KeyCode.DownArrow) || swipeControls.SwipeDown) && transform.position.y - YIncrement >= minY){
            targetPos = new Vector2(transform.position.x, transform.position.y - YIncrement);
        }
    }
}
