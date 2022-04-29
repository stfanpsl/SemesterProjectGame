using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunitionSpawner : MonoBehaviour
{

    private float _spawnRangeX;
    private float _spawnRangeZ;
    private float _spawnIntervalRange;
    private float _spawnOffset;

    public Munition[] Munition;

    void Start()
    {
        _spawnRangeX = 14;
        _spawnRangeZ = 18;
        _spawnOffset = 5;

        Invoke("SpawnRandomMunition", _spawnOffset);
    }


    void Update()
    {

    }


    private Vector3 RandomSpawnPosition()
    {
        return new Vector3(Random.Range(0, _spawnRangeX), 0, Random.Range(0, _spawnRangeZ));
    }

    private void SpawnRandomMunition()
    {

        int ranPosMunition = Random.Range(0, Munition.Length);
        Instantiate(Munition[ranPosMunition], RandomSpawnPosition(), Munition[ranPosMunition].transform.rotation);
        //RECURSION!

        //Abbruchbedingung
        if (true)
        {
            Invoke("SpawnRandomMunition", Random.Range(0,Munition[ranPosMunition].SpawnIntervalNextMunition));
        }



    }
}
