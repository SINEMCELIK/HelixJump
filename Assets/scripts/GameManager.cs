using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int score;
    [SerializeField] private Text scoreText;

    public static bool gameOver;
    public static bool levelWin;

    public  GameObject gameOverPanel;
    public  GameObject WinPanel;


     private void Start() 
     {

        Time.timeScale = 1f;
        gameOver = false;
        levelWin = false;
        
    }

    private void Update() 
    {
        if(gameOver)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive (true);
            if(Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene (0);
            }
        }

        if(levelWin)
        {
            WinPanel.SetActive (true);
            if(Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene (0);
            }
        }
        
    }
    
    public void GameScore(int ringScore)
    {
        score += ringScore;
        scoreText.text = score.ToString();    
    }

    
}

