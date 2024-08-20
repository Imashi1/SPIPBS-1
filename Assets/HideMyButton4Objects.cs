using UnityEngine;

public class ToggleVisibility : MonoBehaviour
{
    public GameObject myButton4; // Referencia al objeto MyButton4
    public GameObject myButton5; // Referencia al objeto MyButton4

    public GameObject toggleVisibilityButton; // Referencia al botón ToggleVisibilityButton

    private bool areObjectsVisible = true; // Estado de visibilidad de los objetos

    void Start()
    {
        // Añadir un listener al botón
        toggleVisibilityButton.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(ToggleTargetObjects);
    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                string btnName = hit.transform.name;
                if (btnName == "ToggleVisibilityButton") // Asegúrate de que este es el nombre correcto del botón
                {
                    ToggleTargetObjects();
                }
            }
        }
    }

    void ToggleTargetObjects()
    {
        // Alternar la visibilidad de los objetos bajo MyButton4
        areObjectsVisible = !areObjectsVisible;
        foreach (Transform child in myButton4.transform)
        {
            child.gameObject.SetActive(areObjectsVisible);
        }
        foreach (Transform child in myButton5.transform)
        {
            child.gameObject.SetActive(areObjectsVisible);
        }
    }
}