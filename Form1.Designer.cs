namespace DCSGfxUtility
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
            installLocButton = new Button();
            installPath = new TextBox();
            label1 = new Label();
            label2 = new Label();
            savedGamesPath = new TextBox();
            savedGamesButton = new Button();
            custom1Button = new Button();
            custom2Button = new Button();
            custom3Button = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label3 = new Label();
            renameTB = new TextBox();
            renameButton = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // installLocButton
            // 
            installLocButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            installLocButton.Location = new Point(395, 11);
            installLocButton.Name = "installLocButton";
            installLocButton.Size = new Size(75, 25);
            installLocButton.TabIndex = 0;
            installLocButton.Text = "Browse...";
            installLocButton.UseVisualStyleBackColor = true;
            installLocButton.Click += Button1_Click;
            // 
            // installPath
            // 
            installPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            installPath.Enabled = false;
            installPath.Location = new Point(125, 11);
            installPath.Name = "installPath";
            installPath.Size = new Size(264, 23);
            installPath.TabIndex = 1;
            installPath.TextChanged += InstallPath_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 2;
            label1.Text = "DCS Folder";
            label1.Click += Label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(12, 43);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 5;
            label2.Text = "Saved Games Folder";
            label2.Click += Label2_Click;
            // 
            // savedGamesPath
            // 
            savedGamesPath.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            savedGamesPath.Enabled = false;
            savedGamesPath.Location = new Point(125, 40);
            savedGamesPath.Name = "savedGamesPath";
            savedGamesPath.Size = new Size(264, 23);
            savedGamesPath.TabIndex = 4;
            savedGamesPath.TextChanged += SavedGamesPath_TextChanged;
            // 
            // savedGamesButton
            // 
            savedGamesButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            savedGamesButton.Location = new Point(395, 40);
            savedGamesButton.Name = "savedGamesButton";
            savedGamesButton.Size = new Size(75, 23);
            savedGamesButton.TabIndex = 3;
            savedGamesButton.Text = "Browse...";
            savedGamesButton.UseVisualStyleBackColor = true;
            savedGamesButton.Click += Button2_Click;
            // 
            // custom1Button
            // 
            custom1Button.Anchor = AnchorStyles.None;
            custom1Button.Location = new Point(38, 10);
            custom1Button.Name = "custom1Button";
            custom1Button.Size = new Size(75, 23);
            custom1Button.TabIndex = 6;
            custom1Button.Text = "Custom1";
            custom1Button.UseVisualStyleBackColor = true;
            custom1Button.Click += custom1Button_Click;
            // 
            // custom2Button
            // 
            custom2Button.Anchor = AnchorStyles.None;
            custom2Button.Location = new Point(190, 10);
            custom2Button.Name = "custom2Button";
            custom2Button.Size = new Size(75, 23);
            custom2Button.TabIndex = 7;
            custom2Button.Text = "Custom2";
            custom2Button.UseVisualStyleBackColor = true;
            custom2Button.Click += custom2Button_Click;
            // 
            // custom3Button
            // 
            custom3Button.Anchor = AnchorStyles.None;
            custom3Button.Location = new Point(343, 10);
            custom3Button.Name = "custom3Button";
            custom3Button.Size = new Size(75, 23);
            custom3Button.TabIndex = 8;
            custom3Button.Text = "Custom3";
            custom3Button.UseVisualStyleBackColor = true;
            custom3Button.Click += custom3Button_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(custom1Button, 0, 0);
            tableLayoutPanel1.Controls.Add(custom3Button, 2, 0);
            tableLayoutPanel1.Controls.Add(custom2Button, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 93);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(458, 44);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 66);
            label3.Name = "label3";
            label3.Size = new Size(458, 25);
            label3.TabIndex = 10;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // renameTB
            // 
            renameTB.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            renameTB.Enabled = false;
            renameTB.Location = new Point(3, 3);
            renameTB.Name = "renameTB";
            renameTB.Size = new Size(452, 23);
            renameTB.TabIndex = 11;
            renameTB.TextAlign = HorizontalAlignment.Center;
            renameTB.KeyPress += renameTB_KeyPress;
            // 
            // renameButton
            // 
            renameButton.Anchor = AnchorStyles.None;
            renameButton.Enabled = false;
            renameButton.Location = new Point(194, 34);
            renameButton.MaximumSize = new Size(69, 23);
            renameButton.MinimumSize = new Size(69, 23);
            renameButton.Name = "renameButton";
            renameButton.Size = new Size(69, 23);
            renameButton.TabIndex = 12;
            renameButton.Text = "Rename";
            renameButton.UseVisualStyleBackColor = true;
            renameButton.Click += renameButton_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(renameTB, 0, 0);
            tableLayoutPanel2.Controls.Add(renameButton, 0, 1);
            tableLayoutPanel2.Location = new Point(12, 143);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(458, 61);
            tableLayoutPanel2.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 216);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(label3);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(savedGamesPath);
            Controls.Add(savedGamesButton);
            Controls.Add(label1);
            Controls.Add(installPath);
            Controls.Add(installLocButton);
            MaximizeBox = false;
            MaximumSize = new Size(1920, 255);
            MinimumSize = new Size(473, 255);
            Name = "Form1";
            Text = "DCSGfxUtility";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button installLocButton;
        private TextBox installPath;
        private Label label1;
        private Label label2;
        private TextBox savedGamesPath;
        private Button savedGamesButton;
        private Button custom1Button;
        private Button custom2Button;
        private Button custom3Button;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private TextBox renameTB;
        private Button renameButton;
        private TableLayoutPanel tableLayoutPanel2;
    }
}