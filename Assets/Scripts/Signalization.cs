using UnityEngine;

public class Signalization : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private float _radius;

    private void Start()
    {
        _audioSource.volume = 0;
    }

    private void FixedUpdate()
    {
        RaycastHit[] hits = Physics.SphereCastAll(transform.position, _radius, Vector3.one);
        {
            foreach (RaycastHit hit in hits)
            {
                if (hit.transform.gameObject.TryGetComponent(out Robber script))
                {
                    _audioSource.volume = ((hit.transform.position - transform.position).magnitude - _radius)/(-_radius);
                }
            }
        }
    }
}
