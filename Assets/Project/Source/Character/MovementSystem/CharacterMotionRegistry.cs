using UnityEngine;

public class CharacterMotionRegistry : MonoBehaviour
{
    public float LastDirection { get; private set; }
    private Rigidbody2D _myRigidbody2D;

    void Start()
    {
        _myRigidbody2D = transform.GetComponent<Rigidbody2D>();
        LastDirection = 1.0f;
    }
    
    protected void Update()
    {
        if (_myRigidbody2D.velocity.x > 0 || _myRigidbody2D.velocity.x < 0 )
        {
            float direction = _myRigidbody2D.velocity.normalized.x;
            if (direction > 0 || direction < 0)
            {
                LastDirection = direction;
            }
        }
    }
}
