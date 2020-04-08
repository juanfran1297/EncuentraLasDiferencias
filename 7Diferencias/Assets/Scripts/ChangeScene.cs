using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    private Scene thisScene;
    public void CargarEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }

    public void Reintentar()
    {
        thisScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(thisScene.name);
    }

    public void Menu()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void Salir()
    {
        Application.Quit();
    }
}
