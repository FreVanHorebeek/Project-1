using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private AudioSource finishSound;

    private void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            finishSound.Play();
            string tag = gameObject.tag; // Haal de tag van de finishvlag op

            if (tag == "Vlag 1")
            {
                // Speler heeft de finishvlag met tag "Vlag1" bereikt, laad "Level 2"
                LoadLevel2();
            }
            else if (tag == "Vlag 2")
            {
                // Speler heeft de finishvlag met tag "Vlag2" bereikt, laad "End Screen"
                LoadEndScreen();
            }
        }
    }

    private void LoadLevel2()
    {
        SceneManager.LoadScene("Level 2"); // Laad hier de naam van je "Level 2" scene
    }

    private void LoadEndScreen()
    {
        SceneManager.LoadScene("End Screen"); // Laad hier de naam van je "End Screen" scene
    }
}
