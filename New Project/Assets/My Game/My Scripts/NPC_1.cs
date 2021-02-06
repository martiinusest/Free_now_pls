using UnityEngine;
using System.Collections;

public class NPC_1 : NPC {
	 
	// Use this for initialization
	public override void OnSetUpDialogue() {

		Speech.AddDialogue("0", "HALLO!", "1");
		Speech.AddDialogue("1", "Get all coins plz", "2");
		Speech.AddDialogue("2", "U can use that Power Up", "3");
		Speech.AddDialogue("3", "Destroy all enemys for another powerup!", "4");
		Speech.AddDialogue("4", "Thx!");
	}

	// Triggered when the player comes in range of the NPC
	public override void OnTriggerNPC( Collider other ){

		Speech.SetDialogue("0");
	}
}