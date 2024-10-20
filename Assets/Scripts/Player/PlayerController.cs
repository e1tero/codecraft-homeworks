using UnityEngine;

namespace ShootEmUp
{
    public sealed class PlayerController : MonoBehaviour
    {
        [SerializeField]
        private PlayerMovement movementComponent;

        [SerializeField]
        private HealthComponent healthComponent;

        [SerializeField]
        private PlayerShooter shooterComponent;

        [SerializeField]
        private InputHandlerComponent inputHandlerComponent;

        private IMovable movement;
        private IHealth health;
        private IShooter shooter;
        private IInputHandler inputHandler;

        private void Awake()
        {
            movement = movementComponent;
            health = healthComponent;
            shooter = shooterComponent;

            if (inputHandlerComponent != null)
            {
                inputHandler = inputHandlerComponent.GetInputHandler();
                inputHandler.OnFirePressed += HandleFire;
            }

            if (health != null)
            {
                health.OnHealthEmpty += HandleHealthEmpty;
            }
        }

        private void OnDestroy()
        {
            if (inputHandler != null)
            {
                inputHandler.OnFirePressed -= HandleFire;
            }

            if (health != null)
            {
                health.OnHealthEmpty -= HandleHealthEmpty;
            }
        }

        private void FixedUpdate()
        {
            if (inputHandler == null) return;

            float moveDirection = inputHandler.GetMoveDirection();
            movement?.Move(moveDirection);
        }

        private void HandleFire()
        {
            shooter?.Shoot();
        }

        private void HandleHealthEmpty()
        {
            Time.timeScale = 0;
        }
    }
}