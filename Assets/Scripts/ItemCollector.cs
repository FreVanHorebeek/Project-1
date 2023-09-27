using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int cherries = 0;

    [SerializeField] private Text cherriesText;
    [SerializeField] private AudioSource collectionSoundEffect;

    private void Start()
    {
        // Lees het aantal verzamelde kersen uit PlayerPrefs voor het huidige level
        cherries = PlayerPrefs.GetInt("Cherries", 0);
        UpdateCherriesText();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            cherries++;
            Debug.Log("Cherries: " + cherries);

            // Sla het aantal verzamelde kersen op in PlayerPrefs voor het huidige level
            PlayerPrefs.SetInt("Cherries", cherries);
            PlayerPrefs.Save();

            UpdateCherriesText();
        }
    }

    private void UpdateCherriesText()
    {
        cherriesText.text = "Cherries: " + cherries;
    }
}
