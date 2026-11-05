namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            objectToolStripMenuItem = new ToolStripMenuItem();
            miEllipse = new ToolStripMenuItem();
            miLine = new ToolStripMenuItem();
            miPoint = new ToolStripMenuItem();
            miRectangle = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            godWillHelpToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, objectToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(40, 20);
            fileToolStripMenuItem.Text = "File ";
            // 
            // objectToolStripMenuItem
            // 
            objectToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { miEllipse, miLine, miPoint, miRectangle });
            objectToolStripMenuItem.Name = "objectToolStripMenuItem";
            objectToolStripMenuItem.Size = new Size(54, 20);
            objectToolStripMenuItem.Text = "Object";
            // 
            // miEllipse
            // 
            miEllipse.Name = "miEllipse";
            miEllipse.Size = new Size(180, 22);
            miEllipse.Text = "Ellipse";
            miEllipse.Click += ellipseToolStripMenuItem_Click;
            // 
            // miLine
            // 
            miLine.Name = "miLine";
            miLine.Size = new Size(180, 22);
            miLine.Text = "Line";
            // 
            // miPoint
            // 
            miPoint.Name = "miPoint";
            miPoint.Size = new Size(180, 22);
            miPoint.Text = "Point";
            miPoint.Click += dotToolStripMenuItem_Click;
            // 
            // miRectangle
            // 
            miRectangle.Name = "miRectangle";
            miRectangle.Size = new Size(180, 22);
            miRectangle.Text = "Rectangle";
            miRectangle.Click += rectangleToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { godWillHelpToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // godWillHelpToolStripMenuItem
            // 
            godWillHelpToolStripMenuItem.Name = "godWillHelpToolStripMenuItem";
            godWillHelpToolStripMenuItem.Size = new Size(180, 22);
            godWillHelpToolStripMenuItem.Text = "God will help ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem objectToolStripMenuItem;
        private ToolStripMenuItem miEllipse;
        private ToolStripMenuItem miLine;
        private ToolStripMenuItem miPoint;
        private ToolStripMenuItem miRectangle;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem godWillHelpToolStripMenuItem;
    }
}
