using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBalls : MonoBehaviour
{
    [SerializeField] GameObject deathEffectprefab;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            GameObject death = Instantiate(deathEffectprefab, transform.position, Quaternion.identity);
            Destroy(other.gameObject, .1f);
            Destroy(death, .3f);
            Destroy(gameObject);
        }
    }

}
