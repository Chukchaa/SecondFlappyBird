using UnityEngine;
using TMPro;
using FlappyBird.Core;
using VContainer;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverPanel;
    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private TextMeshProUGUI _resourcePanelText;
    [SerializeField] private Button _restartButton;
    [SerializeField] private GameObject _menuPanel;
    [SerializeField] private Button _startButton;

    private PlayerContactsPoint _contactsPoint;
    private WalletData _coins;

    [Inject]
    public void Construct(GameState gameState)
    {
        _coins = gameState.Wallet;
        _restartButton.onClick.AddListener(CloseGameOverPanel);
        _startButton.onClick.AddListener(StartGame);
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
        _resourcePanelText.text = _coins.Coins.ToString();
    }

    private void StartGame()
    {
        _menuPanel.SetActive(false);
    }

    private void GameOver()
    {
        _scoreText.gameObject.SetActive(false);
        _gameOverPanel.SetActive(true);
    }

    private void CloseGameOverPanel()
    {
        SceneManager.LoadScene(0);
        _gameOverPanel.SetActive(false);
    }
}
