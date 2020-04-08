using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject[] diferencias;

    public Text diferenciasRestantes;

    public Canvas canvasDiferencias;
    public Canvas canvasVictoria;
    public Canvas canvasDerrota;

    public Timer timer;

    public AudioSource thisAudio;

    public int numIntentos;
    public int numDiferencias;

    public bool hasPerdido;
    public bool hasGanado;

    // Start is called before the first frame update
    void Start()
    {
        timer = GetComponent<Timer>();
        thisAudio = GetComponent<AudioSource>();

        thisAudio.volume = 0;

        diferencias = GameObject.FindGameObjectsWithTag("Diferencia");
        canvasDerrota = GameObject.Find("Canvas Derrota").GetComponent<Canvas>();
        numDiferencias = diferencias.Length;

        canvasDiferencias.enabled = true;
        canvasVictoria.enabled = false;

        hasGanado = false;
        hasPerdido = false;
        numIntentos = 5;
    }

    private void Update()
    {
        diferenciasRestantes.text = numDiferencias.ToString();

        if(numDiferencias <= 0)
        {
            thisAudio.volume = 0.08f;
            canvasDiferencias.enabled = false;
            canvasVictoria.enabled = true;
            hasGanado = true;
        }

        if(numIntentos <= 0)
        {
            canvasDiferencias.enabled = false;
            canvasDerrota.enabled = true;
            timer.derrota = true;
            hasPerdido = true;
        }
    }
}
