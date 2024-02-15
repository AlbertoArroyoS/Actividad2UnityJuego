using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LlamadasEnemigos : MonoBehaviour
{

    //variables
    public GameObject enemigoGordoPrefab;
    public GameObject enemigoGedeonPrefab;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("CrearEnemigos");    
    }

    // Update is called once per frame
    void Update()
    {
        //crear objetos enemigos y decir donde se van a instanciar
        
    }

    //corrutina, funcion especial que se pueden poner pausas y continua desde el punto que se quedo antes de la pausa
    IEnumerator CrearEnemigos()
    {
        //segundos a esperar
        yield return new WaitForSeconds(2);
        while (true)
        {
        //instanciar enemigos, que enemigo , posicion del objeto que tiene el script, quaternion que no se rote
         Instantiate(enemigoGordoPrefab,transform.position, Quaternion.identity);
        //hacer pausa con tiempo Random
         yield return new WaitForSeconds(Random.Range(4f,7f));
         //si se quiere llamar en cualquier lugar, CREAR UN VECTOR3 CON X, Y ALEATORIAS
         //Instantiate(enemigoGordoPrefab, ****CAMBIAR ESTO ****, Quaternion.identity);
        }
       
    }
}
