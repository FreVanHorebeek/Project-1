using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOverScreen : MonoBehaviour
{
    [SerializeField] private Text highscoreText;

    public Text pointsText;
    public void Setup(int score)
    {
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + " POINTS";
    }
    private void Start()
    {
        // Toon de highscore op het "Game Over" scherm
        highscoreText.text = "Highscore: " + GameManager.Instance.GetHighscore();
    }

}
