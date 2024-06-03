using UnityEngine;

[RequireComponent(typeof(Movement))]
public class Enemy : MonoBehaviour
{
    private Movement _movement;
    private Vector3 _direction;

    private void Awake()
    {
        _movement = GetComponent<Movement>(); 
    }

    private void Update()
    {
        _movement.Move(_direction.normalized);     
    }

    public void Initialize(Vector3 direction)
    {
        _direction = direction;
    }
}
