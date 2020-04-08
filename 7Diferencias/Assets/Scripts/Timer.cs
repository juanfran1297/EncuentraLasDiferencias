using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public Canvas canvasVictoria;
    public Text tiempoText;
    public Image crono;
    public float tiempoMaximo;
    public float tiempo;

    public Gradient gradient;

    public Canvas canvasDiferencias;
    public Canvas canvasDerrota;

    public bool derrota;


    private void Start()
    {
        tiempoText = GameObject.Find("TXT_Timer").GetComponent<Text>();
        crono = GameObject.Find("CronoFill").GetComponent<Image>();
        canvasVictoria = GameObject.Find("Canvas Victoria").GetComponent<Canvas>();
        canvasDerrota = GameObject.Find("Canvas Derrota").GetComponent<Canvas>();
        canvasDiferencias = GameObject.Find("Canvas Diferencias").GetComponent<Canvas>();

        tiempoMaximo = 120f;
        tiempo = tiempoMaximo;

        canvasDerrota.enabled = false;

        derrota = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(canvasVictoria.enabled == true)
        {
            return;
        }

        tiempo -= Time.deltaTime;
        tiempo = Mathf.Clamp(tiempo, 0, tiempoMaximo);
        crono.fillAmount = tiempo / tiempoMaximo;
        tiempoText.text = "" + tiempo.ToString("f0");

        if (tiempo <= 120 && tiempo > 90)
        {
            crono.color = gradient.Evaluate(1f);
            tiempoText.color = gradient.Evaluate(1f);
        }

        if (tiempo <= 90 && tiempo > 60)
        {
            crono.color = gradient.Evaluate(.9f);
            tiempoText.color = gradient.Evaluate(.9f);
        }

        if (tiempo <= 60 && tiempo > 30)
        {
            crono.color = gradient.Evaluate(.6f);
            tiempoText.color = gradient.Evaluate(.6f);
        }

        if (tiempo <= 30 && tiempo > 15)
        {
            crono.color = gradient.Evaluate(.3f);
            tiempoText.color = gradient.Evaluate(.3f);
        }

        if (tiempo <= 15 && tiempo > -1)
        {
            crono.color = gradient.Evaluate(.1f);
            tiempoText.color = gradient.Evaluate(.1f);
        }

        if (tiempo <= 0)
        {
            canvasDiferencias.enabled = false;
            canvasDerrota.enabled = true;
            derrota = true;
        }
    }
}
