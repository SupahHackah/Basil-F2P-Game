using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDifficulty : MonoBehaviour
{
    public float x_time = 60; // Invoke repeating every x time
    public GameObject _player;
    public GameObject CubeSpawner;

    
    
    // Start is called before the first frame update
    void Start()
    {
        _player.GetComponent<characterClimbingController>();
        CubeSpawner.GetComponent<CubeSpawner>();

        InvokeRepeating("PlayerSpeed", 0.0f, x_time);
        InvokeRepeating("CubeSpawnRate", 0.0f, x_time);
    }


    void PlayerSpeed()
    {
        _player.GetComponent<characterClimbingController>()._speedIncrease();
    }

    void CubeSpawnRate()
    {
        CubeSpawner.GetComponent<CubeSpawner>().SpawnRateIncrease();
    }
}
