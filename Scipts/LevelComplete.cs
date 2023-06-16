using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel()
    {
        StartCoroutine(LoadNextLevelDelayed());
    }

    private IEnumerator LoadNextLevelDelayed()
    {
        yield return new WaitForSeconds(2.0f); // Zpoždìní po dobu 2 sekund

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

