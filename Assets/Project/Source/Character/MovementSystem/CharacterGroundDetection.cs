using UnityEngine;

public class CharacterGroundDetection : MonoBehaviour
{
    public bool IsGrounded { get; private set; }
    [SerializeField] 
    private LayerMask _groundLayerMask;
    private RaycastHit2D[] _collisionRaycastBuffer = new RaycastHit2D[5];
    private const float _distanceToGroundCheck = 1.6f;
    
    void Update()
    {
        CheckForGrounded();
    }

    private void CheckForGrounded()
    {
        int hits = Physics2D.CircleCastNonAlloc(transform.position, 1.0f, Vector2.down, _collisionRaycastBuffer, _distanceToGroundCheck,
            _groundLayerMask);
        if (hits > 0)
        {
            IsGrounded = true;
            return;
        }

        IsGrounded = false;
    }
}
