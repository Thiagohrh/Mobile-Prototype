using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    [SerializeField] private int _damageValue = 1;

    public int GetDamageValue()
    {
        return _damageValue;
    }
}
