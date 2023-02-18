using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreCounter : MonoBehaviour
{
    //[SerializeField] public Text textPoints;
    //[SerializeField] private AudioSource audioPoints;

    private int scorePoints;
    public int ScorePoints
    {
        get
        { return scorePoints; }
        set
        {
            scorePoints = value;
            GetComponent<Text>().text = " " + scorePoints;
            PlayerPrefs.SetInt("highscore", scorePoints);
        }
    }

}
