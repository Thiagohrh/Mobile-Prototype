using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    [SerializeField] ObjectPooler _objectPooler;

    public void ShootBullet()
    {
        GameObject newBullet;
        if (_objectPooler.SpawnFromPool(PoolerIdEnum.BULLET, transform.position, Quaternion.identity, out newBullet))
        {
            HandleNewBulletSetups(newBullet.transform.GetComponent<Bullet>());
        }
    }

    private void HandleNewBulletSetups(Bullet bulletComponent)
    {
        bulletComponent.BulletSetups(1.0f); // Ok so...how do I do this...lesseee...
    }
}
