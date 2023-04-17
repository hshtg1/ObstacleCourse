using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score;
    private void OnCollisionEnter(Collision collision)
    {
        if(!collision.gameObject.GetComponent<ObjectHit>().getHit())
        {
            score++;
            Debug.Log("You've bumped into a thing this many times: " + score);
        }
    }
}
