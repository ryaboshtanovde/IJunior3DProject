using UnityEngine;

public class Robber : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _maxSpeed = 0.01f;
    private void Update()
    {
        transform.position = new Vector3(Mathf.MoveTowards(transform.position.x, _target.position.x, _maxSpeed), transform.position.y, transform.position.z);
    }
}