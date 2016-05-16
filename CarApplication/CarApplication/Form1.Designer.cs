namespace CarApplication
{
    partial class CarApplication
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
            this.lblMake = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblSpeedOutput = new System.Windows.Forms.Label();
            this.btnAccel = new System.Windows.Forms.Button();
            this.btnBrake = new System.Windows.Forms.Button();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblCarOutput = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(82, 68);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(37, 13);
            this.lblMake.TabIndex = 0;
            this.lblMake.Text = "Make:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(87, 45);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(32, 13);
            this.lblYear.TabIndex = 1;
            this.lblYear.Text = "Year:";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(110, 183);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(41, 13);
            this.lblSpeed.TabIndex = 2;
            this.lblSpeed.Text = "Speed:";
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(125, 65);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(100, 20);
            this.txtMake.TabIndex = 3;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(125, 42);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 4;
            // 
            // lblSpeedOutput
            // 
            this.lblSpeedOutput.AutoSize = true;
            this.lblSpeedOutput.Location = new System.Drawing.Point(158, 183);
            this.lblSpeedOutput.Name = "lblSpeedOutput";
            this.lblSpeedOutput.Size = new System.Drawing.Size(0, 13);
            this.lblSpeedOutput.TabIndex = 5;
            // 
            // btnAccel
            // 
            this.btnAccel.Location = new System.Drawing.Point(65, 228);
            this.btnAccel.Name = "btnAccel";
            this.btnAccel.Size = new System.Drawing.Size(75, 23);
            this.btnAccel.TabIndex = 6;
            this.btnAccel.Text = "Accelerate";
            this.btnAccel.UseVisualStyleBackColor = true;
            this.btnAccel.Click += new System.EventHandler(this.btnAccel_Click);
            // 
            // btnBrake
            // 
            this.btnBrake.Location = new System.Drawing.Point(163, 228);
            this.btnBrake.Name = "btnBrake";
            this.btnBrake.Size = new System.Drawing.Size(75, 23);
            this.btnBrake.TabIndex = 7;
            this.btnBrake.Text = "Brake";
            this.btnBrake.UseVisualStyleBackColor = true;
            this.btnBrake.Click += new System.EventHandler(this.btnBrake_Click);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(80, 90);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(39, 13);
            this.lblModel.TabIndex = 8;
            this.lblModel.Text = "Model:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(125, 87);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 9;
            // 
            // lblCarOutput
            // 
            this.lblCarOutput.AutoSize = true;
            this.lblCarOutput.Location = new System.Drawing.Point(125, 167);
            this.lblCarOutput.Name = "lblCarOutput";
            this.lblCarOutput.Size = new System.Drawing.Size(0, 13);
            this.lblCarOutput.TabIndex = 10;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(113, 123);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // CarApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblCarOutput);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.btnBrake);
            this.Controls.Add(this.btnAccel);
            this.Controls.Add(this.lblSpeedOutput);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblMake);
            this.Name = "CarApplication";
            this.Text = "Car Application v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblSpeedOutput;
        private System.Windows.Forms.Button btnAccel;
        private System.Windows.Forms.Button btnBrake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblCarOutput;
        private System.Windows.Forms.Button btnSubmit;
    }
}

