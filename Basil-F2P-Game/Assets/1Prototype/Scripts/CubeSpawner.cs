using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject ObjectPrefab;
    public GameObject character;
    public float respawnTime = 1.0f;
    public float destroyTime = 5.0f;

    public float xValue = 10.0f;
    public float yValue = 10.0f;
    public float zValue = 7.0f;

    void Start()
    {
        StartCoroutine(ObjectWave());
    }

    private void spawnObject()
    {
        GameObject cube = Instantiate(ObjectPrefab) as GameObject;
        cube.transform.position = new Vector3(Random.Range(-xValue, xValue),character.transform.position.y + yValue, zValue);
        Destroy(cube, destroyTime);
    }
    
    IEnumerator ObjectWave()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnObject();
        }
    }    

    
}
