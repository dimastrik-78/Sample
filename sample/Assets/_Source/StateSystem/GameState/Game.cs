using _Source.PlayerSystem;
using UnityEngine;

namespace _Source.StateSystem.GameState
{
    public class Game : AGameState
    {
        private PlayerInput _playerInput;
        public Game(GameStateMachine owner, PlayerInput playerInput) : base(owner)
        {
            _playerInput = playerInput;
        }
        
        public override void Enter() =>
            _playerInput.enabled = true;
        
        public override void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Owner.ChangeState(typeof(Pause));
            }
            
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Owner.ChangeState(typeof(Final));
            }
        }
        public override void Exit() =>
            _playerInput.enabled = false;
    }
}