using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MainMenu : MonoBehaviour
{
    // Activated by pressing the play button in the main menu.
    public void PlayGame1()
    {
        // Day 1
        SceneManager.LoadScene("Day1");
    }

    public void PlayGame2()
    {
        // Day 2
        SceneManager.LoadScene("Day2");
    }

    public void PlayGame3()
    {
        // Day 3
        SceneManager.LoadScene("Day3");
    }

    public void PlayGame4()
    {
        // Day 4
        SceneManager.LoadScene("Day4");
    }

    public void PlayGame5()
    {
        // Day 5
        SceneManager.LoadScene("Day5");
    }

    public void PlayGame6()
    {
        // Day 6
        SceneManager.LoadScene("Day6");
    }

    public void PlayGame7()
    {
        // Day 7
        SceneManager.LoadScene("Day7");
    }

    // Activated by pressing the quit button in the main menu.
    public void QuitGame()
    {
        Application.Quit();
    }
}
