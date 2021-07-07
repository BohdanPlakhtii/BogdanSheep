using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sheepSpawner : MonoBehaviour
{
    public GameObject sheep;
    public Vector3 SpawnPoint;
    public float spawnRate;
    private float Border;
    private float x;
    void Start()
    {
        StartCoroutine(SpawnSheep());
    }

    void createSheep()
    {
        x = Random.Range(24, -18);
        SpawnPoint = new Vector3(x, 4, -45);
        Instantiate(sheep, SpawnPoint, sheep.transform.rotation);
    }

    IEnumerator SpawnSheep()
    {
        while (true)
        { 
            yield return new WaitForSeconds(spawnRate);
            createSheep();
        }
        
    }

}
