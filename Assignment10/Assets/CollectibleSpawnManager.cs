using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleSpawnManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> collectibles;
    [SerializeField] private List<GameObject> multicolorCollectibles;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Alpha1") == true)
        {
            for(int index = 0; index <=3; index++)
            {
                int rnd = Random.Range(0, 3);
                GameObject itemToPaint = collectibles[rnd];
                Instantiate(itemToPaint);
            }
        }
    }
}
