<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DM_VillainAI : MonoBehaviour
{
    public float enemyHealth = 1000f;
    int enemyAttack;

    Text enemyHealthText;


    //public int playerHealth;
    //public int playerAttack;

    //public int[] attackType;


    public void playerAttacks()
    {

        //attackType = new int[] { 1, 2, 3, 4, 5 };
        //dummy playerAttack Method
        //bool happens = true;
    }
    //string enemyPosition[] = [this.gameObject.transform.position.x, this.gameObject.transform.position.y];




    // Use this for initialization
    void Start()
    {
        //Player player = new Player;
        enemyHealth = 1000;

        enemyHealthText = GameObject.Find("EnemyHealth").GetComponent<Text>();
        enemyHealthText.text = "HP: " + enemyHealth;
    }
    /*
    // Update is called once per frame
    void Update()
    {
        float enA = Random.Range(1,10);

        if (player.playerAttacks())
        {
            enemyHealth = enemyHealth - playerAttack;
            return;
        }
        else if (playerAttacks.playerMagic()) 
        {
            //if the player chooses magic then...
            if (Fire) {
            //if they choose Fire Magic then...
              }
            else if (Ice) {
                //if they choose Ice Magic then...
            }
            else if (Thunder) {
                //if they choose Thunder Magic then...
            }

            return; 
        }

=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DM_VillainAI : MonoBehaviour {
    int enemyHealth;
    int enemyAttack;

    int playerHealth;
    int playerAttack;

    int enemyPosition;


	// Use this for initialization
	void Start () {
        //position start is 0
        //position.(canvasSize, height/2);

        //test comment
	}
	
	// Update is called once per frame
	void Update () {
        //Move toward closest player(s)
        //if(player location is...){Move toward the player}
        //else {move to random spot} 
>>>>>>> origin/develop

        //Choose between spell/physical attack

        //Animation based on attack type
        //Create random
        //if(Random = 1){spellAttack()}
        //else{physicalAttack()}

        //Glow Bright if hit by character
        //if(player hits){darkGlow()}
        //else{ takeTurn() }
        

    }*/
}
