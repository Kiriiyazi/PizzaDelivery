using UnityEngine;

public class Animation : MonoBehaviour
{
    [SerializeField] private GameEvent _gameEvent;
    private Animator _animator;
    private void Start()
    {
        _animator = GetComponent<Animator>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out FinishRoad finish))
        {
            _animator.Play("Drift");
            finish.ActivatetAnimationPizza();
                        
        }
        if (other.TryGetComponent(out Car car))
        {
            _animator.Play("Crash");
            
        }
        
    }




}
