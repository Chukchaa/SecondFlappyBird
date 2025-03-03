using UnityEngine;
using TMPro;
using Coin.Coins;
using FlappyBird.Core;
using VContainer;

public class UI : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverPanel;
    [SerializeField] private PlayerContactsPoint _contactsPoint;
    [SerializeField] private TextMeshProUGUI _scoreText;

    private WalletData _coins;

    [Inject]
    public void Construct(GameState gameState)
    {
        _coins = gameState.Wallet;   
    }

    public void Initialize(PlayerContactsPoint contactsPoint)
    {
        _contactsPoint = contactsPoint;
        _contactsPoint.BirdDestroyed += GameOver;
        _contactsPoint.CointCollected += CoinCollect;
    }

    private void CoinCollect()
    {
        _scoreText.text = _coins.Coins.ToString();
    }

    private void GameOver()
    {
        _gameOverPanel.SetActive(!_gameOverPanel.activeSelf);
    }
}
