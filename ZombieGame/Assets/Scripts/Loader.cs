using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{
    public void TestLevel()
    {
        SceneManager.LoadScene("TestLevel");
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Level1");
    }
    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
    public void GameWin()
    {
        SceneManager.LoadScene("GameWin");
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Controls()
    {
        SceneManager.LoadScene("Controls");
    }
}
