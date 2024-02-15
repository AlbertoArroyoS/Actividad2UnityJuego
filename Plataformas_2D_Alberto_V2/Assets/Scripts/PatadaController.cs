using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatadaController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Gordo")
        {
            Destroy(collision.gameObject);
        }

        if (collision.tag == "Gedeon")
        {
            Destroy(collision.gameObject);
        }

    }
}
