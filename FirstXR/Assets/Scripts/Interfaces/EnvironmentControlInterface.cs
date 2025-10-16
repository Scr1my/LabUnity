using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public interface EnvironentControl
{
    void PropsCaptured(SelectEnterEventArgs args);
    void ReturnToLobby();
    void OpenCloseUI();
}
