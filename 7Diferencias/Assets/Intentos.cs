using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intentos : MonoBehaviour
{
    public int intentosTotales;

    private void Start()
    {
        intentosTotales = 5;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            Debug.Log(hit.transform.name);
            if (hit.transform.gameObject.name != "Diferencia")
            {
                intentosTotales--;
            }
        }
    }
}
