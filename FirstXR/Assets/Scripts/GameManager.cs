using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public GameObject door;
    [SerializeField] public AudioSource BGMusic;
    void Start()
    {
        BGMusic.Play();
        PlayerPrefs.SetInt("score", 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
