using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameplayController : MonoBehaviour {

    public static gameplayController instance;

    [SerializeField]
    private Button instructionbutton;

    [SerializeField]
    private Text scoreText,endScoreText,bestScoreText;

    [SerializeField]
    private GameObject gameOverPanel;

    void Awake()
    {
        Time.timeScale = 0;
        makeInstance();
    }

    void makeInstance()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    public void instructionButton()
    {
        Time.timeScale = 1;
        instructionbutton.gameObject.SetActive(false);
    }

    public void _setScore(int score)
    {
        scoreText.text = "" + score;
    }

    public void showPanel(int score)
    {
        gameOverPanel.SetActive(true);
        endScoreText.text = "" + score;
        if(score > gameManager.instance.getHighscore())
        {
            gameManager.instance.setHighscore(score);
        }
        bestScoreText.text = "" + gameManager.instance.getHighscore();
    }
    public void menuButton()
    {
        Application.LoadLevel("menu");
        //SceneManager.LoadScene("flappybird test");
    }
    public void resetButton()
    {
        Application.LoadLevel("flappybird test");
        //SceneManager.LoadScene("flappybird test");
    }
}
