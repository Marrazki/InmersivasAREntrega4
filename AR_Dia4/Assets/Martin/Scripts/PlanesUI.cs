using UnityEngine;
using TMPro;

public class PlanesUI : MonoBehaviour
{
    public GameManager gameManager;
    public TextMeshProUGUI textoUI;

    void Update()
    {
        textoUI.text = "Planos: " + gameManager.numeroPlanos;
    }
}