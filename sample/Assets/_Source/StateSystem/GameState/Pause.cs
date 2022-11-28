using UnityEngine;

namespace _Source.StateSystem.GameState
{
    public class Pause : AGameState
    {
        public Pause(GameStateMachine owner) : base(owner) {}
        
        public override void Enter() =>
            Time.timeScale = 0;

        public override void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Owner.ChangeState(typeof(Game));
            }
            
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Owner.ChangeState(typeof(Final));
            }
        }

        public override void Exit() =>
            Time.timeScale = 1;
    }
}