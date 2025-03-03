using UnityEngine;

namespace FlappyBird.Character
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer _spriteRenderer;
        [SerializeField] private PlayerContactsPoint _playerContactsPoint;

        public PlayerContactsPoint PlayerContactsPoint => _playerContactsPoint;

        public void ChangeSprite(Sprite sprite)
        {
            _spriteRenderer.sprite = sprite;
        }
    }
}
