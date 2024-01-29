using UnityEngine;

public class CharacterInputManager : MonoBehaviour, IControlableCharacter
{
    private CharacterMovementComponent _myCharacterMovementComponent;
    private BulletSpawner _myBulletSpawnerComponent;

    private void OnEnable()
    {
        _myCharacterMovementComponent = transform.GetComponent<CharacterMovementComponent>();
        _myBulletSpawnerComponent = transform.GetComponent<BulletSpawner>();
    }

    public void Jump()
    {
        _myCharacterMovementComponent.Jump();
    }

    public void Move(float direction)
    {
        _myCharacterMovementComponent.Move(direction);
    }

    public void Shoot()
    {
        _myBulletSpawnerComponent.ShootBullet();
    }

    public void Strike()
    {
        Debug.Log("<color=cyan> Strike! </color>");
    }
}
