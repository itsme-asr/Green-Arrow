using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireBalls : MonoBehaviour
{
    //private int point = 0;
    //[SerializeField] private Text textPoints;
    [SerializeField] GameObject deathEffectprefab;
    scoreCounter scores;
    //[SerializeField] AudioSource enemyDeathSound;

    private void Start()
    {
        //scores = FindObjectOfType<scoreCounter>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            //enemyDeathSound.Play();
            GameObject death = Instantiate(deathEffectprefab, transform.position, Quaternion.identity);
            Destroy(other.gameObject, .1f);
            Destroy(death, .3f);
            Destroy(gameObject);
            scores.point++;
            PlayerPrefs.SetInt("highscore", scores.point);
            //scores.updatePoints();
        }
    }

}
