using UnityEngine;

public class ButtonInteractions : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    private GameObject door;
    void Start()
    {
        door = gameManager.door;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenDoor()
    {
        door.transform.rotation = Quaternion.Euler(0, 90, 0);
    }
}
