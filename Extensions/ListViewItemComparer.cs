using System.Collections;

namespace NeosModManager.Extensions {
	class ListViewItemComparer : IComparer {
		private int col;
		private SortOrder sortOrder;
		public ListViewItemComparer() {
			col = 0;
			sortOrder = SortOrder.None;
		}
		public ListViewItemComparer(int column, SortOrder sort) {
			col = column;
			sortOrder = sort;
		}
		public int Compare(object x, object y) {
			int compareResult;
			compareResult = string.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
			if (sortOrder == SortOrder.Ascending) {
				return compareResult;
			} else if (sortOrder == SortOrder.Descending) {
				return (-compareResult); // Descending sort is selected, return negative result of compare operation
            } else {
				return 0; // Return '0' to indicate they are equal
            }
		}
	}
}
