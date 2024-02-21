using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalFacil : MonoBehaviour
{
    public AudioClip cancionFinal;
    private AudioSource audioSourcePlayer;

    public TextMeshProUGUI puntosTextoFinal, maxPuntosTextoFinal;
    private int puntosMaxFinal;
    private int puntosPartidaFinal;


    // Start is called before the first frame update
    void Start()
    {
         audioSourcePlayer = GetComponent<AudioSource>();
         audioSourcePlayer.PlayOneShot(cancionFinal);
         puntosPartidaFinal = PlayerPrefs.GetInt("PuntuacionPartida", 0);
         puntosTextoFinal.text = ("PUNTOS: " + puntosPartidaFinal);
         puntosMaxFinal = PlayerPrefs.GetInt("PuntuacionMaxima", 0);
         maxPuntosTextoFinal.text = ("MAX: " + puntosMaxFinal);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void botonJugarFacil()
    {
        //cargar la escena de game llamando al gestor
        PlayerPrefs.SetInt("PuntuacionPartida", 0);
        SceneManager.LoadScene("GameFacil");


    }

    public void botonExit()
    {
        //cargar la escena de game llamando al gestor
        Application.Quit();
    }
}
