using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    private Image healthBar;
    public float currentHealth;
    private float maxHealth = 100f;
    PlayerMove player;

    private void Start()
    {
        healthBar = GetComponent<Image>();
        player = FindObjectOfType<PlayerMove>();
    }

    private void Update()
    {
        currentHealth = player.playerHealth;
        healthBar.fillAmount = currentHealth / maxHealth;
    }
}
