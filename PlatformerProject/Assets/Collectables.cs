using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collectables : MonoBehaviour
{
    //store the number of collected items in a variable
    public int souls = 0;
    //whenever we collide with a new collectable, add to my variable
    //destroy the collected item so we can't spam collect
    public TMP_Text text;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        //check to see if we hit a soul specifically
        if(collision.gameObject.tag == "Soul")
        {
            souls++;
            // add + " / #" after coins to telling players how many coins you need
            text.text = "Souls: " + souls;
            //Destroy the soul gameobject that we hit
            Destroy(collision.gameObject);
        }
        Debug.Log(collision.gameObject.name);
        //check to see if we hit a soul specifically
        if (collision.gameObject.tag == "HATEFULSoul")
        {
            souls += 5;
            // add + " / #" after coins to telling players how many coins you need
            text.text = "Souls: " + souls;
            //Destroy the soul gameobject that we hit
            Destroy(collision.gameObject);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
