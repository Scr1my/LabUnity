using System.Collections;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    private int health;
    [SerializeField] private GameObject player;
    void Start()
    {
        health = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage()
    {
        if (health > 1)
        {
            health -= 1;
            StartCoroutine(Respawn());
        }
        else
        {
            //lost
        }
        Debug.Log(health);
    }

    IEnumerator Respawn()
    {
        player.GetComponent<PlayerController>().enabled = false;
        GetComponent<GameManager>().TeleportToStart(player);
        yield return new WaitForSeconds(1);
        player.GetComponent<PlayerController>().enabled = true;
    }
}
