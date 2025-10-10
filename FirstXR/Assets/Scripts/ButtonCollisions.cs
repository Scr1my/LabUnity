using UnityEngine;

public class ButtonCollisions : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    private GameObject door;
    void Start()
    {
        door = gameManager.door;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("keycard"))
        {
            door.transform.rotation = Quaternion.Euler(0, 90, 0);
        }
    }
}
