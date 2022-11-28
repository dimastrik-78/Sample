using UnityEngine;

namespace _Source.StateSystem.PlayerState
{
    public class ShootState : APlayerState
    {
        private GameObject _gameObject;
        private Transform _transform;
        
        public ShootState(PlayerStateMachine owner, GameObject gameObject, Transform transform) : base(owner)
        {
            _gameObject = gameObject;
            _transform = transform;
        }

        public override void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Object.Instantiate(_gameObject, _transform);
            }
        }
    }
}