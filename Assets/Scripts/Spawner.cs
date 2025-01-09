using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Target _target;
    [SerializeField] private Enemy _prefab;
    [SerializeField] private float _delay = 1.5f;

    private void Start()
    {
        StartCoroutine(SpawnEnemys());
    }

    private IEnumerator SpawnEnemys()
    {
        WaitForSeconds waitForSeconds = new WaitForSeconds(_delay);
        while (enabled)
        {
            yield return waitForSeconds;

            Instantiate(_prefab, transform.position, Quaternion.identity).SetTarget(_target);
        }
    }
}
