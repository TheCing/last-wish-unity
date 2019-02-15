using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    MTButtonController buttonController;
    DM_VillainAI enemyController;

    float playerHealth = 100f;
    float playerMagic = 100f;

    float turnsRemaining = 4;

    Text healthLabel;
    Text magicLabel;
    Text enemyHealthText;

    bool playerTurn = true;

    // Use this for initialization
    void Start ()
    {
        healthLabel = GameObject.Find("Player1Health").GetComponent<Text>();
        magicLabel = GameObject.Find("Player1Magic").GetComponent<Text>();
        enemyHealthText = GameObject.Find("EnemyHealth").GetComponent<Text>();
        enemyController = GameObject.Find("Enemy").GetComponent<DM_VillainAI>();

        healthLabel.text = "HP: " + playerHealth;
        magicLabel.text = "MP: " + playerMagic;
        enemyHealthText.text = "HP: " + enemyController.enemyHealth;
    }
	
	// Update is called once per frame
	void Update ()
    {

    }

    public void PlayerAttack()
    {
        float playerAttack;

        if (playerTurn == true && turnsRemaining > 0)
        {
            playerAttack = Random.Range(1, 5);
            enemyController.enemyHealth = enemyController.enemyHealth - playerAttack;
            enemyHealthText.text = "HP: " + enemyController.enemyHealth;
            turnsRemaining--;
        }

        else
        {
            playerTurn = false;
        }
    }
}
