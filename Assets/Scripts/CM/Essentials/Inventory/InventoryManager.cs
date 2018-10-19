using System.Collections.Generic;
using UnityEngine;

namespace CM.Essentials.Inventory
{
	public class InventoryManager : MonoBehaviour
	{
		[SerializeField] private List<Inventory> _inventories = new List<Inventory>();
		[SerializeField] private List<Item> _items = new List<Item>();
	}
}