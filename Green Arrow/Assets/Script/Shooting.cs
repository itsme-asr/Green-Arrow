using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject fireBallPreFab;
    [SerializeField] private float fireBallSpeed = 10f;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        GameObject fireBalls = Instantiate(fireBallPreFab, firePoint.position, Quaternion.identity);
        Rigidbody2D rb = fireBalls.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * fireBallSpeed, ForceMode2D.Impulse);
    }
}
