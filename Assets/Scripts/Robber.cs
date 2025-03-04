using TMPro.EditorUtilities;
using UnityEngine;

public class Robber : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _maxSpeed = 0.01f;
    private bool _targetIsReceived = false;
    private float _selectionDistance = 1;

    private void Update()
    {
        if ((transform.position - _target.position).magnitude <= _selectionDistance)
            _targetIsReceived = true;

        if (_targetIsReceived)
        {
            transform.position = new Vector3(Mathf.MoveTowards(transform.position.x, _target.position.x, -_maxSpeed), transform.position.y, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(Mathf.MoveTowards(transform.position.x, _target.position.x, _maxSpeed), transform.position.y, transform.position.z);
        }
    }
}