using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int cherries = 0;
    private int highscore = 0;

    public static GameManager Instance { get; private set; }

    [SerializeField] private Text highscoreText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void CollectCherry()
    {
        cherries++;
    }

    public int GetCherriesCollected()
    {
        return cherries;
    }

    public void ResetCherries()
    {
        cherries = 0;
    }

    public void UpdateHighscore()
    {
        if (cherries > highscore)
        {
            highscore = cherries;
        }
    }

    public int GetHighscore()
    {
        return highscore;
    }
}
