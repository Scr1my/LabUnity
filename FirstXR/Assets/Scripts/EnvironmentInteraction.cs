using UnityEditor;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using static UnityEngine.Rendering.GPUSort;

public class EnvironmentInteraction : MonoBehaviour, EnvironentControl
{
    private XRBaseInteractable interactable;
    [SerializeField] private ScoreManager scoreManager;
    [SerializeField] private GameManager gameManager;


    private GameObject menuUI;

    private void Start()
    {
        menuUI = gameManager.menuUI;
    }

    public void PropsCaptured(SelectEnterEventArgs args)
    {
        GameObject selectedObject = args.interactableObject.transform.gameObject;
        scoreManager.UpdateScore();
        Destroy(selectedObject);
    }

    public void ReturnToLobby()
    {
        PlayerPrefs.SetInt("score", 0);
        gameManager.MainMenu();
    }

    public void OpenCloseUI()
    {
        menuUI.SetActive(!menuUI.gameObject.activeSelf);
    }
}
