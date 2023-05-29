using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Papel : MonoBehaviour
{

    public Animator miPuerta;

    public void OpenDoor() {
        miPuerta.Play("PuertaAbrir");
    }
}
