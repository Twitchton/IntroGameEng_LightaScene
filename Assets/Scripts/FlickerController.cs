using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerController : MonoBehaviour
{
    private bool isFlickering = false;
    private float timeDelay;
    [SerializeField] private float minOffTime = 0.05f, maxOffTime = 0.15f, minOnTime = 0.01f, maxOnTime = 0.8f;

    // Update is called once per frame
    void Update()
    {
        if (isFlickering == false)
        {
            StartCoroutine(FlickeringLight());
        }
 
    }

    IEnumerator FlickeringLight()
    {
        isFlickering = true;
        this.gameObject.GetComponent<Light>().enabled = false;
        timeDelay = Random.Range(minOffTime, maxOffTime);
        yield return new WaitForSeconds(timeDelay);
        this.gameObject.GetComponent<Light>().enabled = true;
        timeDelay = Random.Range(minOnTime, maxOnTime);
        yield return new WaitForSeconds(timeDelay);
        isFlickering = false;

    }
}
