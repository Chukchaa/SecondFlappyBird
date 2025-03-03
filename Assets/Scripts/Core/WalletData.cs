using UnityEngine;

namespace FlappyBird.Core
{
    public class WalletData
    {
        public int Coins;

        public void AddCoins(int coins)
        {
            if(CheckValue(coins))
            {
                Coins += coins;
            }
        }

        public void RemoveCoins(int coins)
        {
            if (CheckValue(coins))
            {
                Coins -= coins;
            }
        }

        private bool CheckValue(int coins)
        {
            if (coins < 0)
            {
                Debug.LogError($"{nameof(WalletData)}. {nameof(CheckValue)}." +
                    $" Значение не может быть {coins}");
                return false;
            }

            return true;
        }
    }
}

