using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Game.Helper;

public class DrawErrorTest : MonoBehaviour
{
    void Update()
	{
		DrawArrow.ForDebug(transform.position, transform.forward, Color.green);
	}
}
