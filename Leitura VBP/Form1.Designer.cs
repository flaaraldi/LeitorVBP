namespace Leitura_VBP
{
    partial class Form1
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
            this.txtLocalizar = new System.Windows.Forms.TextBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSubstituir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tbnExport = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.gcPrinc = new DevExpress.XtraGrid.GridControl();
            this.gvPrinc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPrinc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrinc)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLocalizar
            // 
            this.txtLocalizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocalizar.Location = new System.Drawing.Point(9, 25);
            this.txtLocalizar.Multiline = true;
            this.txtLocalizar.Name = "txtLocalizar";
            this.txtLocalizar.Size = new System.Drawing.Size(513, 102);
            this.txtLocalizar.TabIndex = 0;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Abrir Arquivo VBP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSubstituir
            // 
            this.txtSubstituir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubstituir.Location = new System.Drawing.Point(9, 152);
            this.txtSubstituir.Multiline = true;
            this.txtSubstituir.Name = "txtSubstituir";
            this.txtSubstituir.Size = new System.Drawing.Size(513, 102);
            this.txtSubstituir.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Localizar : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Substituir Por : ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(417, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Substituir nos Arquivos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbnExport
            // 
            this.tbnExport.Location = new System.Drawing.Point(135, 12);
            this.tbnExport.Name = "tbnExport";
            this.tbnExport.Size = new System.Drawing.Size(75, 23);
            this.tbnExport.TabIndex = 8;
            this.tbnExport.Text = "Exportar";
            this.tbnExport.UseVisualStyleBackColor = true;
            this.tbnExport.Click += new System.EventHandler(this.tbnExport_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.gcPrinc);
            this.panel1.Controls.Add(this.txtSubstituir);
            this.panel1.Controls.Add(this.txtLocalizar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(33, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 292);
            this.panel1.TabIndex = 9;
            this.panel1.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(447, 260);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Aplicar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gcPrinc
            // 
            this.gcPrinc.Location = new System.Drawing.Point(-21, 200);
            this.gcPrinc.MainView = this.gvPrinc;
            this.gcPrinc.Name = "gcPrinc";
            this.gcPrinc.Size = new System.Drawing.Size(400, 200);
            this.gcPrinc.TabIndex = 10;
            this.gcPrinc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPrinc});
            // 
            // gvPrinc
            // 
            this.gvPrinc.GridControl = this.gcPrinc;
            this.gvPrinc.Name = "gvPrinc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 444);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbnExport);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPrinc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrinc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtLocalizar;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSubstituir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button tbnExport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private DevExpress.XtraGrid.GridControl gcPrinc;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPrinc;
    }
}

