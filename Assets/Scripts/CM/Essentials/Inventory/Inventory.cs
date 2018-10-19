using System.Collections.Generic;
using UnityEngine;

namespace CM.Essentials.Inventory
{
	[System.Serializable]
	public class Inventory : IInventory
	{
		[SerializeField] private string _title;
		public string Title { get { return _title; } set { _title = value; } }
		[SerializeField] private int _rows;
		public int Rows { get { return _rows; } set { _rows = value; } }
		[SerializeField] private int _columns;
		public int Columns { get { return _columns; } set { _columns = value; } }
		[SerializeField] private List<int> _itemIndexes = new List<int>();

		private Item[,] _stock;

		public void Setup()
		{
			_stock = new Item[_rows, _columns];
		}

		public void Setup(string title, int rows, int columns)
		{
			_title = title;
			_columns = columns;
			_rows = rows;
			_stock = new Item[rows, columns];
		}

		public Item GetItem(int row, int column)
		{
			return _stock[row, column];
		}

		public void AddItem(Item item, int row, int column)
		{
			_stock[row, column] = item;
		}
	}
}