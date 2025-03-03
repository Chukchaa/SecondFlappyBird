using Coin.Coins;
using FlappyBird.Core;
using UnityEngine;
using VContainer;

namespace FlappyBird.Character
{
    public class InitCharacter : MonoBehaviour
    {
        [SerializeField] private Player _player;

        private Player _characterObject;
        private GameState _gameState;

        [Inject]
        public void Construct(GameState gameState, CharacterConfigBase characterConfigBase, UI ui, Coins coins)
        {
            _gameState = gameState;
            ChatacterCreation(characterConfigBase);
            coins.Initialize(_characterObject.PlayerContactsPoint);
            ui.Initialize(_characterObject.PlayerContactsPoint);
        }

        public void ChatacterCreation(CharacterConfigBase characterConfigBase)
        {
            _characterObject = Instantiate(_player, transform.position, Quaternion.identity);
            _characterObject.ChangeSprite(characterConfigBase.GetConfig(_gameState.Character.SkinIdentifier).Sprite);
        }
    }
}

