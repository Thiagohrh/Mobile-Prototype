using UnityEngine;

public class ZombieDeathController : MonoBehaviour
{
    public void HandleZombieDeath()
    {
        gameObject.SetActive(false);
    }
}
