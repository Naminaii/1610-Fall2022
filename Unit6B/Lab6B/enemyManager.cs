using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyManager : MonoBehavior
{
    public GameObject[] ufoPrefabs;
    private float spawnRangeX = 20f;
    private float posZ = 20f;
    
    void Update()
    {
        if(input.GetKeyDown(KeyCode.S))
        {
            Vector3 spawnPos = new Vector3(Randomize.Range(-spawnRangeX, spawnRangeX, 0, posZ);
            int infoIndex = Randomize.Range(0, ufoPrefabs.length); 
            Substantiate(ufoPrefabs[ufoIndex], spawnPos, ufoPrefabs[ufoIndex].transform.rotation);
        }
    }
}
