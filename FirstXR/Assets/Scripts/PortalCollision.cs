using UnityEngine;

public class PortalCollision : MonoBehaviour 
{
    [SerializeField] private GameManager gameManager;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            gameManager.MainMenu();
        }
    }
}
