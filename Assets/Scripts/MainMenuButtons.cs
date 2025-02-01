// Why the heck does this thing use JetBrains Annotations?? I didn't use any JetBrains IDE while making this
using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MainMenuButtons : MonoBehaviour
{
	// Show the game mode selection screen
    public void ShowGameModeSelector()
    {
        gameObject.SetActive(false);
        GameObject[] objects = Resources.FindObjectsOfTypeAll<GameObject>();
        foreach (GameObject obj in objects)
        {
            if (obj.name == "PlayerModeCanvas")
            {
                obj.SetActive(true);
                break;
            }
        }
    }
	// Quit
    public void Quit()
    {
        Application.Quit();
    }
    public void StartGame()
    {
		// Load the correct scene according to the chosen game mode`
        Dropdown dropdown_component = GameObject.Find("Dropdown").GetComponent<Dropdown>();
        string option = dropdown_component.options[dropdown_component.value].text;
        string scene = option switch
        {
            "Player vs Player" => "PlayerVsPlayer",
            "Computer vs Player" => "PlayerVsAI"
        };
        SceneManager.LoadScene(scene);
    }
}
