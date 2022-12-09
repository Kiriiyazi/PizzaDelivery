using UnityEngine;
using UnityEngine.SceneManagement;

public class Pizza : MonoBehaviour
{
    private float _restartGame = 3f;
    private void Update()
    {
        _restartGame -= Time.deltaTime;
        if (_restartGame < 0 )
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
