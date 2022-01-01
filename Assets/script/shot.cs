using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class shot : MonoBehaviour
{
    int number = CreateRandomPosition.dead;
    public void ClickStartButton()
    {
        number = number + 1;
    }
}