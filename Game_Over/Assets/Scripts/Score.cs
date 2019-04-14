using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public float offset = 46.4f; // added the offset because my x doesn't start at 0 - player.
    public float totalScore;

    // Update is called once per frame
    public void Update()
    {
        //Debug.Log(player.position.x);
        totalScore = player.position.x + offset;
        scoreText.text = totalScore.ToString("0");
    }
}
