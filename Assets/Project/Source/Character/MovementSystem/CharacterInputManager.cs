using UnityEngine;

public class CharacterInputManager : MonoBehaviour, IControlableCharacter
{
    private CharacterMovementComponent _myCharacterMovementComponent;

    private void OnEnable()
    {
        _myCharacterMovementComponent = transform.GetComponent<CharacterMovementComponent>();
    }

    public void Jump()
    {
        _myCharacterMovementComponent.Jump();
    }

    public void Move(float direction)
    {
        _myCharacterMovementComponent.Move(direction);
    }

    public void Shoot() // Will check this out later.
    {
        Debug.Log("<color=cyan> Shoot! </color>");
    }

    public void Strike()
    {
        Debug.Log("<color=cyan> Strike! </color>");
    }
}
