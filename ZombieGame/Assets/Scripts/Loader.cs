using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Zombie Shooter Level 1");
    }
    public void EndGame()
    {
        SceneManager.LoadScene("GameOver");
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
