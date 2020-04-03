using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptDiferencia : MonoBehaviour
{

    public SpriteRenderer thisRenderer;

    public bool encontrada;

    public GameObject gameManager;

    // Start is called before the first frame update
    void Start()
    {
        thisRenderer = GetComponent<SpriteRenderer>();
        thisRenderer.enabled = false;
        encontrada = false;

        gameManager = GameObject.Find("GameManager");
    }

    private void OnMouseDown()
    {
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
