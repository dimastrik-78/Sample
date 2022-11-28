namespace _Source.StateSystem.GameState
{
    public abstract class AGameState
    {
        protected GameStateMachine Owner;
        protected AGameState(GameStateMachine owner)
        {
            Owner = owner;
        }

        public virtual void Enter() {}

        public virtual void Update() {}

        public virtual void Exit() {}
    }
}