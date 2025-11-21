using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public static class UiHelpers
{
    // Configure DataGridView for Arabic (RTL) and apply header translations.
    public static void ConfigureDataGrid(DataGridView dgv, IDictionary<string, string> translations = null, string idColumnName = null)
    {
        if (dgv == null) return;

        dgv.RightToLeft = RightToLeft.Yes;
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        foreach (DataGridViewColumn col in dgv.Columns)
        {
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            // apply translations using case-insensitive match
            if (translations != null)
            {
                var match = translations
                    .FirstOrDefault(kvp => string.Equals(kvp.Key, col.Name, StringComparison.OrdinalIgnoreCase));
                if (!string.IsNullOrEmpty(match.Value))
                    col.HeaderText = match.Value;
            }
        }

        // hide id-like column if requested or found
        if (!string.IsNullOrWhiteSpace(idColumnName))
        {
            var idCol = dgv.Columns.Cast<DataGridViewColumn>()
                .FirstOrDefault(c => string.Equals(c.Name, idColumnName, StringComparison.OrdinalIgnoreCase));
            if (idCol != null) idCol.Visible = false;
        }
        else
        {
            // try hide any column that ends with "_id" or named "id"
            var autoId = dgv.Columns.Cast<DataGridViewColumn>()
                .FirstOrDefault(c => c.Name.EndsWith("_id", StringComparison.OrdinalIgnoreCase)
                                   || string.Equals(c.Name, "id", StringComparison.OrdinalIgnoreCase));
            if (autoId != null) autoId.Visible = false;
        }
    }

    public static void SetComboBoxRtl(ComboBox cb)
    {
        if (cb == null) return;
        cb.RightToLeft = RightToLeft.Yes;
    }
}