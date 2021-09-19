using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAnimation : MonoBehaviour
{
    [Range(0.01f, 0.1f)]
    public float scalationSpeed = 0.05f;

    [Range(15.0f, 25.0f)]
    public float rotationSpeed = 25.0f;

    public Quaternion objectOriginalLocalRotation;
    public float timeCounter = 0;

    // Start is called before the first frame update
#pragma warning disable IDE0051 // Remove unused private members
    void Start()
    {
        objectOriginalLocalRotation = this.transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        transform.Rotate(Vector3.left, rotationSpeed * Time.deltaTime);
        timeCounter += Time.deltaTime;
    }
}
