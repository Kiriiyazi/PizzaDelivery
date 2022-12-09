using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] private float _speed;

    private int _damage = 1;

    private void Update()
    {
        gameObject.transform.position -= new Vector3(0, 0, _speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.TryGetComponent(out Destroy destroy))
            gameObject.SetActive(false);
        if (collider.TryGetComponent(out Player player))
        {
            player.ApplyDamage(_damage);
            gameObject.SetActive(false);

        }
    }


}
