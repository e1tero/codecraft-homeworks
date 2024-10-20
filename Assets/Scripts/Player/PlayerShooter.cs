using UnityEngine;

namespace ShootEmUp
{
    public class PlayerShooter : MonoBehaviour, IShooter
    {
        [SerializeField]
        private Transform firePoint;

        [SerializeField]
        private BulletManager bulletManager;

        public void Shoot()
        {
            bulletManager.SpawnBullet(
                firePoint.position,
                Color.blue,
                (int)PhysicsLayer.PLAYER_BULLET,
                1,
                true,
                firePoint.rotation * Vector3.up * 3
            );
        }
    }
}