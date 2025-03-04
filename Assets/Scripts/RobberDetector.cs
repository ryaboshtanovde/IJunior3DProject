using System;
using UnityEngine;

public class RobberDetector : MonoBehaviour
{
    [SerializeField] private float _radius;
    public bool _wasFounded = false;
    public event Action _robberDetected;

    void FixedUpdate()
    {
        RaycastHit[] hits = Physics.SphereCastAll(transform.position, _radius, Vector3.one);
        {
            foreach (RaycastHit hit in hits)
            {
                if (hit.transform.gameObject.TryGetComponent(out Robber script) != _wasFounded)
                {
                    _wasFounded = !_wasFounded;
                    _robberDetected?.Invoke();
                }
            }
        }
    }
}
