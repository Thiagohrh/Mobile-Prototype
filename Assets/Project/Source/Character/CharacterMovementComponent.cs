using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CharacterMovementComponent : MonoBehaviour
{
    private const int JumpForce = 4000;
    private const float Acceleration = 1f;
    private const float MaxSpeed = 20.0f;
    private Rigidbody2D _myRigidbody2D;
    private CharacterGroundDetection _myGroundDetectionComponent;

    private void OnEnable()
    {
        _myRigidbody2D = transform.GetComponent<Rigidbody2D>();
        _myGroundDetectionComponent = transform.GetComponent<CharacterGroundDetection>();
    }

    public void Jump()
    {
        if (_myGroundDetectionComponent.IsGrounded)
        {
            _myRigidbody2D.AddForce(Vector2.up * JumpForce);
        }
    }

    public void Move(float direction)
    {
        float xTargetVelocity = (direction * MaxSpeed);
        float xForce = (xTargetVelocity - _myRigidbody2D.velocity.x) * Acceleration;
        if (xForce > MaxSpeed)
        {
            xForce = Mathf.Clamp(xForce, -MaxSpeed, MaxSpeed);
        }

        _myRigidbody2D.AddForce(new Vector2(xForce, 0.0f));
    }
}
