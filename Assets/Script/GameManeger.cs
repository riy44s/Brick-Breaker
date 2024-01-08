using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManeger : MonoBehaviour
{
    public int Score = 0;
    public int lives = 3;
    public TextMeshProUGUI livesPoints;
    public TextMeshProUGUI points;
    public TextMeshProUGUI highscoreText;
    public bool gameOver;
    public GameObject gameOverPanel;
    public GameObject winnigPanel;
    public GameObject brick;
    public GameObject paddle;
    public AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    public void IncrementScore()
    {
        Score = Score + 1; 
        points.text = "Score : " + Score;
    }
   
   public void UpdateLives(int changeLives)
    {
        lives += changeLives;
        if (lives <= 0)
        {
            lives = 0;
            GameOver();
        }
        livesPoints.text = "Lives :" + lives;
    }
    void GameOver()
    {
        gameOver = true;
        gameOverPanel.SetActive(true);
        audio.Play();
        int highscore = PlayerPrefs.GetInt("HIGHSCORE");
        if(Score > highscore)
        {
            PlayerPrefs.SetInt("HIGHSCORE",Score);
            highscoreText.text = " New High Score! " + Score;
        }
        else
        {
            highscoreText.text = " High Score " + highscore + "\n" +  " Can you beat it? ";
        }
    }
    public void WinningPanel()
    {
        if (Score <= 25)
        {
            winnigPanel.SetActive(true);
            brick.SetActive(false);
            paddle.SetActive(false);
        }
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Game Over");
    }
    public void startGame()
    {
        SceneManager.LoadScene("Welcome");
    }
}
