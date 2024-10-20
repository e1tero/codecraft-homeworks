using System;

namespace ShootEmUp
{
    public interface IInputHandler
    {
        float GetMoveDirection();
        event Action OnFirePressed;
    }
}