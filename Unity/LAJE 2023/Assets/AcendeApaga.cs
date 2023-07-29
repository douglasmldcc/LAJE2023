using System.Collections;
using System.Collections.Generic;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class AcendeApaga : MonoBehaviour
{
    Light2D acendeApaga;


    // Start is called before the first frame update
    void Start()
    {
        acendeApaga = GetComponent<Light2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)) {
            acendeApaga.enabled = !acendeApaga.enabled;
        }
    }



}
