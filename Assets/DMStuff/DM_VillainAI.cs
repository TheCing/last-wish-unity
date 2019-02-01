using System.Collections;
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
	}
	
	// Update is called once per frame
	void Update () {
        //Move toward closest player(s)
        //if(player location is...){Move toward the player}
        //else {move to random spot} 

        //Choose between spell/physical attack
        //Animation based on attack type
        //Create random
        //if(Random = 1){spellAttack()}
        //else{physicalAttack()}

        //Glow Bright if hit by character
        //if(player hits){darkGlow()}
        //else{ takeTurn() }


    }
}
