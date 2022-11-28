using UnityEngine;

namespace _Source.StateSystem.PlayerState
{
    public class RedAura : APlayerState
    {
        private GameObject _aura;

        public RedAura(PlayerStateMachine owner, GameObject aura) : base(owner)
        {
            _aura = aura;
        }
        
        public override void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                if (!_aura.activeSelf)
                    _aura.SetActive(true);
                else
                {
                    _aura.SetActive(false);
                }
            }
        }
    }
}