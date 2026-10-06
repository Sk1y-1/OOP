namespace Lab1
{ 
    public partial class InputDialog : Form
    {
        private TextBox inputTxtBox;
        private Button btnYes;
        private Button btnCancel;

        public string InputText => inputTxtBox.Text;

        public InputDialog()
        {
            this.Text = "Dialog window";
            this.Width = 300;
            this.Height = 150;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;

            inputTxtBox = new TextBox() { Left = 20, Top = 20, Width = 240 };

            btnYes = new Button() { Text = "Yes", Left = 20, Top = 70, Width = 110, DialogResult = DialogResult.OK };
            btnCancel = new Button() { Text = "Cancel", Left = 140, Top = 70, Width = 100, DialogResult = DialogResult.Cancel };

            this.AcceptButton = btnYes;
            this.CancelButton = btnCancel;
            this.Controls.Add(inputTxtBox);
            this.Controls.Add(btnYes);
            this.Controls.Add(btnCancel);
        }
    }
}












