using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject ObjectPrefab;
    public GameObject character;
    public float respawnTime = 1.0f;
    public float respawnRate = 0.2f;
    public float destroyTime = 5.0f;

    public float xValue = 10.0f;
    public float yValue = 10.0f;
    public float zValue = 7.0f;

    void Start()
    {
        
        StartCoroutine(ObjectWave());
    }

    IEnumerator ObjectWave()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnObject();
        }
    }    

    private void spawnObject()
    {
        GameObject cube = Instantiate(ObjectPrefab) as GameObject;
        cube.transform.position = new Vector3(Random.Range(-xValue, xValue),character.transform.position.y + yValue, zValue);
        Destroy(cube, destroyTime);
    }

    private void OnCollisionEnter(Collision other) 
    {
        
            Debug.Log(other);
            Destroy(other.gameObject);
       
        
    }

    public void SpawnRateIncrease()
    {
       if(respawnTime > respawnRate + 0.1f)
       {
        respawnTime -= respawnRate;    
       }
        
    }

    
}
