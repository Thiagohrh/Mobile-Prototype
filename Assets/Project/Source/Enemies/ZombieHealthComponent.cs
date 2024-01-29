using System;
using UnityEngine;

public class ZombieHealthComponent : MonoBehaviour
{
    private const int  MaxTotalHealth = 3;
    private int _currentHealth;
    public event Action OnZombieDeath;

    protected void OnEnable()
    {
        _currentHealth = MaxTotalHealth;
    }

    public void ApplyDamageValue(int value)
    {
        _currentHealth -= value;
    }

    private void CheckDeathCondition()
    {
        if (_currentHealth <= 0)
        {
            OnZombieDeath?.Invoke();
        }
    }
}
