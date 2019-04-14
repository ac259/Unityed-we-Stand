
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            // restart the game
            Invoke("Restart", restartDelay); // Invoke is used to add the delay to the function
            // Takes two parameters - one function name and the other the delay.

        }
    }
    void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    public void CompleteLevel()
    {
        Debug.Log("Level Done!! ");
        completeLevelUI.SetActive(true);
    }
}