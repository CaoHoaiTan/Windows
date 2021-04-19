
namespace Update_Data
{
    partial class Form3
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
            this.lblDM = new System.Windows.Forms.Label();
            this.dgvDANHMUC = new System.Windows.Forms.DataGridView();
            this.btnTroVe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDANHMUC)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDM
            // 
            this.lblDM.AutoSize = true;
            this.lblDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDM.ForeColor = System.Drawing.Color.Red;
            this.lblDM.Location = new System.Drawing.Point(173, 29);
            this.lblDM.Name = "lblDM";
            this.lblDM.Size = new System.Drawing.Size(312, 31);
            this.lblDM.TabIndex = 0;
            this.lblDM.Text = "Danh Mục Khách Hàng";
            // 
            // dgvDANHMUC
            // 
            this.dgvDANHMUC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDANHMUC.Location = new System.Drawing.Point(47, 119);
            this.dgvDANHMUC.Name = "dgvDANHMUC";
            this.dgvDANHMUC.RowHeadersWidth = 51;
            this.dgvDANHMUC.RowTemplate.Height = 24;
            this.dgvDANHMUC.Size = new System.Drawing.Size(503, 231);
            this.dgvDANHMUC.TabIndex = 1;
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(444, 371);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(106, 28);
            this.btnTroVe.TabIndex = 2;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 436);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.dgvDANHMUC);
            this.Controls.Add(this.lblDM);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDANHMUC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDM;
        private System.Windows.Forms.DataGridView dgvDANHMUC;
        private System.Windows.Forms.Button btnTroVe;
    }
}