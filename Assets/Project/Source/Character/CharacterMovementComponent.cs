using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CharacterMovementComponent : MonoBehaviour
{
    private const int JumpForce = 2500;
    private Rigidbody2D _myRigidbody2D;
    private CharacterGroundDetection _myGroundDetectionComponent;
    private float _moveSpeed = 10.0f;

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
        // Ok so...how to move to the sides here... can't add force to infinity, gotta clamp it somehow...use acceleration value as well.
        float smoothDirection = Mathf.SmoothDamp(_myRigidbody2D.velocity.x, direction, ref _moveSpeed, 0.5f);
        _myRigidbody2D.velocity = new Vector2(direction * _moveSpeed, _myRigidbody2D.velocity.y);
    }
}
