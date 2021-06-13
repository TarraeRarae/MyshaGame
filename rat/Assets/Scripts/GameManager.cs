using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;
    private float timeToWait = 3.5f;
    public GameObject pause;
    public GameObject gameObjUIEn;
    public GameObject gameObjUIDis;

    public void Death()
    {
        if (!gameHasEnded)
        {
            FindObjectOfType<Player>().enabled = false;
            Invoke("Restart", timeToWait);

        }
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        FindObjectOfType<Player>().enabled = false;
        pause.SetActive(true);
        FindObjectOfType<unPause>().enabled = true;
    }

    public void UnPause()
    {
        FindObjectOfType<unPause>().enabled = false;
        pause.SetActive(false);
        Time.timeScale = 1f;
        FindObjectOfType<Player>().enabled = true;
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LevelComplete()
    {
        gameObjUIDis.SetActive(false);
        gameObjUIEn.SetActive(true);
    }

}
