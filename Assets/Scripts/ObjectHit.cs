using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private bool hit;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player" && hit != true)
        {
            hit = true;
            GetComponent<MeshRenderer>().material.color = new Color(1, 0.7f, 075f);
        }
    }
    public bool getHit()
    {
        return hit;
    }
}
