using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Inventory
{
	public class Item : ScriptableObject
	{
		public int id;
		public string title;
		public string identifier;
		public string description;
		public Sprite icon;

		public Dictionary<string, int> stats = new Dictionary<string, int>();

		public Item(int id, string title, string description, string identifier, Dictionary<string, int> stats)
		{
			this.id = id;
			this.title = title;
			this.description = description;
			this.identifier = identifier;
			this.icon = Resources.Load<Sprite>($"Sprites/Items/{ identifier }");
		}

		public Item(Item item)
		{
			this.id = item.id;
			this.title = item.title;
			this.description = item.description;
			this.icon = Resources.Load<Sprite>($"Sprites/Items/{item.identifier}");
		}
    }
}
