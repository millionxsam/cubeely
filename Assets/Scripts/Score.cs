using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{

    public Transform player;
    public Text score;

    // Update is called once per frame
    void Update()
    {
        if(!(FindObjectOfType<GameManager>().gameEnded)) {
            score.text = player.position.z.ToString("0");
        }
    }
}
