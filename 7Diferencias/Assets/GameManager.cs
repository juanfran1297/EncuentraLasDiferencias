using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject[] diferencias;

    public int numDiferencias;
    public Text diferenciasRestantes;

    public Canvas canvasDiferencias;
    public Canvas canvasVictoria;

    // Start is called before the first frame update
    void Start()
    {
        diferencias = GameObject.FindGameObjectsWithTag("Diferencia");
        numDiferencias = diferencias.Length;

        canvasDiferencias.enabled = true;
        canvasVictoria.enabled = false;
    }

    private void Update()
    {
        diferenciasRestantes.text = numDiferencias.ToString();

        if(numDiferencias <= 0)
        {
            canvasDiferencias.enabled = false;
            canvasVictoria.enabled = true;
        }
    }
}
