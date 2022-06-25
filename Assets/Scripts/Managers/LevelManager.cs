using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;
    [SerializeField] private BallManager powerReset;

    void Start()
    {
        gameOver = false;

    }

    void Update()
    {
        if(gameOver == true)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);

        }
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level 1");

    }
    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level 2");

    }
    public void LoadLevel3()
    {
        SceneManager.LoadScene("Level 3");

    }
    public void LoadLevel4()
    {
        SceneManager.LoadScene("Level 4");

    }
    public void LoadLevel5()
    {
        SceneManager.LoadScene("Level 5");

    }
   
     public void QuitGame()
    {
        Application.Quit();
    }
}
