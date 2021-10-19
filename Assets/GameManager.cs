using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public bool gameIsEnded = false;
    public Rotator rotator;
    public Spawner spawner;

    public Animator animator;
    public void GameOver()
    {
        if (gameIsEnded)
            return;

        rotator.enabled = false;
        spawner.enabled = false;
        gameIsEnded = true;

        animator.SetTrigger("GameOver");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
