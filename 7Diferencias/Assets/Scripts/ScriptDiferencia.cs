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

        gameManager = GameObject.Find("GameManager");
        thisAudio = GetComponent<AudioSource>();
    }

    private void OnMouseDown()
    {
        if(gameManager.GetComponent<Timer>().derrota == true)
        {
            return;
        }

        thisRenderer.enabled = true;
        encontrada = true;
        thisAudio.Play();

        gameManager.GetComponent<GameManager>().numDiferencias--;
        var colliders = this.GetComponents<Collider2D>();
        for(int i = 0; i < colliders.Length; i++)
        {
            colliders[i].enabled = false;
        }
    }
}
