using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateScene : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private GameObject _startPoint;
    [SerializeField] private int _startingActivateRoad;


    private void Start()
    {   
        GetCountChildren();
        GetActivateRoad(_startingActivateRoad);
        GetActivPlayer();
    }

    private void GetCountChildren()
    {
        int index = _startPoint.GetComponentInChildren<Transform>().childCount;
        GetActivateRoad(index);
    }

    private void GetActivateRoad(int index)
    {
        for (int i = 0; i < index; i++)
        {
            _startPoint.GetComponent<Transform>().GetChild(i).gameObject.SetActive(true);
        }
        
    }

    private void GetActivPlayer()
    {
        _player.gameObject.SetActive(true);
    }
}
