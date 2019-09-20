/*
 * Nicole Lawson
 * PlayerControllerX
 * Assignment 4
 * Allows the player to spawn dogs
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timer = 0;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; 

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timer >= 1)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timer = 0;
        }
    }
}
