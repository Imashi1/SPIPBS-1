using UnityEngine;
using UnityEngine.UI;

public class CubeButton : MonoBehaviour
{
    public GameObject textPanel; // Asegúrate de asignar esto en el Inspector

    public void OnButtonPressed()
    {
        print("clickeadoo");
        // Activa o desactiva el panel de texto
        textPanel.SetActive(!textPanel.activeSelf);
    
    }
}
