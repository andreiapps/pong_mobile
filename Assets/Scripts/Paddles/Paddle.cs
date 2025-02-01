using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    bool goUp, goDown = false;
    public void Up()
    {
		// Go up
        goUp = true;
        goDown = false;
    }
    public void Down()
    {
		// Go down
        goUp = false;
        goDown = true;
    }
    public void Stop()
    {
		// Stop
        goUp = goDown = false;
    }
    public void FixedUpdate()
    {
		// Go up or down depending on the booleans above, which are changed when the arrow buttons are pressed
        if (goUp)
        {
            transform.Translate(Vector3.up * 10 * Time.deltaTime);
        }
        if (goDown)
        {
            transform.Translate(Vector3.down * 10 * Time.deltaTime);
        }
    }
}
