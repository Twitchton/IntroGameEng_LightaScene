using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flshflight : MonoBehaviour
{
    private bool enabled;

    // Start is called before the first frame update
    void Start()
    {
        enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            enabled = !enabled;
            this.gameObject.GetComponent<Light>().enabled = enabled;
        }
    }
}
