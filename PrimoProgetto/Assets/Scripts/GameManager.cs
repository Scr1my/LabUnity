using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject atomPrefab;
    [SerializeField] Vector3 initAtomPos;

    void Start()
    {
        Instantiate(atomPrefab, initAtomPos, Quaternion.identity);
    }

    
    void Update()
    {
        
    }
}
