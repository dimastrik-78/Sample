using System;
using System.Collections.Generic;
using _Source.PlayerSystem;
using _Source.StateSystem.GameState;
using _Source.StateSystem.PlayerState;
using UnityEngine;

namespace _Source.StateSystem
{
    public class Initializer
    {
        public void PlayerState(out Dictionary<int, APlayerState> states, PlayerStateMachine owner,
            GameObject prefabBullet, Transform spawnPointBullet,
            GameObject aura,
            SpriteRenderer playerSprite)
        {
            states = new Dictionary<int, APlayerState>
            {
                { 0, new ShootState(owner, prefabBullet, spawnPointBullet) },
                { 1, new RedAura(owner, aura) },
                { 2, new InvisibleState(owner, playerSprite) }
            };
        }
        
        public void GameState(out Dictionary<Type, AGameState> states, GameStateMachine owner, 
            PlayerInput playerInput, 
            GameObject aura, SpriteRenderer playerSprite)
        {
            states = new Dictionary<Type, AGameState>
            {
                { typeof(Game), new Game(owner, playerInput) },
                { typeof(Pause), new Pause(owner) },
                { typeof(Final), new Final(owner, aura, playerSprite) }
            };
        }
    }
}