using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    MTButtonController buttonController;
    DM_VillainAI enemyController;

    float playerHealth = 100f;
    float playerMagic = 100f;

    Text healthLabel;
    Text magicLabel;
    Text enemyHealthText;

    bool playerTurn = true;

    //float enemyHealth = 1000;

    // Use this for initialization
    void Start ()
    {
        healthLabel = GameObject.Find("Player1Health").GetComponent<Text>();
        magicLabel = GameObject.Find("Player1Magic").GetComponent<Text>();
        enemyHealthText = GameObject.Find("EnemyHealth").GetComponent<Text>();

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

        if (playerTurn == true)
        {
            playerAttack = Random.Range(1, 5);
            enemyController.enemyHealth = enemyController.enemyHealth - playerAttack;
            //enemyHealth = enemyHealth - playerAttack;
            enemyHealthText.text = "HP: " + enemyController.enemyHealth;
            playerTurn = false;
        }

        else
        {
            playerTurn = false;
        }
    }
}
