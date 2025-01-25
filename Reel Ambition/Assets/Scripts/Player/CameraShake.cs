// Shake the camera when the player shoots

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public bool shake;
    public AnimationCurve shakeCurve;
    public float shakeTime;


    // Update is called once per frame
    void Update()
    {
        CheckShake();
    }

    // Set shake to false if it's true and start Shake Coroutine
    void CheckShake()
    {
        if (shake)
        {
            shake = false;
            StartCoroutine(Shake());
        }
    }

    // Coroutine to shake the camera
    IEnumerator Shake()
    {
        Vector3 cameraPosition = transform.position;

        float elapsedTime = 0f;

        while (elapsedTime < shakeTime)
        {
            elapsedTime += Time.deltaTime;

            float strength = shakeCurve.Evaluate(elapsedTime / shakeTime);

            transform.position = cameraPosition + Random.insideUnitSphere * strength;
            yield return null;
        }

        transform.position = cameraPosition;
    }
}
