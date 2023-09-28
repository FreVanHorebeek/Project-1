using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private Text cherriesText;
    [SerializeField] private AudioSource collectionSoundEffect;

    private void Start()
    {
        UpdateCherriesText();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);

            // Verzamel de kers en update de cherries in het GameManager
            GameManager.Instance.CollectCherry();
            GameManager.Instance.UpdateHighscore();
            UpdateCherriesText();
        }
    }

    private void UpdateCherriesText()
    {
        cherriesText.text = "Cherries: " + GameManager.Instance.GetCherriesCollected();
    }
}
