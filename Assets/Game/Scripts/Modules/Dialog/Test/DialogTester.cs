using UnityEngine;

public class DialogTester : MonoBehaviour
{
	public Dialog dialog;

	public void TriggerDialog()
	{
		FindObjectOfType<DialogManager>().StartDialog(dialog);
	}
}