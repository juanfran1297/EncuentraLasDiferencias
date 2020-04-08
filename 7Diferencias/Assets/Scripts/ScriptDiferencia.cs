using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptDiferencia : MonoBehaviour
{

    public SpriteRenderer thisRenderer;

    public bool encontrada;

    public GameObject gameManager;

    public AudioSource thisAudio;

    // Start is called before the first frame update
    void Start()
    {
        thisRenderer = GetComponent<SpriteRenderer>();
        thisRenderer.enabled = false;
        encontrada = false;

        thisAudio = GetComponent<AudioSource>();

        gameManager = GameObject.Find("GameManager");
    }
    private void OnMouseUpAsButton()
    {
        if(gameManager.GetComponent<Timer>().derrota == true)
        {
            return;
        }
        thisAudio.Play();
        Debug.Log("Has pulsado bien");
        thisRenderer.enabled = true;
        encontrada = true;

        gameManager.GetComponent<GameManager>().numDiferencias--;
        var colliders = this.GetComponents<Collider2D>();
        for(int i = 0; i < colliders.Length; i++)
        {
            colliders[i].enabled = false;
        }
    }
}
