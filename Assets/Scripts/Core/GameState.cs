using Unity.VisualScripting;
using UnityEngine;

namespace FlappyBird.Core
{
    public sealed class GameState
    {
        public WalletData Wallet { get; set; }
        public CharacterData Character { get; set; }

        public GameState()
        {
            Wallet = new WalletData();
            Character = new CharacterData();
        }
    }
}

