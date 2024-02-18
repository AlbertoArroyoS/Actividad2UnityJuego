using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CofreController : MonoBehaviour
{
    private AudioSource audioSourcePlayer;
    public AudioClip exito;
    public bool tieneAnillo = true;
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
        if (collision.gameObject.tag== "Player" && tieneAnillo)
        {
             GetComponent<Animator>().SetTrigger("open");
             audioSourcePlayer.PlayOneShot(exito);
        }
    }
}
