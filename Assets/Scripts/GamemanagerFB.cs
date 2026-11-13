using UnityEngine;
using UnityEngine.SceneManagement;
public class GamemanagerFB : MonoBehaviour
{
    [SerializeField] private GameObject _gameOver;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject pipespawn;
    [SerializeField] private GameObject _gameStart;
    [SerializeField] private GameObject _scoreText;
    void Awake()
    {
        _gameOver.SetActive(false);
        pipespawn.SetActive(false);
        _gameStart.SetActive(true);
        _scoreText.SetActive(false);
        player.GetComponent<Rigidbody2D>().simulated = false;
    }    
    bool hasGameStarted = false;
    void Update()
    {
        if(!hasGameStarted && (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)))
        {
            _gameStart.SetActive(false);
            hasGameStarted = true;
            pipespawn.SetActive(true);
            _scoreText.SetActive(true);
            player.GetComponent<Rigidbody2D>().simulated = true;
        }
    }
    public void GameOver()
    {
        _gameOver.SetActive(true);
        Time.timeScale = 0;
    }
    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("FlappyBird");
    }
}
