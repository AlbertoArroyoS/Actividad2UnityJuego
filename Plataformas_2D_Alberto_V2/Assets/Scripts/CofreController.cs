using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CofreController : MonoBehaviour
{
    private AudioSource audioSourcePlayer;
    public AudioClip exito;
    public bool tieneAnillo = false;
    // Start is called before the first frame update
    void Start()
    {
        audioSourcePlayer = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag== "Player" && tieneAnillo==true)
        {
             GetComponent<Animator>().SetTrigger("open");
             audioSourcePlayer.PlayOneShot(exito);
            //activar fin del juego
        }
    }
}
