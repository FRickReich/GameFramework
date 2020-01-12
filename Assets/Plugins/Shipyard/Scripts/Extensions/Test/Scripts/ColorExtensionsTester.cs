using UnityEngine;

using Shipyard.Extension;

namespace Shipyard.Test
{
	public class ColorExtensionsTester : MonoBehaviour
	{
		public Color color;

		// Start is called before the first frame update
		void Start()
		{
			Color testColor = new Color(255, 0, 0, 1);

			color = testColor.WithAlpha(0.3f);
		}

		// Update is called once per frame
		void Update()
		{

		}
	}
}

