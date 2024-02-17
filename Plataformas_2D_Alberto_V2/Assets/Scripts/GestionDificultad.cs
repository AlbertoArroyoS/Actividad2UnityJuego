using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionDificultad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void botonNormal()
    {
        //cargar la escena de game llamando al gestor
        SceneManager.LoadScene("Game");


    }

    public void botonFacil()
    {
        //cargar la escena de game llamando al gestor
        SceneManager.LoadScene("GameFacil");
    }
}
