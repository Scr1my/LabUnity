using UnityEngine;

public class ButtonInteractions : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    private GameObject door;
    private GameObject menuUI;
    void Start()
    {
        door = gameManager.door;
        menuUI = gameManager.menuUI;
    }


    public void OpenDoor()
    {
        door.transform.rotation = Quaternion.Euler(0, 90, 0);
    }    
}
