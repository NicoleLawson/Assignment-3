/* Nicole Lawson
 * EnemyDatabase
 * Assignment 10
 * Creates a dictionary of enemies
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDatabase : MonoBehaviour
{
    Dictionary<string, Enemy> enemies = new Dictionary<string, Enemy>();

    // Start is called before the first frame update
    void Start()
    {
        enemies.Add("1", new Enemy());
        enemies.Add("2", new Enemy("George", 2, 4f));
        enemies.Add("3", new Enemy("Frank", 3, 5f));

        if(enemies.ContainsKey("1"))
        {
            enemies.Remove("1");
        }
        
        foreach(KeyValuePair<string, Enemy> enemy in enemies)
        {
            Debug.Log(enemy.Key + enemy.Value.ToString());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
