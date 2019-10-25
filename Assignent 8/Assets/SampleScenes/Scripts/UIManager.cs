using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public GameObject canvas;

    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Sets the world space canvas to active
    public void DisplayPrompt()
    {
        canvas.SetActive(true);
        //Start coroutine that deactives the canvas after 5 seconds
        StartCoroutine(DisplayCountdown());
    }

    IEnumerator DisplayCountdown()
    {
        yield return new WaitForSeconds(5);
        canvas.SetActive(false);
    }
}
