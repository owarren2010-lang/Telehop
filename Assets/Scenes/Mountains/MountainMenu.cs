using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MountainMenu : MonoBehaviour
{
    public GameObject PlayMenu, ExitMenu;
    public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }
    /* public void OptionButton()
     {
         optionMenu.SetActive(true);
         mainMenu.SetActive(false);
     }*/

    public void ExitButton()
    {
        ExitMenu.SetActive(false);
        PlayMenu.SetActive(true);
    }
}
