using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    
    void OnTriggerEnter2D(Collider2D other){
        Debug.Log("hola");
        if(other.gameObject.CompareTag("Player")){
            Destroy(gameObject);
        }
    }

    

}
