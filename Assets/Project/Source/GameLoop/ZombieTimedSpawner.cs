using System.Collections;
using Unity.Mathematics;
using UnityEngine;

public class ZombieTimedSpawner : MonoBehaviour
{
    [SerializeField]
    private ObjectPooler _objectPooler;

    private int _maxAmountOfZombies = 10;

    protected void Start()
    {
        StartCoroutine(SpawnZombieRoutine());
    }

    private IEnumerator SpawnZombieRoutine()
    {
        while (_maxAmountOfZombies > 0)
        {
            yield return new WaitForSeconds(5);
            GameObject newZombie;
            if (_objectPooler.SpawnFromPool(PoolerIdEnum.ZOMBIE, transform.position, quaternion.identity, out newZombie))
            {
                _maxAmountOfZombies -= 1;
            }
        }
    }
}
