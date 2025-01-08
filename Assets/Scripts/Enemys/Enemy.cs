using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public abstract class Enemy : MonoBehaviour
{
    private Target _target;

    public abstract Color MaterialColor { get; protected set; }
    public abstract float Speed { get; protected set; }

    private void Start()
    {
        GetComponent<MeshRenderer>().material.color = MaterialColor;
    }

    private void Update()
    {
        Vector3 moveDirection = (_target.transform.position - transform.position).normalized;

        transform.position += moveDirection * Speed * Time.deltaTime;
    }

    public void SetTarget(Target target)
    {
        _target = target;
    }
}
