using UnityEngine;

public class CharacterInputManager : MonoBehaviour, IControlableCharacter
{
    public void Jump()
    {
        Debug.Log("<color=cyan> Jump! </color>");
    }

    public void Move(float direction)
    {
        Debug.Log("<color=blue> Move! </color>");
    }

    public void Shoot()
    {
        Debug.Log("<color=cyan> Shoot! </color>");
    }

    public void Strike()
    {
        Debug.Log("<color=cyan> Strike! </color>");
    }
}
