using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Target : MonoBehaviour
{
    [SerializeField] private List<Waypoint> _waypoints = new List<Waypoint>();
    private float _speed = 0.1f;
    private Waypoint _currentPoint;
    private Vector3 _moveDirection = Vector3.zero;

    private void Start()
    {
        GetComponent<Rigidbody>().isKinematic = true;
        _currentPoint = _waypoints[0];
    }

    private void FixedUpdate()
    {
        if (_currentPoint != null)
        {
            if (_moveDirection == Vector3.zero)
                _moveDirection =(_currentPoint.transform.position - transform.position).normalized;
            else
                transform.position += _moveDirection * _speed;
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.TryGetComponent(out Waypoint waypoint))
        {
            int index = _waypoints.IndexOf(waypoint);

            if (index + 1 == _waypoints.Count)
                _currentPoint = _waypoints[0];
            else
                _currentPoint = _waypoints[index + 1];

            _moveDirection = Vector3.zero;
        }
    }
}
