using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    public GameObject MainMenu;

    public void Main_Menu()
    {
    
    }

    public void Play()
    {
        Debug.Log("Starting Game");
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
     Application.Quit();
    }
}
