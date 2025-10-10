using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using static UnityEngine.Rendering.GPUSort;

public class EnvironmentInteraction : MonoBehaviour
{
    private XRBaseInteractable interactable;
    [SerializeField] private ScoreManager scoreManager;
    private void Start()
    {

    }

    public void PropsCaptured(SelectEnterEventArgs args)
    {
        GameObject selectedObject = args.interactableObject.transform.gameObject;
        scoreManager.UpdateScore();
        Destroy(selectedObject);
    }
}
