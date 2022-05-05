using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    bool gamehasEnded = true;

    public GameObject GameOverPanel;
    public void GameOver()

    {

        if (gamehasEnded == true)

        {
            gamehasEnded = true;
            GameOverPanel.SetActive(true);
            Restart();

            void Restart()
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
	public GameObject LevelCompletedPanel;


    public void LevelComplete()

    {
        LevelCompletedPanel.SetActive(true);
    }
}