using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;

    public void UpdateScore()
    {
        PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score") + 1);
        scoreText.text = "Score: " + PlayerPrefs.GetInt("score");
    }
}
