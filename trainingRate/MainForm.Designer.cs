namespace trainingRate
{
    partial class MainForm
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
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblRestingRate = new System.Windows.Forms.Label();
            this.txtRestingRate = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblTrainingRate = new System.Windows.Forms.Label();
            this.txtTrainingRate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAge
            // 
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(80, 53);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(100, 23);
            this.lblAge.TabIndex = 0;
            this.lblAge.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(187, 53);
            this.txtAge.Multiline = true;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 1;
            // 
            // lblRestingRate
            // 
            this.lblRestingRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestingRate.Location = new System.Drawing.Point(80, 91);
            this.lblRestingRate.Name = "lblRestingRate";
            this.lblRestingRate.Size = new System.Drawing.Size(100, 23);
            this.lblRestingRate.TabIndex = 2;
            this.lblRestingRate.Text = "Resting Rate";
            // 
            // txtRestingRate
            // 
            this.txtRestingRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestingRate.Location = new System.Drawing.Point(187, 88);
            this.txtRestingRate.Multiline = true;
            this.txtRestingRate.Name = "txtRestingRate";
            this.txtRestingRate.Size = new System.Drawing.Size(100, 20);
            this.txtRestingRate.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(199, 134);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblTrainingRate
            // 
            this.lblTrainingRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainingRate.Location = new System.Drawing.Point(80, 198);
            this.lblTrainingRate.Name = "lblTrainingRate";
            this.lblTrainingRate.Size = new System.Drawing.Size(100, 23);
            this.lblTrainingRate.TabIndex = 5;
            this.lblTrainingRate.Text = "Training Rate";
            // 
            // txtTrainingRate
            // 
            this.txtTrainingRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrainingRate.Location = new System.Drawing.Point(187, 201);
            this.txtTrainingRate.Multiline = true;
            this.txtTrainingRate.Name = "txtTrainingRate";
            this.txtTrainingRate.Size = new System.Drawing.Size(100, 20);
            this.txtTrainingRate.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTrainingRate);
            this.Controls.Add(this.lblTrainingRate);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtRestingRate);
            this.Controls.Add(this.lblRestingRate);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Name = "MainForm";
            this.Text = "Training Heart Rate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblRestingRate;
        private System.Windows.Forms.TextBox txtRestingRate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblTrainingRate;
        private System.Windows.Forms.TextBox txtTrainingRate;
    }
}

