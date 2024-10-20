using System;
using UnityEngine;

namespace ShootEmUp
{
    public sealed class Player : MonoBehaviour
    {
        [SerializeField] private HealthComponent _healthComponent;

        public int GetHealth()
        {
            return _healthComponent.Health;
        }
    }
}