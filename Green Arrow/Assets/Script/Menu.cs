using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private SpriteRenderer entrance;
    private float sub = .1f;
    private void Start()
    {

        //Destroy(entrance, 2f);
    }

    void Update()
    {
        entrance.color = new Color(0, 0, 0, 1 - sub * Time.deltaTime);
        sub = sub + .1f;
        spaceNext();
    }

    private void spaceNext()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("End Game");
            Application.Quit();
        }

    }
}
