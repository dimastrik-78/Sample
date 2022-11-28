using UnityEngine;

namespace _Source.StateSystem.GameState
{
    public class Final : AGameState
    {
        private SpriteRenderer _playerSprite;
        private GameObject _aura;
        
        public Final(GameStateMachine owner, GameObject aura, SpriteRenderer playerSprite) : base(owner)
        {
            _aura = aura;
            _playerSprite = playerSprite;
        }

        public override void Enter()
        {
            _aura.SetActive(false);
            _playerSprite.color = Color.green;
        }
    }
}