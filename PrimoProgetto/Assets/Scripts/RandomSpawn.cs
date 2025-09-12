using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    [SerializeField] private GameObject coinPrefab;

    public float minX = -9.77f;
    public float maxX = 9.47f;
    public float minZ = -4.8f;
    public float maxZ = 4.32f;
    public float maxValue = 10f;
    public int n;

    void Start()
    {
        for (int i = 0; i < n; i++)
        {
            
            bool check = false;
            do
            {
                Vector3 coord = RandomVector3(minX, maxX, minZ, maxZ);
                Vector3 spawnPos = coord;

                Collider[] colliders = Physics.OverlapSphere(spawnPos, 0.2f);

                if (colliders.Length > 0)
                {
                    Debug.Log("Attenzione, spawn in collisione con: " + colliders[0].gameObject.name);
                }
                else
                {
                    Instantiate(coinPrefab, spawnPos, Quaternion.identity);
                    check = true;
                }
            } while (check);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    private Vector3 RandomVector3(float minX, float maxX, float minZ, float maxZ)
    {
        float x = Random.Range(minX, maxX);
        float z = Random.Range(minZ, maxZ);
        float y = 0.6f;
        return new Vector3(x, y, z);
    }
}
