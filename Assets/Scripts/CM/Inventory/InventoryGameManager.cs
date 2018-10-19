using UnityEngine;
using CM.Essentials.Inventory;

public class InventoryGameManager : MonoBehaviour
{
	private InventoryManager _inventoryManager;
	
	private void Start()
	{
		_inventoryManager = InventoryManager.Instance;

		_inventoryManager.GetInventoryByIndex(0).AddItem(_inventoryManager.GetItemByIndex(0), 0, 0);

		Debug.Log(_inventoryManager.GetInventoryByIndex(0).Title);
		Debug.Log(_inventoryManager.GetInventoryByIndex(0).GetItem(0, 0).Title);
	}
}