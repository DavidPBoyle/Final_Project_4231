using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    public Text scoreText;
    public Text lossText;
    public static int health = 0;
    public static int healthDown = 0;

    void Update()
    {
        if (healthDown == 1)
        {
            health--;
            scoreText.text = "Health: " + health;
            healthDown--;
        }

        if (health == 0)
        {
                lossText.fontSize = 14;
                if (Input.GetKeyDown(KeyCode.R))
                {
                    lossText.fontSize = 1;
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                }
        }
    }
}
