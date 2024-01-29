using UnityEngine;

[RequireComponent(typeof(ZombieHealthComponent))]
public class Zombie : MonoBehaviour
{
    private ZombieHealthComponent _myZombieHealthComponent;
    protected void Start()
    {
        _myZombieHealthComponent = transform.GetComponent<ZombieHealthComponent>();
    }

    public void TakeHit(int value)
    {
        _myZombieHealthComponent.ApplyDamageValue(value);
    }
}
