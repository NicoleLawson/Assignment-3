/*
 * Nicole Lawson
 * VelocityChangeForce
 * Assignment 9
 * Adds the VelocityChange force to an object
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityChangeForce : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().AddForce(Vector3.up, ForceMode.VelocityChange);
    }
}
