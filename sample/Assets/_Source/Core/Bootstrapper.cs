using _Source.PlayerSystem;
using _Source.StateSystem.GameState;
using _Source.StateSystem.PlayerState;
using UnityEngine;

namespace _Source.Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private PlayerInput playerInput;
        [SerializeField] private GameObject prefabBullet;
        [SerializeField] private Transform spawnPointBullet;
        [SerializeField] private GameObject aura;
        [SerializeField] private SpriteRenderer playerSprite;
        
        private PlayerStateMachine _playerStateMachine;
        private GameStateMachine _gameStateMachine;

        private void Start()
        {
            _playerStateMachine = new PlayerStateMachine(prefabBullet, spawnPointBullet, aura, playerSprite);
            _gameStateMachine = new GameStateMachine(playerInput, aura, playerSprite);
            
            playerInput.Construct(_playerStateMachine);
            
            _gameStateMachine.ChangeState(typeof(Game));
        }

        private void Update()
        {
            _gameStateMachine.Update();
            
            if (_gameStateMachine.State == typeof(Game))
                _playerStateMachine.Update();
        }
    }
}
