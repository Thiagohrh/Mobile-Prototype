using UnityEngine;

[RequireComponent(typeof(CharacterMotionRegistry))]
public class BulletSpawner : MonoBehaviour
{
    [SerializeField] ObjectPooler _objectPooler;
    private CharacterMotionRegistry _myMotionRegistryComponent;

    protected void Start()
    {
        _myMotionRegistryComponent = transform.GetComponent<CharacterMotionRegistry>();
    }

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
        bulletComponent.BulletSetups(_myMotionRegistryComponent.LastDirection);
    }
}
