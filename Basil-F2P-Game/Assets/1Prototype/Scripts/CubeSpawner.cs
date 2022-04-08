using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject[] Props;
    public int _currentlevel = 0;
    
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

    void Awake()
    {
        
    }

    void OnEnable()
    {
        StartCoroutine(ObjectWave());
    }

    void Update()
    {
        
    }

    IEnumerator ObjectWave()
    {
        while(true)
        {   
            yield return new WaitForSeconds(respawnTime);
            SpawnObject();
            //print("SpawnObject");
            
        }
    }    

    public void SpawnObject()
    {
        //print("SpawnObject Reached");

        switch (_currentlevel)
        {
            case 0:
                    GameObject l0 = Instantiate(Props[0]) as GameObject;
                    l0.transform.position = new Vector3(Random.Range(-xValue, xValue),character.transform.position.y + yValue, zValue);
                    Destroy(l0, destroyTime);
                    //print("L0");
                    break;
            
            case 1:
                    GameObject l1 = Instantiate(Props[1]) as GameObject;
                    l1.transform.position = new Vector3(Random.Range(-xValue, xValue),character.transform.position.y + yValue, zValue);
                    Destroy(l1, destroyTime);
                    //print("L1");
                    break;

            case 2:
                    GameObject l2 = Instantiate(Props[2]) as GameObject;
                    l2.transform.position = new Vector3(Random.Range(-xValue, xValue),character.transform.position.y + yValue, zValue);
                    Destroy(l2, destroyTime);
                    //print("L2");
                    break;
        }
        

        // GameObject L0 = Instantiate(Props[Random.Range(0, Props.Length)]) as GameObject;
        /*
        if(GetComponent<Level0OnT>()._level0 == true)
        {
            GameObject L0 = Instantiate(Pizza); //as GameObject;
            L0.transform.position = new Vector3(Random.Range(-xValue, xValue),character.transform.position.y + yValue, zValue);
            Destroy(L0, destroyTime);
            print("L0");
        }
        else
        {

        }
            
        if(GetComponent<Level1OnT>()._level1 == true)
        {
            GameObject L1 = Instantiate(Coffee); //as GameObject;
            L1.transform.position = new Vector3(Random.Range(-xValue, xValue),character.transform.position.y + yValue, zValue);
            Destroy(L1, destroyTime);
            print("L1");
        }
        else
        {

        }
            
        if(GetComponent<Level2OnT>()._level2 == true)
        {
            GameObject L2 = Instantiate(Cola); //as GameObject;
            L2.transform.position = new Vector3(Random.Range(-xValue, xValue),character.transform.position.y + yValue, zValue);
            Destroy(L2, destroyTime);
            print("L2");
        }
        else
        {

        }
        */
    }


    void OnTriggerEnter(Collider other)
    {
               
         if(other.gameObject.tag == "Level0" )
        {
            _currentlevel = 0;
            //print("Player has entered level0");
        }

        if(other.gameObject.tag == "Level1" )
        {
            _currentlevel = 1;
            //print("Player has entered level1");
        }

        if(other.gameObject.tag == "Level2" )
        {
            _currentlevel = 2;
            //print("Player has entered level2");
        }
    }

    public void SpawnRateIncrease()
    {
       if(respawnTime > respawnRate )
       {
        respawnTime -= respawnRate;    
       }
        
    }

    
}
