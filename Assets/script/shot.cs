﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class shot : MonoBehaviour
{
    public int num = 1;
    public void ClickStartButton()
    {
        num = 2;
        TinyAudio.PlaySE(TinyAudio.SE.Magic);
        SceneManager.LoadScene("Clear", LoadSceneMode.Additive);
    }

}