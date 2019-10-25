/* Nicole Lawson
 * SpawnManager
 * Assignment 8
 * Singleton script that manages the spawning of small boxes
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public static SpawnManager instance;
    public GameObject SmallBox;

    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBox", 2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnBox()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        float rndX = player.transform.position.x + Random.Range(-5f, 5f);
        float rndZ = player.transform.position.z + Random.Range(-5f, 5f);
        float rndY = player.transform.position.y + 5;
        Vector3 dest = new Vector3(rndX, rndY, rndZ);
        Instantiate(SmallBox, dest, Quaternion.identity );
    }

    public void CancelBoxInvoke()
    {
        CancelInvoke("SpawnBox");
    }
}
