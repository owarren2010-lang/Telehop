using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    public GameObject PlayMenu, optionMenu, ExitMenu;
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
    optionMenu.SetActive(false);
    PlayMenu.SetActive(true);
    }

    

}
