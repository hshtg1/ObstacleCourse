using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    Rigidbody rb;
    MeshRenderer renderer;
    [SerializeField] float dropTime = 3f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        renderer = GetComponent<MeshRenderer>();
        rb.useGravity = false;
        renderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > dropTime)
        {
            rb.useGravity = true;
            renderer.enabled = true;
        }
    }
}
