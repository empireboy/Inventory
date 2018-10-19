using System.Collections.Generic;
using UnityEngine;

namespace CM.Essentials.Inventory
{
	public class InventoryManager : MonoBehaviour
	{
		[SerializeField] private List<Inventory> _inventories = new List<Inventory>();
		[SerializeField] private List<Item> _items = new List<Item>();

		private static InventoryManager _instance;
		public static InventoryManager Instance
		{
			get { return _instance; }
		}

		private void Awake()
		{
			if (_instance == null) _instance = this;

			foreach (Inventory inventory in _inventories)
				inventory.Setup();
		}

		public Item GetItemByIndex(int index)
		{
			return _items[index];
		}

		public Inventory GetInventoryByIndex(int index)
		{
			return _inventories[index];
		}
	}
}