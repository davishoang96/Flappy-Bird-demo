using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour {

    public static gameManager instance;
    public const string highScore = "High Score";


	// Use this for initialization
	void Awake()
    {
        makeSingleInstance();
        firstDownload();
    }

    void firstDownload()
    {
        if(!PlayerPrefs.HasKey("firstDownload"))
        {
            PlayerPrefs.SetInt(highScore, 0);
            PlayerPrefs.SetInt("firstDownload", 0);
        }
    }
    void makeSingleInstance()
    {
        if(instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void setHighscore(int score)
    {
        PlayerPrefs.SetInt(highScore, score);
    }
    public int getHighscore()
    {
        return PlayerPrefs.GetInt(highScore);
    }
}
