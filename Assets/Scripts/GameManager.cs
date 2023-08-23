using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public bool gameEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLvlUI;

    public PlayerMovement movement;

    public void CompleteLevel()
    {
        movement.enabled = false;
        completeLvlUI.SetActive(true);
    }

    public void EndGame() {
        if(gameEnded == false) {    
            gameEnded = true;

            Invoke("Restart", restartDelay);
        }
    }

    void Restart () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
