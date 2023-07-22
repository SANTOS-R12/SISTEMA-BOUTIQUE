using System.Windows.Forms;

namespace SISTEMA
{
    internal class RowComparer : DataGridViewColumn
    {
        private SortOrder ascending;

        public RowComparer(SortOrder ascending)
        {
            this.ascending = ascending;
        }
    }
}