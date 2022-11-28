using System;
using _Source.StateSystem.PlayerState;
using UnityEngine;
using UnityEngine.UI;

namespace _Source.UISystem
{
    public class PlayerStates : MonoBehaviour
    {
        [SerializeField] private Text textState;

        private void OnEnable() =>
            PlayerStateMachine.OnChangeState += ChangeState;

        private void OnDisable() =>
            PlayerStateMachine.OnChangeState -= ChangeState;

        private void ChangeState(Type type) =>
            textState.text = $"{type.Name}";
    }
}
