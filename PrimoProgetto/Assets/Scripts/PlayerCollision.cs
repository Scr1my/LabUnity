using System.Collections;
using TMPro;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    
    [SerializeField] private GameObject gameManager;
    private GameManager gm;
    private HealthManager hm;

    private void Start()
    {
        gm = gameManager.GetComponent<GameManager>();
        hm = gameManager.GetComponent<HealthManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Debug.Log("moneta");
            collision.gameObject.GetComponent<BoxCollider>().enabled = false;
            StartCoroutine(DestroyCoin(collision.gameObject));
        }

        if (collision.gameObject.tag == "Door")
        {
            Debug.Log("porta");
            collision.transform.parent.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        if (collision.gameObject.tag == "Hole")
        {
            Debug.Log("buco");
            hm.TakeDamage();
        }

        if (collision.gameObject.tag == "Checkpoint")
        {
            Debug.Log("Checkpoint");
            gm.Win();
        }
    }

    IEnumerator DestroyCoin(GameObject coin)
    {
        yield return new WaitForSeconds(1);
        coin.GetComponent<MeshRenderer>().material.color = Color.red;
        yield return new WaitForSeconds(1);
        Destroy(coin);
        gm.PlayCoinSFX();
        gm.UpdateScore();
    }
}
