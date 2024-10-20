using UnityEngine;

namespace ShootEmUp
{
    public class PlayerMovement : MonoBehaviour, IMovable
    {
        [SerializeField]
        private float speed = 5.0f;

        [SerializeField]
        private Rigidbody2D _rigidbody;

        public void Move(float direction)
        {
            Vector2 moveStep = new Vector2(direction, 0) * speed * Time.fixedDeltaTime;
            Vector2 targetPosition = _rigidbody.position + moveStep;
            _rigidbody.MovePosition(targetPosition);
        }
    }
}