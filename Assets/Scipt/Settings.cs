using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    public GameObject SettingCanvas,MainMenu;
    public void Main_Menu()
    {
        Debug.Log("Clicked on Settings");
        MainMenu.SetActive(false);
        SettingCanvas.SetActive(true);
    }
    public void Play()
    {
       
    }

    public void Exit()
    {
        Debug.Log("Fine, leave. Didn't want you to stay"); 
        MainMenu.SetActive(true);
        SettingCanvas.SetActive(false);
    }
}
