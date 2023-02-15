using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddHealth : MonoBehaviour
{
    PlayerMove player;
    [SerializeField] GameObject healthEffect;

    private void Start()
    {
        player = FindObjectOfType<PlayerMove>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {

            GameObject healthAddEffect = Instantiate(healthEffect, transform.position, Quaternion.identity);
            player.playerHealth = player.playerHealth + 45f;
            Destroy(healthAddEffect, .3f);
            Destroy(gameObject, .5f);
        }
    }
}
