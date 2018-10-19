using UnityEngine;

namespace CM.Essentials.Inventory
{
	[System.Serializable]
	public class Inventory : IInventory
	{
		[SerializeField] private string _title;
		public string Title { get { return _title; } set { _title = value; } }

		private Item[,] _stock;

		public Inventory(string title, int rows, int colomns)
		{
			_title = title;
			_stock = new Item[rows, colomns];
		}

		public Item GetItem(int row, int colomn)
		{
			return _stock[row, colomn];
		}

		public void AddItem(Item item, int row, int colomn)
		{
			_stock[row, colomn] = item;
		}
	}
}