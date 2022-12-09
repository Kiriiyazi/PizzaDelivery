using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationMap: MonoBehaviour
{
    [SerializeField] private Transform _startPoint;
    [SerializeField] private Road[] _roadsPrefab;
    [SerializeField] private int _size;

    private Road[] _gameObjects;

    private void Awake()
    {
          BuildArray();
    }

    public Road[] BuildArray()
    {
        GenegateRoad();
        Transform currentPoint = _startPoint;
        for (int i = 0; i < _gameObjects.Length; i++)
        {
            _gameObjects[i] = BuildRoad(currentPoint, i);
            currentPoint = _gameObjects[i].transform;
        }
        return _gameObjects;
    }
    private Road[] GenegateRoad()
    {
        _gameObjects = new Road[_size];

        for (int i = 0; i < _gameObjects.Length - 1; i++)
        {
            if (i == 0)
            {
                _gameObjects[0] = _roadsPrefab[0];
                _gameObjects[_gameObjects.Length - 1] = _roadsPrefab[_roadsPrefab.Length - 1];
                continue;
            }
            _gameObjects[i] = _roadsPrefab[Random.Range(1, _roadsPrefab.Length - 1)];
        }
        return _gameObjects;
    }
    private Road BuildRoad(Transform currentBuildPoint, int index)
    {
        return Instantiate(_gameObjects[index], GetBuildPoint(currentBuildPoint, index), Quaternion.identity, _startPoint);
    }

    private Vector3 GetBuildPoint(Transform currentSegment, int index)
    {
        return new Vector3(currentSegment.position.x + currentSegment.localScale.x / 2 + _gameObjects[index].transform.localScale.x / 2, _startPoint.position.y, _startPoint.position.z);
    }



}
