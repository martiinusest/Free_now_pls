using UnityEngine;
using System.Collections;

public class GameScript : MonoBehaviour {

	public Transform level2enemies;
	private bool level2complete = false;
	public GameObject level2rewards;


	// Use this for initialization
	protected void Start () {
		level2rewards.SetActive(false);
	}

	// Update is called once per frame
	protected void Update () {

		if (level2enemies.childCount == 0 && level2complete == false)
		{
			HUD.Message("You destroyed all the enemies! Now find The Power Up!");
			level2complete = true;
			level2rewards.SetActive(true);
		}

	}
}