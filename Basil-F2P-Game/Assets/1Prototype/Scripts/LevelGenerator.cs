using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] levelPrefabs;
    public float ySpawn = 0;
    public float levelLength = 99;
    public int numberOfLevels = 3;

    public int character;

    private List<GameObject> activeLevels = new List<GameObject>();

    public Transform[] player;

    void start()
    {
        

        for( int i = 0; i < numberOfLevels; i++)
        {
            if ( i == 0)
            {
                SpawnLevel(0);
            }
            else
            {
                SpawnLevel(Random.Range(0, levelPrefabs.Length));
            }
        }

    }

    void Update()
    {
        if(player[character].position.y > ySpawn - (numberOfLevels * levelLength))
        {
           //print("Level Spawned");
           SpawnLevel(Random.Range(0, levelPrefabs.Length));
            
        }

        /*
         else if(player.position.y - SafeZone > ySpawn - (numberOfLevels * levelLength))
        {
            DeleteLevel();
        }
        */
    }

    public void SpawnLevel(int levelIndex)
    {
        GameObject a = Instantiate(levelPrefabs[levelIndex], transform.up * ySpawn, transform.rotation);
        activeLevels.Add(a);
        ySpawn += levelLength;
    }

   /*
    private void DeleteLevel()
    {
        Debug.Log("Level (a) Destroyed:");
        Destroy(activeLevels[0]);
        activeLevels.RemoveAt(0);
    }
    */

    void OnEnable()
    {
        character = PlayerPrefs.GetInt("character");
    }
}
