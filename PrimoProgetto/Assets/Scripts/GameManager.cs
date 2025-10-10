using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    //public GameObject atomPrefab;
    //[SerializeField] Vector3 initAtomPos;
    [SerializeField] private AudioSource BGMusicSource;
    [SerializeField] private AudioSource SFXSource;
    [SerializeField] private AudioClip BGMusic;
    [SerializeField] private AudioClip coinSound;
    private int coins;

    [SerializeField] private TextMeshProUGUI coinCounter;
    [SerializeField] private GameObject winGUI;

    void Start()
    {
        //Instantiate(atomPrefab, initAtomPos, Quaternion.identity);
        coins = 0;
        BGMusicSource.clip = BGMusic;
        BGMusicSource.Play();
    }

    public void UpdateScore()
    {
        coins++;
        coinCounter.text = "Coins: " + coins;
    }

    public void PlayCoinSFX()
    {
        PlaySFX(coinSound);
    }

    private void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }

    public void TeleportToStart(GameObject player)
    {
        player.transform.position = new Vector3(0, 0, -4);
    }

    public void Win()
    {
        StartCoroutine(Restart());
    }

    IEnumerator Restart()
    {
        winGUI.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Main Menu");
    }
}
