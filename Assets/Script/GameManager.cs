using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public PlayerMovement player;
    private Vector3 playerStartPoint;
    public ScoreManager scoring;
    public DeathMenu mati;
    public AudioScript lagu;
    public AudioClip click2;
   
    public GameObject hansipp;
    public GameObject platform;
    public GameObject spawner;
    public GameObject wall;
    public GameObject Window;
    public GameObject destroyer;
    public GameObject Pan;

    
    public NewBehaviourScript background;
    public ObstaclesMoves obstacleMove;
    public ObstaclesMoves obstacleMove2;
    public ObstaclesMoves obstacleMove3;
    public PanciSpawner panci;
    public int count;
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

   

	public void RestartGame()
    {
        scoring.scoreIncreasing = false;
        player.gameObject.SetActive(false);
        mati.gameObject.SetActive(true);
        lagu.descrease = true;
        hansipp.gameObject.SetActive(false);
        spawner.gameObject.SetActive(false);
        destroyer.transform.position = new Vector3(0f, 0f, 0f);
        background.speed = 0f;
        obstacleMove.gerak = false;
        obstacleMove2.gerak = false;
        obstacleMove3.gerak = false;
    }

    public void Reset()
    {
        count = Random.Range(1, 2000);
        obstacleMove.gerak = true;
        obstacleMove2.gerak = true;
        obstacleMove3.gerak = true;
        obstacleMove.speed = obstacleMove.speedStore;
        obstacleMove2.speed = obstacleMove2.speedStore;
        obstacleMove3.speed = obstacleMove.speedStore;
        player.transform.position = playerStartPoint;
        player.gameObject.SetActive(true);
        scoring.scoreCount = scoring.scoreCountReset;
        scoring.scoreIncreasing = true;
        mati.gameObject.SetActive(false);
        lagu.descrease = false;
        spawner.gameObject.SetActive(true);
        hansipp.gameObject.SetActive(true);
        background.speed = 0.5f;
        destroyer.transform.position = new Vector3(-22f, 0f, 0f);
        
    }
}
