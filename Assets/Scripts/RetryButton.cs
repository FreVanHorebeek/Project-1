using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour
{
    public void RestartGame()
    {
        
        SceneManager.LoadScene("Level 1"); 
    }
}