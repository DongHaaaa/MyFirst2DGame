using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public int score;
    public static GameManager instance;

    private void Awake()
    {
        instance = this;
        score = 0;
        scoreText.text = "Score: 0";
    }
    public void UpdateScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }
}
