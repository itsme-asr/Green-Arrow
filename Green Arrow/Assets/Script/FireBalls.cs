using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireBalls : MonoBehaviour
{

    [SerializeField] GameObject deathEffectprefab;



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
            GameObject.Find("Score").transform.GetComponent<scoreCounter>().ScorePoints += 1;

        }
    }

}
