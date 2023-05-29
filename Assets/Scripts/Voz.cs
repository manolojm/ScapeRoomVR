using Oculus.Voice;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Voz : MonoBehaviour {
    public AppVoiceExperience appVoiceExperience;
    public Animator miPuerta;

    private void Start() {

    }

    private void Update() {
        appVoiceExperience.Activate();
    }

    public void AbrirPuerta(string[] values) {
        var abrirstring = values[0];
        var puertastring = values[1];

        if (abrirstring == "abrir" || abrirstring == "puerta" || puertastring == "abrir" || puertastring == "puerta") {
            miPuerta.Play("PuertaAbrir");
        } 
    }
}
