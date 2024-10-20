using System;
using UnityEngine;

namespace ShootEmUp
{
    public class HealthComponent : MonoBehaviour, IHealth
    {
        [SerializeField]
        private int health;

        public int Health => health;

        public event Action<int> OnHealthChanged;
        public event Action OnHealthEmpty;

        public void TakeDamage(int damage)
        {
            health -= damage;
            OnHealthChanged?.Invoke(health);

            if (health <= 0)
            {
                OnHealthEmpty?.Invoke();
            }
        }
    }
}