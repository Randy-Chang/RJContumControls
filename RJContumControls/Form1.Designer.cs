namespace RJContumControls
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
            components = new System.ComponentModel.Container();
            rjButton1 = new CustomControls.RJButton();
            rjDatePicker1 = new RJDatePicker();
            rjRadioButton1 = new RJRadioButton();
            rjRadioButton2 = new RJRadioButton();
            rjCircularPictureBox1 = new RJCircularPictureBox();
            rjDropdownMenu1 = new DropdownMenu.RJDropdownMenu(components);
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            rjTextBox1 = new RJTextBox();
            rjComboBox1 = new RJComboBox();
            rjProgressBar1 = new RJProgressBar();
            ((System.ComponentModel.ISupportInitialize)rjCircularPictureBox1).BeginInit();
            rjDropdownMenu1.SuspendLayout();
            SuspendLayout();
            // 
            // rjButton1
            // 
            rjButton1.BackColor = SystemColors.ControlLightLight;
            rjButton1.BackgroundColor = SystemColors.ControlLightLight;
            rjButton1.BorderColor = Color.Black;
            rjButton1.BorderRadius = 25;
            rjButton1.BorderSize = 5;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.ForeColor = Color.Black;
            rjButton1.Location = new Point(-5, 0);
            rjButton1.Margin = new Padding(5);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(144, 64);
            rjButton1.TabIndex = 0;
            rjButton1.Text = "Edit";
            rjButton1.TextColor = Color.Black;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // rjDatePicker1
            // 
            rjDatePicker1.BorderColor = Color.PaleVioletRed;
            rjDatePicker1.BorderSize = 0;
            rjDatePicker1.Font = new Font("Microsoft JhengHei UI", 9.5F);
            rjDatePicker1.Location = new Point(415, 29);
            rjDatePicker1.MinimumSize = new Size(0, 35);
            rjDatePicker1.Name = "rjDatePicker1";
            rjDatePicker1.Size = new Size(222, 35);
            rjDatePicker1.SkinColor = Color.MediumSlateBlue;
            rjDatePicker1.TabIndex = 2;
            rjDatePicker1.TextColor = Color.White;
            // 
            // rjRadioButton1
            // 
            rjRadioButton1.AutoSize = true;
            rjRadioButton1.CheckedColor = Color.DeepPink;
            rjRadioButton1.Location = new Point(27, 145);
            rjRadioButton1.MinimumSize = new Size(0, 21);
            rjRadioButton1.Name = "rjRadioButton1";
            rjRadioButton1.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton1.Size = new Size(177, 28);
            rjRadioButton1.TabIndex = 3;
            rjRadioButton1.TabStop = true;
            rjRadioButton1.Text = "rjRadioButton1";
            rjRadioButton1.UnCheckedColor = Color.Gray;
            rjRadioButton1.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton2
            // 
            rjRadioButton2.AutoSize = true;
            rjRadioButton2.CheckedColor = Color.DeepPink;
            rjRadioButton2.Location = new Point(27, 179);
            rjRadioButton2.MinimumSize = new Size(0, 21);
            rjRadioButton2.Name = "rjRadioButton2";
            rjRadioButton2.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton2.Size = new Size(177, 28);
            rjRadioButton2.TabIndex = 4;
            rjRadioButton2.TabStop = true;
            rjRadioButton2.Text = "rjRadioButton2";
            rjRadioButton2.UnCheckedColor = Color.Gray;
            rjRadioButton2.UseVisualStyleBackColor = true;
            // 
            // rjCircularPictureBox1
            // 
            rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            rjCircularPictureBox1.BorderColor = Color.RoyalBlue;
            rjCircularPictureBox1.BorderColor2 = Color.HotPink;
            rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            rjCircularPictureBox1.BorderSize = 2;
            rjCircularPictureBox1.GradientAngle = 90F;
            rjCircularPictureBox1.Location = new Point(461, 107);
            rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            rjCircularPictureBox1.Size = new Size(176, 176);
            rjCircularPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            rjCircularPictureBox1.TabIndex = 6;
            rjCircularPictureBox1.TabStop = false;
            // 
            // rjDropdownMenu1
            // 
            rjDropdownMenu1.DropShadowEnabled = false;
            rjDropdownMenu1.IsMainMenu = false;
            rjDropdownMenu1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3 });
            rjDropdownMenu1.MenuItemHeight = 25;
            rjDropdownMenu1.MenuItemTextColor = Color.Empty;
            rjDropdownMenu1.Name = "rjDropdownMenu1";
            rjDropdownMenu1.PrimaryColor = Color.Empty;
            rjDropdownMenu1.Size = new Size(82, 48);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem4, toolStripMenuItem5, toolStripMenuItem6 });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(81, 22);
            toolStripMenuItem2.Text = "1";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(81, 22);
            toolStripMenuItem4.Text = "1";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(81, 22);
            toolStripMenuItem5.Text = "2";
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(81, 22);
            toolStripMenuItem6.Text = "3";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(81, 22);
            toolStripMenuItem3.Text = "2";
            // 
            // rjTextBox1
            // 
            rjTextBox1.BackColor = SystemColors.Window;
            rjTextBox1.BorderColor = Color.MediumSlateBlue;
            rjTextBox1.BorderFocusColor = Color.HotPink;
            rjTextBox1.BorderRadius = 10;
            rjTextBox1.BorderSize = 2;
            rjTextBox1.Font = new Font("Microsoft JhengHei UI", 9.5F);
            rjTextBox1.ForeColor = Color.DimGray;
            rjTextBox1.Location = new Point(12, 82);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(11, 8, 11, 8);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.PlaceholderColor = Color.DarkGray;
            rjTextBox1.PlaceholderText = "";
            rjTextBox1.Size = new Size(142, 34);
            rjTextBox1.TabIndex = 7;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = false;
            // 
            // rjComboBox1
            // 
            rjComboBox1.BackColor = Color.WhiteSmoke;
            rjComboBox1.BorderColor = Color.MediumSlateBlue;
            rjComboBox1.BorderSize = 1;
            rjComboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            rjComboBox1.Font = new Font("Microsoft JhengHei UI", 10F);
            rjComboBox1.ForeColor = Color.DimGray;
            rjComboBox1.IconColor = Color.MediumSlateBlue;
            rjComboBox1.ListBackColor = Color.FromArgb(230, 228, 245);
            rjComboBox1.ListTextColor = Color.DimGray;
            rjComboBox1.Location = new Point(27, 235);
            rjComboBox1.MinimumSize = new Size(200, 30);
            rjComboBox1.Name = "rjComboBox1";
            rjComboBox1.Padding = new Padding(1);
            rjComboBox1.Size = new Size(200, 48);
            rjComboBox1.TabIndex = 8;
            rjComboBox1.Texts = "";
            // 
            // rjProgressBar1
            // 
            rjProgressBar1.ChannelColor = Color.AliceBlue;
            rjProgressBar1.ChannelHeight = 20;
            rjProgressBar1.ForeBackColor = SystemColors.Control;
            rjProgressBar1.ForeColor = Color.Black;
            rjProgressBar1.Location = new Point(61, 332);
            rjProgressBar1.Name = "rjProgressBar1";
            rjProgressBar1.ShowMaximun = false;
            rjProgressBar1.ShowValue = TextPosition.Center;
            rjProgressBar1.Size = new Size(273, 52);
            rjProgressBar1.SliderColor = Color.RoyalBlue;
            rjProgressBar1.SliderHeight = 6;
            rjProgressBar1.SymbolAfter = "";
            rjProgressBar1.SymbolBefore = "";
            rjProgressBar1.TabIndex = 9;
            rjProgressBar1.Value = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(696, 421);
            Controls.Add(rjProgressBar1);
            Controls.Add(rjComboBox1);
            Controls.Add(rjTextBox1);
            Controls.Add(rjCircularPictureBox1);
            Controls.Add(rjRadioButton2);
            Controls.Add(rjRadioButton1);
            Controls.Add(rjDatePicker1);
            Controls.Add(rjButton1);
            Font = new Font("微軟正黑體", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)rjCircularPictureBox1).EndInit();
            rjDropdownMenu1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.RJButton rjButton1;
        private RJDatePicker rjDatePicker1;
        private RJRadioButton rjRadioButton1;
        private RJRadioButton rjRadioButton2;
        private RJCircularPictureBox rjCircularPictureBox1;
        private DropdownMenu.RJDropdownMenu rjDropdownMenu1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem3;
        private RJTextBox rjTextBox1;
        private RJComboBox rjComboBox1;
        private RJProgressBar rjProgressBar1;
    }
}
