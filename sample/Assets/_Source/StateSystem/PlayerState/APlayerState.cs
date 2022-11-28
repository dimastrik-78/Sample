namespace _Source.StateSystem.PlayerState
{
    public abstract class APlayerState
    {
        protected PlayerStateMachine Owner;
        protected APlayerState(PlayerStateMachine owner)
        {
            Owner = owner;
        }

        public virtual void Enter() {}

        public virtual void Update() {}

        public virtual void Exit() {}
    }
}