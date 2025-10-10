using UnityEngine;

public class RotateCoin : MonoBehaviour
{
    Vector3 rotation;
    void Start()
    {
        rotation = new Vector3(0, 0.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotation);
    }
}
