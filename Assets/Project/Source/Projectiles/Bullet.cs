using System;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D _myRigidbody2D;

    private void Start()
    {
        _myRigidbody2D = transform.GetComponent<Rigidbody2D>();
    }

    public void BulletSetups(float direction)
    {
        // Add force to that side.
    }
}
