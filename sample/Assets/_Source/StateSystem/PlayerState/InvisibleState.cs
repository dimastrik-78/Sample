using UnityEngine;

namespace _Source.StateSystem.PlayerState
{
    public class InvisibleState : APlayerState
    {
        private SpriteRenderer _spriteRenderer;

        public InvisibleState(PlayerStateMachine owner, SpriteRenderer spriteRenderer) : base(owner)
        {
            _spriteRenderer = spriteRenderer;
        }
        
        public override void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                if (_spriteRenderer.color.a == 1)
                {
                    _spriteRenderer.color = new Color(_spriteRenderer.color.r, _spriteRenderer.color.g, _spriteRenderer.color.b, 0.5f);
                }
                else
                {
                    _spriteRenderer.color = new Color(_spriteRenderer.color.r, _spriteRenderer.color.g, _spriteRenderer.color.b, 1);
                }
            }

        }
    }
}