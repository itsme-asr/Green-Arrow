using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    [SerializeField] Text hscore;

    private void Start()
    {
        hscore.text = " " + PlayerPrefs.GetInt("highscore");
    }
}
