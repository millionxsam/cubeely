using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlCompleteScript : MonoBehaviour
{
    public void LoadLvl()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
