using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManagerList : MonoBehaviour
{
    public GameObject[] levelPrefabs;

    public float ySpawn = 0;
    public float LevelLength = 100;
    public int numberOfLevels = 3;

    public Transform player;

 void Start()
{
    for( int i = 0; i < numberOfLevels; i++ )
    {
        if ( i == 0 )
        {
            SpawnLevel(0);
        }
        else 
        {
            //int prefabIndex = UnityEngine.Random.Range(0,LevelList.Count-1);
            //SpawnLevel(prefabIndex);
            SpawnLevel(Random.Range(0, levelPrefabs.Length));
        }
    }
    
}

public void update()
{
    if( player.position.y > ySpawn - (numberOfLevels * LevelLength) + 50 )
    {
        //int prefabIndex = UnityEngine.Random.Range(0,LevelList.Count-1);
        //SpawnLevel(prefabIndex);
        SpawnLevel(Random.Range(0, levelPrefabs.Length));
    }
}

public void SpawnLevel(int levelIndex)
{
    Instantiate(levelPrefabs[levelIndex], transform.up * ySpawn, transform.rotation);
    ySpawn += LevelLength;
}


}
