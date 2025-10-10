using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    private float inputX;
    private float inputZ;
    private CharacterController characterController;
    private Vector3 position;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        inputZ = Input.GetAxis("Vertical");
        position = new Vector3(inputX, 0, inputZ);
        GetComponent<Rigidbody>().linearVelocity =  position * speed;   //CharacterController smette di funzionare la porta
        //characterController.Move(position * speed * Time.deltaTime);
    }

    
}
