using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D _myRigidbody2D;
    private float _bulletSpeed = 2000;

    private void OnEnable()
    {
        _myRigidbody2D = transform.GetComponent<Rigidbody2D>();
    }

    public void BulletSetups(float direction)
    {
        Vector2 newForceVector = new Vector2(direction * _bulletSpeed, 0.0f);
        _myRigidbody2D.AddForce(newForceVector);
    }
}
