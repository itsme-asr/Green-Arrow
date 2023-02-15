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
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            scores.updatePoints();

            //enemyDeathSound.Play();
            GameObject death = Instantiate(deathEffectprefab, transform.position, Quaternion.identity);
            Destroy(other.gameObject, .1f);
            Destroy(death, .3f);
            Destroy(gameObject);
        }
    }

}
