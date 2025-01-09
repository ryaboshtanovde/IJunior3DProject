using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Target : MonoBehaviour
{
    [SerializeField] private List<Waypoint> _waypoints = new List<Waypoint>();
    private float _speed = 0.1f;
    private Waypoint _currentPoint;
    private Vector3 _moveDirection;
    private int index = 0;

    private void Start()
    {
        GetComponent<Rigidbody>().isKinematic = true;
        _currentPoint = _waypoints[0];
        _moveDirection = (_currentPoint.transform.position - transform.position).normalized;
    }

    private void FixedUpdate()
    {
        if (_currentPoint != null)
            transform.Translate(_moveDirection * _speed);
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.TryGetComponent(out Waypoint waypoint))
        {
            _currentPoint = _waypoints[++index % _waypoints.Count];

            _moveDirection = (_currentPoint.transform.position - transform.position).normalized;
        }
    }
}
