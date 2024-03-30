using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipOtomasyonu.Entities.Utilities
{
    public  class DataGridStyle
    {
        public static void DatagridviewSetting(DataGridView datagridview)
        {
            datagridview.RowHeadersVisible = false;
            datagridview.BorderStyle = BorderStyle.None;

            datagridview.ColumnHeadersDefaultCellStyle.BackColor = Color.Tan;
            datagridview.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;


            datagridview.RowsDefaultCellStyle.BackColor = Color.Black;
            datagridview.RowsDefaultCellStyle.ForeColor = Color.White;

            datagridview.DefaultCellStyle.SelectionBackColor = Color.White;
            datagridview.DefaultCellStyle.SelectionForeColor = Color.Black;
            
            datagridview.EnableHeadersVisualStyles = false;
            datagridview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            datagridview.BackgroundColor = Color.FromArgb(170,161,150);
        }
    }
}
