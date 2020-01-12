
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;



[CustomPropertyDrawer(typeof(getDays))]
public class getDaysDrawer : PropertyDrawer
{
	public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
	{
		getDays att = attribute as getDays;
		string propertyPath = property.propertyPath;
		string dayIndex = propertyPath.Replace(property.name, att.dayIndex);
		SerializedProperty sourceProperty = property.serializedObject.FindProperty(dayIndex);

		MyScript myscript = (property.serializedObject.targetObject) as MyScript;

		if (myscript.ListOfDays == null)
			return;

		List<string> days = new List<string> { "None" };
		for (int x = 0; x < myscript.ListOfDays.Count; x++)
		{
			days.Add(x + "-" + myscript.ListOfDays[x]);
		}

		EditorGUI.PrefixLabel(position, new GUIContent("Day: "));
		position.x += Screen.width / 4;
		position.width -= Screen.width / 4;

		sourceProperty.intValue = Mathf.Clamp(sourceProperty.intValue, 0, days.Count - 1);
		sourceProperty.intValue = EditorGUI.Popup(position, sourceProperty.intValue, days.ToArray());

		property.stringValue = sourceProperty.intValue > 0 ? myscript.ListOfDays[sourceProperty.intValue - 1] : "";
	}
}