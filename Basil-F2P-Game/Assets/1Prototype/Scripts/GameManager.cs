using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float x_time = 60; // Invoke repeating every x time
    public GameObject[] _character;
    public GameObject CubeSpawner;
    

    public bool ScoreTimer = false;
    public float ScoreMultiplier = 1f;
    public float ScoreMultiplierIncrease = 0.1f;
    public float MultiplierLimit = 3f;

    public float Score;

    float FinalScore;

    int ExpGained;

    public int character;

    private void Awake() 
    {
        
    }
    
    // Start is called before the first frame update
    void Start()
    {
        //_character[0].GetComponent<characterClimbingController>();
        //_character[1].GetComponent<characterClimbingController>();
        //_character[2].GetComponent<characterClimbingController>();
        _character[character].GetComponent<characterClimbingController>();
        CubeSpawner.GetComponent<CubeSpawner>();
        

        InvokeRepeating("PlayerSpeed", 0.0f, x_time);
        InvokeRepeating("CubeSpawnRate", 0.0f, x_time);
        InvokeRepeating("ScoreMultiplierRate", 0.0f, x_time);
        ScoreTimer = true;

        
        
    }


    void FixedUpdate()
    {
        /*
        if(_character[0].GetComponent<characterClimbingController>().DeathOccured) 
        {
            CalculateScore();
        }
        if(_character[1].GetComponent<characterClimbingController>().DeathOccured) 
        {
            CalculateScore();
        }
        if(_character[2].GetComponent<characterClimbingController>().DeathOccured) 
        {
            CalculateScore();
        }
        */

        if(_character[character].GetComponent<characterClimbingController>().DeathOccured) 
        {
            
            CalculateScore();
        }

        if(ScoreTimer == true)
        {
            Score += ( Time.deltaTime * 1 ) * ScoreMultiplier; //* ScoreMultiplier;
            //print("Score Timer started");
        }
        else
        {
            
        }
    }

    
    public void CalculateScore()
    {
        ScoreTimer = !ScoreTimer;
        FinalScore = Score ;//* ScoreMultiplier;
        ExpGained = Mathf.RoundToInt(FinalScore);
        
        print("ExpGained" + "" + ExpGained);
        
        
        SceneManager.LoadScene(2);
            
    }

    void PlayerSpeed()
    {
        /*
        _character[0].GetComponent<characterClimbingController>()._speedIncrease();
        _character[1].GetComponent<characterClimbingController>()._speedIncrease();
        _character[2].GetComponent<characterClimbingController>()._speedIncrease();

        */
        _character[character].GetComponent<characterClimbingController>()._speedIncrease();
    }

    void CubeSpawnRate()
    {
        CubeSpawner.GetComponent<CubeSpawner>().SpawnRateIncrease();
    }

    void ScoreMultiplierRate()
    {
        if(ScoreMultiplier <= MultiplierLimit)
        {
            ScoreMultiplier += ScoreMultiplierIncrease;
        }
    }

    void OnDisable() 
    {
        PlayerPrefs.SetInt("ExpGained", ExpGained);
    }

   void OnEnable()
    {
        character = PlayerPrefs.GetInt("character");
    }
}
