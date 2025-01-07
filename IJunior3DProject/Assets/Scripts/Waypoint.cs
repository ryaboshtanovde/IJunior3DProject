using UnityEngine;

[RequireComponent (typeof(SphereCollider))]
public class Waypoint : MonoBehaviour
{
    private void Start()
    {
        GetComponent<SphereCollider>().isTrigger = true;
    }
}
