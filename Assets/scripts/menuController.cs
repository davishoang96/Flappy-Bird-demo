﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuController : MonoBehaviour {


    public void playButton()
    {
        Application.LoadLevel("flappybird test");
        //SceneManager.LoadScene("flappybird test");
    }
}
