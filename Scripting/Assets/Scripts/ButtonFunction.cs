using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonFunction : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ButtonQuits()
    {
        Application.Quit();
    }

}
