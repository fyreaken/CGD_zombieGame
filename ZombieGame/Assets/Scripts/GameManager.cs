using UnityEngine;
using UnityEngine.UI;
using ​UnityEngine.SceneManagement;

public class​ ​GameManager ​: ​MonoBehaviour
{
    public void ​StartGame()
    {
        SceneManager​.LoadScene(​"Game"​);
    }
    public void ​EndGame()
    {     ​
        SceneManager​.LoadScene(​"Game Over"​);
    }
    public void ​BackToMainMenu()
    {
        SceneManager​.LoadScene(​"Main Menu"​);
    } 
}