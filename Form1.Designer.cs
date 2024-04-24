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
            installLocButton.Location = new Point(564, 18);
            installLocButton.Margin = new Padding(4, 5, 4, 5);
            installLocButton.Name = "installLocButton";
            installLocButton.Size = new Size(107, 42);
            installLocButton.TabIndex = 0;
            installLocButton.Text = "Browse...";
            installLocButton.UseVisualStyleBackColor = true;
            installLocButton.Click += Button1_Click;
            // 
            // installPath
            // 
            installPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            installPath.Enabled = false;
            installPath.Location = new Point(179, 18);
            installPath.Margin = new Padding(4, 5, 4, 5);
            installPath.Name = "installPath";
            installPath.Size = new Size(375, 31);
            installPath.TabIndex = 1;
            installPath.TextChanged += InstallPath_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(17, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 2;
            label1.Text = "DCS Folder";
            label1.Click += Label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(17, 72);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(174, 25);
            label2.TabIndex = 5;
            label2.Text = "Saved Games Folder";
            label2.Click += Label2_Click;
            // 
            // savedGamesPath
            // 
            savedGamesPath.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            savedGamesPath.Enabled = false;
            savedGamesPath.Location = new Point(179, 67);
            savedGamesPath.Margin = new Padding(4, 5, 4, 5);
            savedGamesPath.Name = "savedGamesPath";
            savedGamesPath.Size = new Size(375, 31);
            savedGamesPath.TabIndex = 4;
            savedGamesPath.TextChanged += SavedGamesPath_TextChanged;
            // 
            // savedGamesButton
            // 
            savedGamesButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            savedGamesButton.Location = new Point(564, 67);
            savedGamesButton.Margin = new Padding(4, 5, 4, 5);
            savedGamesButton.Name = "savedGamesButton";
            savedGamesButton.Size = new Size(107, 38);
            savedGamesButton.TabIndex = 3;
            savedGamesButton.Text = "Browse...";
            savedGamesButton.UseVisualStyleBackColor = true;
            savedGamesButton.Click += Button2_Click;
            // 
            // custom1Button
            // 
            custom1Button.Anchor = AnchorStyles.None;
            custom1Button.Location = new Point(55, 17);
            custom1Button.Margin = new Padding(4, 5, 4, 5);
            custom1Button.Name = "custom1Button";
            custom1Button.Size = new Size(107, 38);
            custom1Button.TabIndex = 6;
            custom1Button.Text = "Custom1";
            custom1Button.UseVisualStyleBackColor = true;
            custom1Button.Click += custom1Button_Click;
            // 
            // custom2Button
            // 
            custom2Button.Anchor = AnchorStyles.None;
            custom2Button.Location = new Point(273, 17);
            custom2Button.Margin = new Padding(4, 5, 4, 5);
            custom2Button.Name = "custom2Button";
            custom2Button.Size = new Size(107, 38);
            custom2Button.TabIndex = 7;
            custom2Button.Text = "Custom2";
            custom2Button.UseVisualStyleBackColor = true;
            custom2Button.Click += custom2Button_Click;
            // 
            // custom3Button
            // 
            custom3Button.Anchor = AnchorStyles.None;
            custom3Button.Location = new Point(491, 17);
            custom3Button.Margin = new Padding(4, 5, 4, 5);
            custom3Button.Name = "custom3Button";
            custom3Button.Size = new Size(107, 38);
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
            tableLayoutPanel1.Location = new Point(17, 155);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(654, 73);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(21, 110);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(654, 42);
            label3.TabIndex = 10;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // renameTB
            // 
            renameTB.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            renameTB.Enabled = false;
            renameTB.Location = new Point(4, 5);
            renameTB.Margin = new Padding(4, 5, 4, 5);
            renameTB.Name = "renameTB";
            renameTB.ShortcutsEnabled = false;
            renameTB.Size = new Size(646, 31);
            renameTB.TabIndex = 11;
            renameTB.TextAlign = HorizontalAlignment.Center;
            renameTB.TextChanged += renameTB_TextChanged;
            // 
            // renameButton
            // 
            renameButton.Anchor = AnchorStyles.None;
            renameButton.Enabled = false;
            renameButton.Location = new Point(277, 57);
            renameButton.Margin = new Padding(4, 5, 4, 5);
            renameButton.MaximumSize = new Size(99, 38);
            renameButton.MinimumSize = new Size(99, 38);
            renameButton.Name = "renameButton";
            renameButton.Size = new Size(99, 38);
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
            tableLayoutPanel2.Location = new Point(17, 210);
            tableLayoutPanel2.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(654, 102);
            tableLayoutPanel2.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 332);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(label3);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(savedGamesPath);
            Controls.Add(savedGamesButton);
            Controls.Add(label1);
            Controls.Add(installPath);
            Controls.Add(installLocButton);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MaximumSize = new Size(2733, 388);
            MinimumSize = new Size(666, 388);
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