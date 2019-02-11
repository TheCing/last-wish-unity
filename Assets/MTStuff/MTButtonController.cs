using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MTButtonController : MonoBehaviour
{
    public Button attackButton;
    public Button magicButton;
    public Button fireAttack;
    public Button iceAttack;
    public Button thunderAttack;
    public Button healButton;
    public Button backButton;

	// Use this for initialization
	void Start ()
    {
        attackButton = GameObject.Find("AttackButton").GetComponent<Button>();
        magicButton = GameObject.Find("MagicButton").GetComponent<Button>();
        fireAttack = GameObject.Find("FireAttack").GetComponent<Button>();
        iceAttack = GameObject.Find("IceAttack").GetComponent<Button>();
        thunderAttack = GameObject.Find("ThunderAttack").GetComponent<Button>();
        healButton = GameObject.Find("Heal").GetComponent<Button>();
        backButton = GameObject.Find("Back").GetComponent<Button>();
    }
	
	void HideButton()
    {
        fireAttack.gameObject.SetActive(false);
        iceAttack.gameObject.SetActive(false);
        thunderAttack.gameObject.SetActive(false);
        healButton.gameObject.SetActive(false);
    }
}
