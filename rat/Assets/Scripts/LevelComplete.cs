using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel()
    {
        if (SceneManager.GetActiveScene().buildIndex != 2) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        } else 
            SceneManager.LoadScene("MainMenu");
    }
}
