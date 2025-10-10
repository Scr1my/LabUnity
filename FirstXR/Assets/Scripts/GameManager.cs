using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] public GameObject door;
    [SerializeField] public GameObject menuUI;
    [SerializeField] public AudioSource BGMusic;
    void Start()
    {
        BGMusic.Play();
        PlayerPrefs.SetInt("score", 0);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
