using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreCounter : MonoBehaviour
{
    public int point = 0;
    [SerializeField] public Text textPoints;
    [SerializeField] private AudioSource audioPoints;


    public void updatePoints()
    {
        //point++;
        textPoints.text = " " + PlayerPrefs.GetInt("highscore");
        Debug.Log("Score");
    }
}
