using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Pelota : MonoBehaviour
{

    public Animator miPuerta;

    /*private void OnTriggerEnter(Collider other) {
        if (other.tag == "Pelota") {

        }
    }*/

    private void OnTriggerExit(Collider other) {
        if (other.tag == "Pelota") {
            miPuerta.Play("PuertaAbrir");
        } 
    }
}
