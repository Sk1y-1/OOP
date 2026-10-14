using System;
using System.Runtime.CompilerServices;

namespace Lab1 {

    public class GroupDialog : Form
    {
        private ListBox groupListBox;
        private Button btnYes;
        private Button btnCancel;
        public string SelectedGroup => groupListBox.SelectedItem?.ToString() ?? string.Empty;

        public GroupDialog()
        {
            groupListBox = new ListBox() { Left = 20, Top = 20, Width = 240, Height = 90 };
            string[] groupnames = { "IM-53 ", "IM-51", "IM-1488", "IM-69" };
            groupListBox.Items.AddRange(groupnames);

            btnYes = new Button() { Text = "Yes", Left = 20, Top = 130, Width = 100, DialogResult = DialogResult.OK };
            btnCancel = new Button() { Text = "Cancel", Left = 140, Top = 130, Width = 100, DialogResult = DialogResult.Cancel };

            this.AcceptButton = btnYes;
            this.CancelButton = btnCancel;

            this.Controls.Add(groupListBox);
            this.Controls.Add(btnYes);
            this.Controls.Add(btnCancel);
          }
       }
    }

