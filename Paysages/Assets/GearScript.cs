using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GearScript : MonoBehaviour {

	public GameObject panel;

	void OnTriggerEnter(Collider other) {
		panel.SetActive (true);
	}

	void OnTriggerExit(Collider other) {
		panel.SetActive (false);
	}
}
