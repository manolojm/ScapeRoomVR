using Oculus.Voice;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class VozOld : MonoBehaviour
{
    public GameObject cubo;

    public AppVoiceExperience appVoiceExperience;

    private void Start() {
        
    }

    private void Update() {
        appVoiceExperience.Activate();
    }

    public void UpdateColor(string[] values) {
        var colorString = values[0];
        var formaString = values[0];
        var colortmp = Color.blue;

        if(colorString == "rojo") {
            colortmp = Color.red;
        }

        Debug.Log("color: " + colorString);

        cubo.GetComponent<Renderer>().material.color = colortmp;
    }
}
