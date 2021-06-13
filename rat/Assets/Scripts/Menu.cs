using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject menuShow;
    public GameObject choiceLevelShow;

    public void StartTheGame()
    {
        SceneManager.LoadScene(1);
    }


    public void ExitGame()
    {
        Application.Quit();
    }

    public void ChooseLevel()
    {
        if (menuShow.activeSelf)
        {
            menuShow.SetActive(false);
            choiceLevelShow.SetActive(true);
        } else
        {
            choiceLevelShow.SetActive(false);
            menuShow.SetActive(true);
        }
    }

    public void LoadLevel(int numOfLevel)
    {
        SceneManager.LoadScene(numOfLevel);
    }

}
