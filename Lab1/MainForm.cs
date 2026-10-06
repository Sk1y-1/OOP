пnamespace Lab1
{
    public partial class MainForm : Form
    {
        private Label resultLabel0;
        private Label resultLabel3;
        private Button openDialog0Btn;
        private Button openDialog3Btn;


        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public MainForm()
        {
            this.Text = "Main window";
            this.Width = 500;
            this.Height = 300;
            
            TabControl tabControl = new TabControl() { Dock = DockStyle.Fill };
            TabPage tab0 = new() { Text = "Option 0" };
            TabPage tab3 = new() { Text = "Option 3" };
            ;
            tabControl.TabPages.Add(tab0);
            tabControl.TabPages.Add(tab3);


            openDialog0Btn = new Button() { Text = "Enter text", Left = 20, Top = 20, Width = 150 };
            resultLabel0 = new Label() { Text = " Result 0 ", Left = 20, Top = 70, Width = 350 };
            openDialog0Btn.Click += OpenDialogBtn0_Click;

            openDialog3Btn = new Button() { Text = "Pick group", Left = 20, Top = 20, Width = 150 };
            resultLabel3 = new Label() { Text = "Result 3", Left = 20, Top = 70, Width = 350 };
            openDialog3Btn.Click += OpenDialogBtn3_Click;

           

            tab0.Controls.Add(openDialog0Btn);
            tab0.Controls.Add(resultLabel0);

            tab3.Controls.Add(openDialog3Btn);
            tab3.Controls.Add(resultLabel3);

            this.Controls.Add(tabControl);
        }   

        private void OpenDialogBtn0_Click(object sender, EventArgs e)
        {
            using (InputDialog dialog = new InputDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    resultLabel0.Text = dialog.InputText;
                 }
             }
         }

        private void OpenDialogBtn3_Click(object sender, EventArgs e)
        {
            using (InputDialog dialog = new InputDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    resultLabel3.Text = dialog.InputText;
                 }
             }
         }
     }
 }
