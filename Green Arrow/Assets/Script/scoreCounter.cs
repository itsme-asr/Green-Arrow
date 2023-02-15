using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreCounter : MonoBehaviour
{
    private int point = 0;
    [SerializeField] private Text textPoints;
    [SerializeField] private AudioSource audioPoints;

    private void Update()
    {
        updatePoints();
    }

    public void updatePoints()
    {
        point++;
        textPoints.text = point.ToString();
    }
}
