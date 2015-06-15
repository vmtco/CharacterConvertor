namespace Character_Convertor
{
    partial class frmMain
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
            this.Label1 = new System.Windows.Forms.Label();
            this.txtOuput = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.cmbConvertType = new System.Windows.Forms.ComboBox();
            this.btnParse = new System.Windows.Forms.Button();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(140, 44);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(74, 13);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Convert Type:";
            // 
            // txtOuput
            // 
            this.txtOuput.Location = new System.Drawing.Point(12, 72);
            this.txtOuput.Name = "txtOuput";
            this.txtOuput.Size = new System.Drawing.Size(343, 20);
            this.txtOuput.TabIndex = 3;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 9);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(343, 20);
            this.txtInput.TabIndex = 0;
            // 
            // cmbConvertType
            // 
            this.cmbConvertType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConvertType.FormattingEnabled = true;
            this.cmbConvertType.Items.AddRange(new object[] {
            "Decimal",
            "Hex"});
            this.cmbConvertType.Location = new System.Drawing.Point(214, 40);
            this.cmbConvertType.Name = "cmbConvertType";
            this.cmbConvertType.Size = new System.Drawing.Size(141, 21);
            this.cmbConvertType.TabIndex = 2;
            this.cmbConvertType.SelectedIndexChanged += new System.EventHandler(this.cmbConvertType_OnSelectedIndexChanged);
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(12, 39);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(107, 23);
            this.btnParse.TabIndex = 1;
            this.btnParse.Text = "Parse";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_OnClick);
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.ForeColor = System.Drawing.Color.DimGray;
            this.lblCopyright.Location = new System.Drawing.Point(12, 99);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(167, 13);
            this.lblCopyright.TabIndex = 5;
            this.lblCopyright.TabStop = true;
            this.lblCopyright.Text = "© 2015, Vahid Mohammad Taheri";
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnParse;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 121);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtOuput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.cmbConvertType);
            this.Controls.Add(this.btnParse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Character Convertor";
            this.Load += new System.EventHandler(this.frmMain_OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtOuput;
        internal System.Windows.Forms.TextBox txtInput;
        internal System.Windows.Forms.ComboBox cmbConvertType;
        internal System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.Label lblCopyright;
    }
}

