using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool jumpKeyWasPressed;
    private float horizontalInput;
    public string playerName = "Mathias";
    private int level = 1;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(playerName);
        PlayerDescription(level, playerName);
        NextLevel(level);
        LevelsUntilHundred(level);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpKeyWasPressed = true;
        }

        horizontalInput = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        if (jumpKeyWasPressed)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 5, ForceMode.VelocityChange);
            jumpKeyWasPressed = false;
        }

        GetComponent<Rigidbody>().velocity = new Vector3(horizontalInput, GetComponent<Rigidbody>().velocity.y, 0);
    }

    // This method prints the playername and level variable to the console
    private void PlayerDescription(int level, string name)
    {
        Debug.Log("My name is: " + name + ". I am level: " + level);
    }

    // This method calculates the next level
    private void NextLevel(int level)
    {
        Debug.Log("My current level is: " + level + ", but my next level is: " + (level + 1));
    }

    // This method calculates how many levels are needed, until the playr reaches level 100
    private void LevelsUntilHundred(int level)
    {
        if(level < 100)
        {
            Debug.Log("My current level is: " + level + ", which means i need " + (100-level) + " levels to get to 100");
        }
     
    }
}
