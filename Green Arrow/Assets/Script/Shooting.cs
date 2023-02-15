using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject fireBallPreFab;
    [SerializeField] private GameObject multiFireBallPrefab;
    [SerializeField] private Transform[] multiFirePoint;
    [SerializeField] private float fireBallSpeed = 10f;
    [SerializeField] AudioSource fireballWhoosh;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            fireballWhoosh.Play();
            Shoot();
        }

        if (Input.GetMouseButtonDown(1))
        {
            specialSkill();
            //Debug.Log("Special Power");
        }
    }

    private void Shoot()
    {
        GameObject fireBalls = Instantiate(fireBallPreFab, firePoint.position, Quaternion.identity);
        Rigidbody2D rb = fireBalls.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * fireBallSpeed, ForceMode2D.Impulse);
    }

    private void specialSkill()
    {
        for (int i = 0; i < multiFirePoint.Length; i++)
        {
            GameObject multifireBalls = Instantiate(multiFireBallPrefab, multiFirePoint[i].position, Quaternion.identity);
            Rigidbody2D rb2 = multifireBalls.GetComponent<Rigidbody2D>();
            rb2.AddForce(multiFirePoint[i].up * fireBallSpeed, ForceMode2D.Impulse);
            Destroy(multifireBalls, 1f);
        }
    }
}
