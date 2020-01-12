using System.Collections.Generic;
using UnityEngine;

public class getDays : PropertyAttribute
{
	public string dayIndex;
	public getDays(string dayIndex)
	{
		this.dayIndex = dayIndex;
	}
}

public class MyScript : MonoBehaviour
{

	[getDays("dayIndex")]
	public string day; // here will store the name of the day (string)
	[HideInInspector] public int dayIndex; // here store the index of the chosen day

	public List<string> ListOfDays = new List<string> { "Sat", "Sun", "Mon", "Tue", "Wed", "Thu", "Fri" }; // you can add or remove days from the inspector

}