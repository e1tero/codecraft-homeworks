using System;

namespace ShootEmUp
{
    public interface IHealth
    {
        int Health { get; }
        void TakeDamage(int damage);
        event Action<int> OnHealthChanged;
        event Action OnHealthEmpty;
    }
}