using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Final : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void botonJugar()
    {
        //cargar la escena de game llamando al gestor
        SceneManager.LoadScene("Game");


    }

    public void botonExit()
    {
        //cargar la escena de game llamando al gestor
        Application.Quit();
    }
}
