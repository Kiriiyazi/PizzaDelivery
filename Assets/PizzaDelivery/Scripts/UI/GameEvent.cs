using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEvent : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverWindows;
    [SerializeField] private GameObject _gameVictoryWindows;
    [SerializeField] private GameObject _joystick;
    [SerializeField] private HealthBar _healthBar;
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        _player.Died += OnDied;
    }

    private void OnDisable()
    {
        _player.Died -= OnDied;
    }


    private void OnDied()
    {
        Time.timeScale = 0;
        _healthBar.gameObject.SetActive(false);
        _gameOverWindows.SetActive(true);
        _joystick.SetActive(false);
    }

    public void OnVictory()
    {
        Time.timeScale = 0;
        _healthBar.gameObject.SetActive(false);
        _gameVictoryWindows.SetActive(true);
        _joystick.SetActive(false);
    }


    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
    
    public void ExiGame()
    {
        Application.Quit();
    }
}
