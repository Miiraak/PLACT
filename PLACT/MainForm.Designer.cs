namespace PLACT
{
    partial class MainForm
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
            buttonActivate = new Button();
            groupBoxWinVersion = new GroupBox();
            label1 = new Label();
            comboBoxLicence = new ComboBox();
            groupBoxWinVersion.SuspendLayout();
            SuspendLayout();
            // 
            // buttonActivate
            // 
            buttonActivate.Location = new Point(182, 21);
            buttonActivate.Name = "buttonActivate";
            buttonActivate.Size = new Size(75, 23);
            buttonActivate.TabIndex = 0;
            buttonActivate.Text = "Activate";
            buttonActivate.UseVisualStyleBackColor = true;
            buttonActivate.Click += ButtonActivate_Click;
            // 
            // groupBoxWinVersion
            // 
            groupBoxWinVersion.Controls.Add(label1);
            groupBoxWinVersion.Controls.Add(buttonActivate);
            groupBoxWinVersion.Controls.Add(comboBoxLicence);
            groupBoxWinVersion.Location = new Point(12, 12);
            groupBoxWinVersion.Name = "groupBoxWinVersion";
            groupBoxWinVersion.Size = new Size(263, 80);
            groupBoxWinVersion.TabIndex = 1;
            groupBoxWinVersion.TabStop = false;
            groupBoxWinVersion.Text = "[NAME]";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 1;
            label1.Text = "Licence type :";
            // 
            // comboBoxLicence
            // 
            comboBoxLicence.FormattingEnabled = true;
            comboBoxLicence.Location = new Point(6, 50);
            comboBoxLicence.Name = "comboBoxLicence";
            comboBoxLicence.Size = new Size(251, 23);
            comboBoxLicence.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(287, 103);
            Controls.Add(groupBoxWinVersion);
            Cursor = Cursors.Cross;
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PLACT";
            groupBoxWinVersion.ResumeLayout(false);
            groupBoxWinVersion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonActivate;
        private GroupBox groupBoxWinVersion;
        private ComboBox comboBoxLicence;
        private Label label1;
    }
}
