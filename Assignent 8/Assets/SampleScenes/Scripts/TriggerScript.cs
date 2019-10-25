/* Nicole Lawson
 * Trigger Script
 * Assignment 8
 * Makes calls to SpawnManager and UIManager when the player enters it
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter()
    {
        SpawnManager.instance.CancelBoxInvoke();
        UIManager.instance.DisplayPrompt();
        
    }
}
