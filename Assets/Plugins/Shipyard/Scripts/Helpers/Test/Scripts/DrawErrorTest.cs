using UnityEngine;

using Shipyard.Helper;

public class DrawErrorTest : MonoBehaviour
{
	void Update()
	{
		DrawArrow.ForDebug(transform.position, transform.forward, Color.green);
	}
}
