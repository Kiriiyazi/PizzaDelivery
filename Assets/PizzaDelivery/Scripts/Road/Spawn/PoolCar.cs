using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PoolCar : MonoBehaviour
{
    [SerializeField] private GameObject _poolContainer;
    [SerializeField] private int _poolCount;

    private List<GameObject> _pools = new List<GameObject>();
    protected void Initialize(GameObject spawnPoint)
    {
        for (int i = 0; i < _poolCount; i++)
        {
            GameObject spawned = Instantiate(spawnPoint, _poolContainer.transform);
            spawned.SetActive(false);
            _pools.Add(spawned);
        }
    }

    protected void Initialize(GameObject[] prefabCar)
    {
        for (int i = 0; i < _poolCount; i++)
        {
            int index = Random.Range(0, prefabCar.Length);
            GameObject spawned = Instantiate(prefabCar[index], _poolContainer.transform);
            spawned.SetActive(false);
            _pools.Add(spawned);
        }
    }

    protected bool TryGetObject( out GameObject result)
    {
        result = _pools.FirstOrDefault(p => p.activeSelf == false);
        return result != null;
    }

}
