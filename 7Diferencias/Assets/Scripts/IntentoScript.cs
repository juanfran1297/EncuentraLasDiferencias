using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntentoScript : MonoBehaviour
{
    public GameManager gameManager;

    [SerializeField] private int numIntentos;
    [SerializeField] private int maxIntentos;
    public List<Image> Intentos = new List<Image>();

    public Image intentosImagen;
    public Transform intentosInventory;

    public AudioSource sonidoError;

    void Start()
    {
        maxIntentos = 5;
        numIntentos = 0;
        InstanciarIntentos();

        sonidoError = GetComponent<AudioSource>();

        GameObject aux = GameObject.Find("GameManager");
        if (aux != null)
        {
            gameManager = aux.GetComponent<GameManager>();
        }
        else
        { 
            Debug.LogError("No se encuentra el objeto GameManager"); 
        }
    }

    private void OnMouseUpAsButton()
    {
        if(gameManager.hasPerdido == true || gameManager.hasGanado == true)
        {
            return;
        }
        gameManager.numIntentos--;
        sonidoError.Play();
        AddIntento();
    }

    public void InstanciarIntentos()
    {
        for (int i = 0; i < numIntentos; i++)
        {
            Intentos[i] = Instantiate(intentosImagen, intentosInventory, false);
        }
    }

    public void AddIntento()
    {
        Intentos[maxIntentos - 1] = Instantiate(intentosImagen, intentosInventory, false);
    }
}
