using _Source.StateSystem.PlayerState;
using UnityEngine;

namespace _Source.PlayerSystem
{
    public class PlayerInput : MonoBehaviour
    {
        [SerializeField] private PlayerMovement playerMovement;
        
        private PlayerStateMachine _playerStateMachine;

        public void Construct(PlayerStateMachine playerStateMachine) =>
            _playerStateMachine = playerStateMachine;

        public void Update()
        {
            playerMovement.Move();
            
            if (Input.GetKeyDown(KeyCode.Return))
                _playerStateMachine.ChangeState();
        }
    }
}
