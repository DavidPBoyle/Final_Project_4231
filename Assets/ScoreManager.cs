using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text victoryText;
    public static int score = 0;
    public static int scoreUp = 0;

    void Update()
    {
        if (scoreUp == 1)
        {
            score++;

            scoreText.text = "Score: " + score;
            scoreUp--;

        }

        if (score == 5)
            {   
                victoryText.fontSize = 14;
                if (Input.GetKeyDown(KeyCode.R))
                {
                    score = 0;
                    victoryText.fontSize = 1;
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                }
            }
    }
}