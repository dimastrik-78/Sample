using System;
using System.Collections.Generic;
using _Source.PlayerSystem;
using UnityEngine;

namespace _Source.StateSystem.GameState
{
    public class GameStateMachine
    {
        private Dictionary<Type, AGameState> _states;
        private AGameState _currentGameState;
        private Initializer _initializer;

        public Type State;
        
        public GameStateMachine(PlayerInput playerInput, GameObject aura, SpriteRenderer playerSprite)
        {
            _initializer = new Initializer();
            
            _initializer.GameState(out _states, this, playerInput, aura, playerSprite);
        }

        public void ChangeState(Type type)
        {
            State = type;
            
            _currentGameState?.Exit();
            _currentGameState = _states[type];
            _currentGameState.Enter();
        }

        public void Update()
        {
            _currentGameState.Update();
        }
    }
}