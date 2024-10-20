using UnityEngine;

namespace ShootEmUp
{
    public abstract class InputHandlerComponent : MonoBehaviour
    {
        public abstract IInputHandler GetInputHandler();
    }
}