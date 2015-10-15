using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerDataManager : MonoBehaviour {

	public static PlayerDataManager instance;

	private Slider healthbar;

	public int health { 
		get{
			return PlayerPrefs.GetInt ("health");
		} 
		set{
			if(value<0)
				PlayerPrefs.SetInt("health", Mathf.Max(value, 0));
			else if(value>maxHealth)
				PlayerPrefs.SetInt("health", Mathf.Min(value, maxHealth));
			else
				PlayerPrefs.SetInt("health", value);

			healthbar.value = health;
			Debug.Log (health);
		}
	}

	public readonly int maxHealth = 20;

	void Awake(){
		DontDestroyOnLoad (gameObject);
		instance = this;
		healthbar = GameObject.Find ("HealthBar").GetComponent<Slider>();
		healthbar.minValue = 0;
		healthbar.maxValue = maxHealth; 
		health = PlayerPrefs.GetInt ("health", maxHealth);
	}
}
