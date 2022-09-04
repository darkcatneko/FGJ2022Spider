using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingButton : MonoBehaviour
{
    public GameObject Manuel;
    public void EndGame()
    {
        Application.Quit();
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void StartGame()
    {
        Manuel.SetActive(false);
        Timer.instance.state = GameState.Start;
    }
}
