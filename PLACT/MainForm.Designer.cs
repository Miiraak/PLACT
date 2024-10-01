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
            labelUserLicence = new Label();
            label2 = new Label();
            groupBoxInformations = new GroupBox();
            buttonRemoveKey = new Button();
            labelActivationStatus = new Label();
            labelEdition = new Label();
            labelWindowsVersion = new Label();
            label7 = new Label();
            label6 = new Label();
            labelOEMLicence = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBoxWinVersion = new GroupBox();
            label1 = new Label();
            buttonActivate = new Button();
            comboBoxLicence = new ComboBox();
            groupBoxInformations.SuspendLayout();
            groupBoxWinVersion.SuspendLayout();
            SuspendLayout();
            // 
            // labelUserLicence
            // 
            labelUserLicence.AutoSize = true;
            labelUserLicence.Font = new Font("Segoe UI", 6.75F);
            labelUserLicence.Location = new Point(91, 126);
            labelUserLicence.Name = "labelUserLicence";
            labelUserLicence.Size = new Size(146, 12);
            labelUserLicence.TabIndex = 3;
            labelUserLicence.Text = "XXXXX-XXXXX-XXXXX-XXXXX-XXXXX";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 96);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 4;
            // 
            // groupBoxInformations
            // 
            groupBoxInformations.Controls.Add(buttonRemoveKey);
            groupBoxInformations.Controls.Add(labelActivationStatus);
            groupBoxInformations.Controls.Add(labelEdition);
            groupBoxInformations.Controls.Add(labelWindowsVersion);
            groupBoxInformations.Controls.Add(label7);
            groupBoxInformations.Controls.Add(label6);
            groupBoxInformations.Controls.Add(labelOEMLicence);
            groupBoxInformations.Controls.Add(label5);
            groupBoxInformations.Controls.Add(label4);
            groupBoxInformations.Controls.Add(label3);
            groupBoxInformations.Controls.Add(labelUserLicence);
            groupBoxInformations.Dock = DockStyle.Top;
            groupBoxInformations.Location = new Point(0, 0);
            groupBoxInformations.Name = "groupBoxInformations";
            groupBoxInformations.Size = new Size(287, 179);
            groupBoxInformations.TabIndex = 5;
            groupBoxInformations.TabStop = false;
            groupBoxInformations.Text = "Informations";
            // 
            // buttonRemoveKey
            // 
            buttonRemoveKey.Location = new Point(107, 147);
            buttonRemoveKey.Name = "buttonRemoveKey";
            buttonRemoveKey.Size = new Size(118, 23);
            buttonRemoveKey.TabIndex = 13;
            buttonRemoveKey.Text = "Remove Key";
            buttonRemoveKey.UseVisualStyleBackColor = true;
            buttonRemoveKey.Click += ButtonRemoveKey_Click;
            // 
            // labelActivationStatus
            // 
            labelActivationStatus.AutoSize = true;
            labelActivationStatus.Location = new Point(91, 76);
            labelActivationStatus.Name = "labelActivationStatus";
            labelActivationStatus.Size = new Size(60, 15);
            labelActivationStatus.TabIndex = 12;
            labelActivationStatus.Text = "e.g. active";
            // 
            // labelEdition
            // 
            labelEdition.AutoSize = true;
            labelEdition.Location = new Point(91, 50);
            labelEdition.Name = "labelEdition";
            labelEdition.Size = new Size(90, 15);
            labelEdition.TabIndex = 11;
            labelEdition.Text = "e.g Professional";
            // 
            // labelWindowsVersion
            // 
            labelWindowsVersion.AutoSize = true;
            labelWindowsVersion.Location = new Point(91, 24);
            labelWindowsVersion.Name = "labelWindowsVersion";
            labelWindowsVersion.Size = new Size(88, 15);
            labelWindowsVersion.TabIndex = 10;
            labelWindowsVersion.Text = "e.g. Windows X";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 74);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 9;
            label7.Text = "State :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 49);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 8;
            label6.Text = "Edition :";
            // 
            // labelOEMLicence
            // 
            labelOEMLicence.AutoSize = true;
            labelOEMLicence.Font = new Font("Segoe UI", 6.75F);
            labelOEMLicence.Location = new Point(91, 102);
            labelOEMLicence.Name = "labelOEMLicence";
            labelOEMLicence.Size = new Size(146, 12);
            labelOEMLicence.TabIndex = 7;
            labelOEMLicence.Text = "XXXXX-XXXXX-XXXXX-XXXXX-XXXXX";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 124);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 6;
            label5.Text = "Active Key :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 99);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 5;
            label4.Text = "OEM Key :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 24);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Version :";
            // 
            // groupBoxWinVersion
            // 
            groupBoxWinVersion.Controls.Add(label1);
            groupBoxWinVersion.Controls.Add(buttonActivate);
            groupBoxWinVersion.Controls.Add(comboBoxLicence);
            groupBoxWinVersion.Dock = DockStyle.Top;
            groupBoxWinVersion.Location = new Point(0, 179);
            groupBoxWinVersion.Name = "groupBoxWinVersion";
            groupBoxWinVersion.Size = new Size(287, 80);
            groupBoxWinVersion.TabIndex = 6;
            groupBoxWinVersion.TabStop = false;
            groupBoxWinVersion.Text = "Activation :";
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
            // buttonActivate
            // 
            buttonActivate.Location = new Point(200, 21);
            buttonActivate.Name = "buttonActivate";
            buttonActivate.Size = new Size(75, 23);
            buttonActivate.TabIndex = 0;
            buttonActivate.Text = "Activate";
            buttonActivate.UseVisualStyleBackColor = true;
            buttonActivate.Click += ButtonActivate_Click;
            // 
            // comboBoxLicence
            // 
            comboBoxLicence.FormattingEnabled = true;
            comboBoxLicence.Location = new Point(12, 50);
            comboBoxLicence.Name = "comboBoxLicence";
            comboBoxLicence.Size = new Size(263, 23);
            comboBoxLicence.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(287, 264);
            Controls.Add(groupBoxWinVersion);
            Controls.Add(groupBoxInformations);
            Controls.Add(label2);
            Cursor = Cursors.Cross;
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PLACT";
            groupBoxInformations.ResumeLayout(false);
            groupBoxInformations.PerformLayout();
            groupBoxWinVersion.ResumeLayout(false);
            groupBoxWinVersion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelUserLicence;
        private Label label2;
        private GroupBox groupBoxInformations;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label labelOEMLicence;
        private GroupBox groupBoxWinVersion;
        private Label label1;
        private Button buttonActivate;
        private ComboBox comboBoxLicence;
        private Label label7;
        private Label labelActivationStatus;
        private Label labelEdition;
        private Label labelWindowsVersion;
        private Button buttonRemoveKey;
    }
}
