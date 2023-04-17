using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xRotationSpeed;
    [SerializeField] float yRotationSpeed = 50f;
    [SerializeField] float zRotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xRotationSpeed * Time.deltaTime, yRotationSpeed * Time.deltaTime, zRotationSpeed * Time.deltaTime);
    }
}
