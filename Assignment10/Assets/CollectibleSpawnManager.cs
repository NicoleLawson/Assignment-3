/* Nicole Lawson
 * CollectibleSpawnManager
 * Assignment 10
 * Controls the spawning of collectibles around the player
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleSpawnManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> collectibles;
    [SerializeField] private List<GameObject> multicolorCollectibles;
    GameObject itemToPaint;
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Alpha1") == true)
        {
            for(int index = 0; index <=3; index++)
            {
                int rnd = Random.Range(0, 3);
                itemToPaint = collectibles[rnd];
                Instantiate(itemToPaint);
                itemToPaint.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
                multicolorCollectibles.Insert(Random.Range(0, 3), itemToPaint);
            }
        }
        else if(Input.GetButtonDown("Alpha2") == true)
        {
            Vector3 rndVec = new Vector3(player.transform.position.x - Random.Range(0, 5),
                player.transform.position.y - Random.Range(0, 5),
                player.transform.position.z - Random.Range(0, 5));
            Instantiate(itemToPaint, rndVec, Quaternion.identity);
            multicolorCollectibles.Remove(itemToPaint);
        }
    }
}
