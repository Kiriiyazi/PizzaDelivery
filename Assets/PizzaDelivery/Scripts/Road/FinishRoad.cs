using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishRoad : MonoBehaviour
{
    [SerializeField] private GameObject _customer;

    public void ActivatetAnimationPizza()
    {
         _customer.GetComponent<Animator>().Play("Pizza");
    }


    
}
