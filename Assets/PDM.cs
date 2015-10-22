using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PDM : MonoBehaviour {

	public static PDM instance;

	private Slider healthbar;

	public int health { 
		get{
			return PlayerPrefs.GetInt ("health");
		} 
		set{
			PlayerPrefs.SetInt("health", Mathf.Min(Mathf.Max(value, 0), maxHealth));
			healthbar.value = health;
			Debug.Log (this.health);
		}
	}

	public readonly int maxHealth = 20;

	void Start(){
		DontDestroyOnLoad (gameObject);
		instance = this;
		health = PlayerPrefs.GetInt ("health", maxHealth);
		OnLevelWasLoaded ();
		Debug.Log ("Awake");
	}

	void OnLevelWasLoaded(){
		healthbar = GameObject.Find ("HealthBar").GetComponent<Slider>();
		healthbar.minValue = 0;
		healthbar.maxValue = maxHealth;
	}
}
