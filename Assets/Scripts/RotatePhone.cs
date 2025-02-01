using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePhone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		// When the game is started, rotate the phone's screen in landscape
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }
}
