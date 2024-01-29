using UnityEngine;

public class ZombieHealthComponent : MonoBehaviour
{
    private const int  MaxTotalHealth = 3;
    private int _currentHealth;

    protected void OnEnable()
    {
        _currentHealth = MaxTotalHealth;
    }

    public void ApplyDamageValue(float value)
    {
        
    }
}
