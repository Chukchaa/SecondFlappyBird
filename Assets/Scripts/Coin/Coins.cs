using FlappyBird.Core;
using UnityEngine;

namespace Coin.Coins
{
    public class Coins
    {
        private PlayerContactsPoint _contactsPoint;
        private WalletData _walletData;
        private int _coinCount = 1;

        public Coins(GameState gameState)
        {
            _walletData = gameState.Wallet;
        }

        public void Initialize(PlayerContactsPoint contactsPoint)
        {
            _contactsPoint = contactsPoint;
            _contactsPoint.CointCollected += ScorringCoin;
        }


        private void ScorringCoin()
        {
            Debug.Log($"{nameof(Coins)}. {nameof(ScorringCoin)}. Монета прибавлена");
            _walletData.AddCoins(_coinCount);
        }
    }
}
