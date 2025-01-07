using UnityEngine;

[RequireComponent(typeof(Renderer))]
public abstract class Enemy : MonoBehaviour
{
    private Target _target;

    public abstract Color MaterialColor { get; set; }
    public abstract float Speed { get; set; }

    private void Start()
    {
        GetComponent<MeshRenderer>().material.color = MaterialColor;
    }

    private void FixedUpdate()
    {
        Vector3 moveDirection = (_target.transform.position - transform.position).normalized;

        transform.position += moveDirection * Speed;
    }

    public void SetTarget(Target target)
    {
        _target = target;
    }
}
