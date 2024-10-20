namespace ShootEmUp
{
    public class KeyboardInputHandlerComponent : InputHandlerComponent
    {
        private KeyboardInputHandler _keyboardInputHandler = new KeyboardInputHandler();
        
        public override IInputHandler GetInputHandler()
        {
            return _keyboardInputHandler;
        }
        
        private void Update()
        {
            _keyboardInputHandler.ProcessInput();
        }
    }
}