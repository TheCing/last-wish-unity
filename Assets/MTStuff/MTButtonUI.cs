using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonUI : MonoBehaviour
{
    Button magicButton;
    Button attackButton;
    Button fireAttack;
    Button iceAttack;
    Button thunderAttack;
    Button healButton;
    Button backButton;

    // Use this for initialization
    void Start ()
    {
        magicButton = GetComponent<Button>();
        attackButton = GetComponent<Button>();
        fireAttack = GetComponent<Button>();
        iceAttack = GetComponent<Button>();
        thunderAttack = GetComponent<Button>();
        healButton = GetComponent<Button>();
        backButton = GetComponent<Button>();
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
