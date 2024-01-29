using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CharacterMovementComponent : MonoBehaviour
{
    private const int JumpForce = 2500;
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
        
    }
}
