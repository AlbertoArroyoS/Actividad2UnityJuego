using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class NewBehaviourScript : MonoBehaviour
{


    //saber la position del player
    Transform player;
    //velocidad del enemigo
    float speed = 2f;
    //para voltear al enemigo
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").transform;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //movernos hacia el player, moveTowards del punto A a B
        transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        if(transform.position.x > player.position.x)
        {
            //voltear
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
    }
}
