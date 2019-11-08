/*
 * Nicole Lawson
 * AccelerationForce
 * Assignment 9
 * Adds the Acceleration force to an object
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerationForce : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().AddForce(Vector3.up, ForceMode.Acceleration);
    }

}
