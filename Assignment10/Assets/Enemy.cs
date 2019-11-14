/* Nicole Lawson
 * Enemy
 * Assignment 10
 * Create a enemy and keep track of its attributes
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{
    string name;
    float speed;
    static int count;
    float attackRange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Enemy()
    {
        name = "Bob";
        speed = 10f;
        count = 3;
    }

    public Enemy(string otherName, int otherCount, float otherSpeed)
    {
        name = otherName;
        count = otherCount;
        speed = otherSpeed;
    }

    override public string ToString()
    {
        return "Name: " + name + ". Speed: " + speed + ". Count: " + count;
    }

    public string GetName()
    {
        return name;
    }

    public void SetName(string other)
    {
        name = other;
    }

    public float GetSpeed()
    {
        return speed;
    }

    public void SetSpeed(float other)
    {
        speed = other;
    }

    public int GetCount()
    {
        return count;
    }

    public void SetCount(int other)
    {
        count = other;
    }
    

}
