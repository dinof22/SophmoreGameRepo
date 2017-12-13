using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour {

    public GameObject StartMenu, OptionsMenu, QuitScreen, PauseMenu;



    public void CloseOptions()
    {
        OptionsMenu.SetActive(false);
    }
    public void OpenOptions()
    {
        OptionsMenu.SetActive(true);
    }


    public void OpenStartMenu()
    {
        StartMenu.SetActive(true);
    }

    public void CloseStartMenu()
    {
        StartMenu.SetActive(false);
    }


    public void ShowQuitScreen()
    {
        QuitScreen.SetActive(true);
    }


    public void ClosePauseMenu()
    {
        Time.timeScale = 1;
        PauseMenu.SetActive(false);
    }



}
