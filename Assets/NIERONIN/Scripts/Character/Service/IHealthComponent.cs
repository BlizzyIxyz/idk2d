using System;

public interface IHealthComponent
{
    event Action<int> OnHealthChange;
    void TakeDamage(int damage);
}
