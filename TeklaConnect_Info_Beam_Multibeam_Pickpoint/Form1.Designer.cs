namespace TeklaConnect
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnBeam = new System.Windows.Forms.Button();
            this.btnBeamPP = new System.Windows.Forms.Button();
            this.btnMBeam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 13);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(103, 39);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(121, 39);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(25, 13);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Info";
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(12, 58);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(103, 39);
            this.btnInfo.TabIndex = 2;
            this.btnInfo.Text = "Get Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnBeam
            // 
            this.btnBeam.Location = new System.Drawing.Point(12, 103);
            this.btnBeam.Name = "btnBeam";
            this.btnBeam.Size = new System.Drawing.Size(103, 39);
            this.btnBeam.TabIndex = 3;
            this.btnBeam.Text = "Create Beam";
            this.btnBeam.UseVisualStyleBackColor = true;
            this.btnBeam.Click += new System.EventHandler(this.btnBeam_Click);
            // 
            // btnBeamPP
            // 
            this.btnBeamPP.Location = new System.Drawing.Point(12, 204);
            this.btnBeamPP.Name = "btnBeamPP";
            this.btnBeamPP.Size = new System.Drawing.Size(148, 39);
            this.btnBeamPP.TabIndex = 4;
            this.btnBeamPP.Text = "Create Beam Pick Points";
            this.btnBeamPP.UseVisualStyleBackColor = true;
            this.btnBeamPP.Click += new System.EventHandler(this.btnBeamPP_Click);
            // 
            // btnMBeam
            // 
            this.btnMBeam.Location = new System.Drawing.Point(12, 148);
            this.btnMBeam.Name = "btnMBeam";
            this.btnMBeam.Size = new System.Drawing.Size(148, 39);
            this.btnMBeam.TabIndex = 5;
            this.btnMBeam.Text = "Create Multiple Beam";
            this.btnMBeam.UseVisualStyleBackColor = true;
            this.btnMBeam.Click += new System.EventHandler(this.btnMBeam_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 292);
            this.Controls.Add(this.btnMBeam);
            this.Controls.Add(this.btnBeamPP);
            this.Controls.Add(this.btnBeam);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tekla";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnBeam;
        private System.Windows.Forms.Button btnBeamPP;
        private System.Windows.Forms.Button btnMBeam;
    }
}

