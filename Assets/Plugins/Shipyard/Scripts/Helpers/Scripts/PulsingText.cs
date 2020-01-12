using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PulsingText : MonoBehaviour {

	private TMP_Text pulsingText;
	public float pulsingSpeed = 2;

	// Use this for initialization
	void Awake () {

		pulsingText = GetComponent<TMP_Text>();

	}
	
	// Update is called once per frame
	void Update () {

		Color pulseRotator = new Color(
            pulsingText.color.r,
            pulsingText.color.g,
            pulsingText.color.b,
            Mathf.Sin(Time.time * pulsingSpeed)
		);

		pulsingText.color = pulseRotator;
		

		if (gameObject.GetComponentInChildren<Image>()) {

			gameObject.GetComponentInChildren<Image>().color = pulseRotator;

		}      
	}
}
