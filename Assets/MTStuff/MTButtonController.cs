using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MTButtonController : MonoBehaviour
{
    Button attackButton;
    Button magicButton;
    Button fireAttack;
    Button iceAttack;
    Button thunderAttack;
    Button healButton;
    Button backButton;

	// Use this for initialization
	void Start ()
    {
        attackButton = transform.Find("AttackButton").GetComponent<Button>();
        magicButton = transform.Find("MagicButton").GetComponent<Button>();
        fireAttack = transform.Find("FireAttack").GetComponent<Button>();
        iceAttack = transform.Find("IceAttack").GetComponent<Button>();
        thunderAttack = transform.Find("ThunderAttack").GetComponent<Button>();
        healButton = transform.Find("Heal").GetComponent<Button>();
        backButton = transform.Find("Back").GetComponent<Button>();

        InitialButtons();
    }
	
	void InitialButtons()
    {
        attackButton.gameObject.SetActive(true);
        magicButton.gameObject.SetActive(true);
        fireAttack.gameObject.SetActive(false);
        iceAttack.gameObject.SetActive(false);
        thunderAttack.gameObject.SetActive(false);
        healButton.gameObject.SetActive(false);
        backButton.gameObject.SetActive(false);
    }

    public void MagicButtons()
    {
        attackButton.gameObject.SetActive(false);
        magicButton.gameObject.SetActive(false);
        fireAttack.gameObject.SetActive(true);
        iceAttack.gameObject.SetActive(true);
        thunderAttack.gameObject.SetActive(true);
        healButton.gameObject.SetActive(true);
        backButton.gameObject.SetActive(true);
    }

    public void BackButton()
    {
        attackButton.gameObject.SetActive(true);
        magicButton.gameObject.SetActive(true);
        fireAttack.gameObject.SetActive(false);
        iceAttack.gameObject.SetActive(false);
        thunderAttack.gameObject.SetActive(false);
        healButton.gameObject.SetActive(false);
        backButton.gameObject.SetActive(true);
    }
}
