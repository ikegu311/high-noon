﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class shot : MonoBehaviour
{
    public void ClickStartButton()
    {
        TinyAudio.PlaySE(TinyAudio.SE.Magic);
        SceneManager.LoadScene("Clear", LoadSceneMode.Additive);
        Time.timeScale = 0;
    }

}