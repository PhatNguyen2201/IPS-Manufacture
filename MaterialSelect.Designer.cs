namespace ExoSendTo3DPrint
{
    partial class MaterialSelect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonTemporary = new System.Windows.Forms.Button();
            this.buttonSurgicalGuide = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCrCo = new System.Windows.Forms.Button();
            this.ComboboxLab = new System.Windows.Forms.ComboBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.comboBoxManuStatus = new System.Windows.Forms.ComboBox();
            this.textBoxReason = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTemporary
            // 
            this.buttonTemporary.Location = new System.Drawing.Point(9, 37);
            this.buttonTemporary.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTemporary.Name = "buttonTemporary";
            this.buttonTemporary.Size = new System.Drawing.Size(111, 24);
            this.buttonTemporary.TabIndex = 1;
            this.buttonTemporary.Text = "Răng tạm";
            this.buttonTemporary.UseVisualStyleBackColor = true;
            this.buttonTemporary.Click += new System.EventHandler(this.buttonTemporary_Click);
            // 
            // buttonSurgicalGuide
            // 
            this.buttonSurgicalGuide.Location = new System.Drawing.Point(124, 37);
            this.buttonSurgicalGuide.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSurgicalGuide.Name = "buttonSurgicalGuide";
            this.buttonSurgicalGuide.Size = new System.Drawing.Size(147, 24);
            this.buttonSurgicalGuide.TabIndex = 2;
            this.buttonSurgicalGuide.Text = "Máng HDPT";
            this.buttonSurgicalGuide.UseVisualStyleBackColor = true;
            this.buttonSurgicalGuide.Click += new System.EventHandler(this.buttonSurgicalGuide_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn vật liệu";
            // 
            // buttonCrCo
            // 
            this.buttonCrCo.Location = new System.Drawing.Point(278, 37);
            this.buttonCrCo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCrCo.Name = "buttonCrCo";
            this.buttonCrCo.Size = new System.Drawing.Size(109, 24);
            this.buttonCrCo.TabIndex = 5;
            this.buttonCrCo.Text = "Cr-Co";
            this.buttonCrCo.UseVisualStyleBackColor = true;
            this.buttonCrCo.Click += new System.EventHandler(this.buttonCrCo_Click);
            // 
            // ComboboxLab
            // 
            this.ComboboxLab.FormattingEnabled = true;
            this.ComboboxLab.Location = new System.Drawing.Point(109, 77);
            this.ComboboxLab.Name = "ComboboxLab";
            this.ComboboxLab.Size = new System.Drawing.Size(198, 21);
            this.ComboboxLab.TabIndex = 6;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(344, 75);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(50, 23);
            this.ButtonAdd.TabIndex = 7;
            this.ButtonAdd.Text = "Thêm";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            // 
            // comboBoxManuStatus
            // 
            this.comboBoxManuStatus.FormattingEnabled = true;
            this.comboBoxManuStatus.Location = new System.Drawing.Point(109, 104);
            this.comboBoxManuStatus.Name = "comboBoxManuStatus";
            this.comboBoxManuStatus.Size = new System.Drawing.Size(278, 21);
            this.comboBoxManuStatus.TabIndex = 8;
            this.comboBoxManuStatus.SelectedValueChanged += new System.EventHandler(this.comboBoxManuStatus_SelectedValueChanged);
            // 
            // textBoxReason
            // 
            this.textBoxReason.Location = new System.Drawing.Point(109, 131);
            this.textBoxReason.Name = "textBoxReason";
            this.textBoxReason.Size = new System.Drawing.Size(278, 20);
            this.textBoxReason.TabIndex = 9;
            this.textBoxReason.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mô tả trạng thái";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Trạng thái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Gia công ngoài";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(313, 75);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(25, 23);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "X";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // MaterialSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 173);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxReason);
            this.Controls.Add(this.comboBoxManuStatus);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ComboboxLab);
            this.Controls.Add(this.buttonCrCo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSurgicalGuide);
            this.Controls.Add(this.buttonTemporary);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MaterialSelect";
            this.Text = "MaterialSelect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTemporary;
        private System.Windows.Forms.Button buttonSurgicalGuide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCrCo;
        private System.Windows.Forms.ComboBox ComboboxLab;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.ComboBox comboBoxManuStatus;
        private System.Windows.Forms.TextBox textBoxReason;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonClear;
    }
}