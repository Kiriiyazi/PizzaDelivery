using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCar : PoolCar
{
    [SerializeField] private Transform[] _spawnPoint;
    [SerializeField] private GameObject[] _cars;
    [SerializeField] private float _secondsBetweenSpawn;

    private float _elapsedTime = 0;

    private void Start()
    {
        Initialize(_cars);
    }

    private void Update()
    {
        _elapsedTime += Time.deltaTime;
        if (_elapsedTime >= _secondsBetweenSpawn)
        {
            if (TryGetObject(out GameObject car))
            {
                _elapsedTime = 0;
                
                int spawnPointNumber = Random.Range(0, _spawnPoint.Length);
                SetEnemy(car, _spawnPoint[spawnPointNumber].position);
            }
        }
    }

    private void SetEnemy(GameObject car, Vector3 spawnPoint)
    {
        car.SetActive(true);
        car.transform.position = spawnPoint;
    }
}
