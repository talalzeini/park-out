using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinZoneScript : MonoBehaviour {

	// Reference to WinText game object
	public GameObject winPanel;
    public GameObject Cars;

	// Use this for initialization
	void Start () {
		// Turn "You Win!" sign at the start
	
	}

	// If target car (red one) exits the playground
	void OnTriggerEnter2D (Collider2D col)
	{
		// then "You Win!" sign is turned on
		winPanel.gameObject.SetActive (true);
        Destroy(Cars);

}
}
