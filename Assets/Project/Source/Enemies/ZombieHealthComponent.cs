using System;
using UnityEngine;

public class ZombieHealthComponent : MonoBehaviour
{
    private const int  MaxTotalHealth = 3;
    private int _currentHealth;
    private ZombieDeathController _myZombieDeathControllerComponent;
    public event Action OnZombieDeath;

    protected void Start()
    {
        _myZombieDeathControllerComponent = transform.GetComponent<ZombieDeathController>();
    }

    protected void OnEnable()
    {
        _currentHealth = MaxTotalHealth;
    }

    public void ApplyDamageValue(int value)
    {
        _currentHealth -= value;
        CheckDeathCondition();
    }

    private void CheckDeathCondition()
    {
        if (_currentHealth <= 0)
        {
            OnZombieDeath?.Invoke();
            _myZombieDeathControllerComponent.HandleZombieDeath();
        }
    }
}
