using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    private Image healthBar;
    public float currentHealth;
    private float maxHealth = 100f;
    [SerializeField] GameObject playerPrefab;
    [SerializeField] AudioSource mageKnightDeathSound;
    [SerializeField] GameObject mageKnightDeathEffect;
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
        if (currentHealth <= 0)
        {
            Destroy(playerPrefab);
            mageKnightDeathSound.Play();
            Instantiate(mageKnightDeathEffect, playerPrefab.transform.position, Quaternion.identity);
            Invoke("nextLevel", 2f);
        }
    }

    private void nextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
