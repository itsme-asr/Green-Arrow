using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private int playerSpeed = 7;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] Camera cam;
    [SerializeField] public float playerHealth = 100f;
    private float inputAxisX;
    private float inputAxisY;
    private Vector2 movAxis;
    private Vector2 mousePos;
    private void Update()
    {
        movement();
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 look = mousePos - rb.position;
        float angle = Mathf.Atan2(look.y, look.x) * Mathf.Rad2Deg + 90f;
        rb.rotation = angle;
    }



    private void movement()
    {
        // input values for X and Y Axis;
        inputAxisX = Input.GetAxisRaw("Horizontal");
        inputAxisY = Input.GetAxisRaw("Vertical");

        movAxis = new Vector2(inputAxisX, inputAxisY);
        //movAxis.Normalize();

        rb.velocity = movAxis * playerSpeed;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        playerHealth = playerHealth - 5;
    }
}
