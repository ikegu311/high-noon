﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Clear3 : MonoBehaviour
{
    public void ClickStartButton()
    {
        SceneManager.LoadScene("Title");
    }
}