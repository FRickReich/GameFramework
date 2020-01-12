using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Helper
{
	[ExecuteInEditMode]
	public class AttachUIToGameObject : MonoBehaviour
	{
		public Image crosshair;
		public Transform target;

		// Update is called once per frame
		void LateUpdate()
		{
			crosshair.transform.position = Game.Extension.VectorExtensions.TransformToScreenPosition(target.position);
		}
	}
}
