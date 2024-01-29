using UnityEngine;

public class BulletCollisionDetection : MonoBehaviour
{
    private BulletDamage _myBulletDamageComponent;

    protected void Start()
    {
        _myBulletDamageComponent = transform.GetComponent<BulletDamage>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.TryGetComponent(out Zombie zombie))
        {
            zombie.TakeHit(_myBulletDamageComponent.GetDamageValue());
            DespawnBullet();
        }
    }

    private void DespawnBullet()
    {
        gameObject.SetActive(false);
    }
}
