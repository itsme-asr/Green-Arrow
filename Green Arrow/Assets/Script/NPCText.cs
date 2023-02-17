using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCText : MonoBehaviour
{
    [SerializeField] GameObject mageKnight;
    [SerializeField] GameObject dialoguePanel;
    [SerializeField] Text dialogueText;
    [SerializeField] string[] dialogue;
    private int index;
    [SerializeField] GameObject contButton;
    [SerializeField] float wordSpeed;
    [SerializeField] bool playerIsClose;
    private void Start()
    {
        dialogueText.text = " ";
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && playerIsClose)
        {
            if (dialoguePanel.activeInHierarchy)
            {
                zeroText();
            }
            else
            {
                dialoguePanel.SetActive(true);
                StartCoroutine(typing());
            }
        }

        if (dialogueText.text == dialogue[index])
        {
            contButton.SetActive(true);
        }

    }
    public void zeroText()
    {
        dialogueText.text = " ";
        index = 0;
        dialoguePanel.SetActive(false);
    }

    IEnumerator typing()
    {
        foreach (char letter in dialogue[index].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(wordSpeed);

        }
    }

    public void nextLine()
    {

        contButton.SetActive(false);
        if (index < dialogue.Length - 1)
        {
            index++;
            dialogueText.text = " ";
            StartCoroutine(typing());
        }
        else
        {
            zeroText();
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = false;
            zeroText();
        }
    }
}
