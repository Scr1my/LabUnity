using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI highscore;
    [SerializeField] private AudioSource BGmusic;
    void Start()
    {
        if (PlayerPrefs.HasKey("highScore"))
        {
            if (PlayerPrefs.GetInt("highScore") < PlayerPrefs.GetInt("score"))
            {
                PlayerPrefs.SetInt("highScore", PlayerPrefs.GetInt("score"));
            }
        }
        else
        {
            if (PlayerPrefs.HasKey("highScore") && PlayerPrefs.GetInt("score") > 0)
            {
                PlayerPrefs.SetInt("highScore", PlayerPrefs.GetInt("score"));
            }
            else
            {
                PlayerPrefs.SetInt("highScore", 0);
            }
        }
        Debug.Log(PlayerPrefs.GetInt("highScore"));
        highscore.text = "HighScore \n" + PlayerPrefs.GetInt("highScore");

        BGmusic.Play();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
