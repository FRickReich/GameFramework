using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Game/Dialog")]
public class Dialog : ScriptableObject
{
	public string id;

	[SerializeField]
	public UnityEvent onCallback = new UnityEvent();

	public DialogSentence[] sentences;

	public Dialog(string id, DialogSentence sentence)
	{
		this.id = id;
		this.sentences[0] = sentence;
	}

	public void DialogCallback()
	{
		onCallback.Invoke();
	}
}
