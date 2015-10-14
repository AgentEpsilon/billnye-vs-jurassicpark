using UnityEngine;
using System.Collections;

public class PlayerDataManager : MonoBehaviour {

	public int health { get; private set; }
	public int maxHealth { get; private set; }

	public void Damage(int amt){
		health = Mathf.Max (health - amt, 0);
	}

	public void Heal(int amt){
		health = Mathf.Min (health + amt, maxHealth);
	}

	void Awake(){
		DontDestroyOnLoad (gameObject);
		maxHealth = PlayerPrefs.GetInt("maxHealth", 20);
		health = PlayerPrefs.GetInt ("health", maxHealth);
	}
}
