namespace hurricane
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
            this.enterbtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.resultslbl = new System.Windows.Forms.Label();
            this.windSpeedtxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enterbtn
            // 
            this.enterbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterbtn.Location = new System.Drawing.Point(64, 132);
            this.enterbtn.Name = "enterbtn";
            this.enterbtn.Size = new System.Drawing.Size(87, 23);
            this.enterbtn.TabIndex = 1;
            this.enterbtn.Text = "Enter";
            this.enterbtn.UseVisualStyleBackColor = true;
            this.enterbtn.Click += new System.EventHandler(this.enterbtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(209, 132);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(87, 23);
            this.clearbtn.TabIndex = 2;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Wind Speed:";
            // 
            // resultslbl
            // 
            this.resultslbl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.resultslbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultslbl.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultslbl.Location = new System.Drawing.Point(64, 180);
            this.resultslbl.Name = "resultslbl";
            this.resultslbl.Size = new System.Drawing.Size(232, 55);
            this.resultslbl.TabIndex = 3;
            // 
            // windSpeedtxt
            // 
            this.windSpeedtxt.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windSpeedtxt.Location = new System.Drawing.Point(196, 61);
            this.windSpeedtxt.Name = "windSpeedtxt";
            this.windSpeedtxt.Size = new System.Drawing.Size(100, 25);
            this.windSpeedtxt.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::hurricane.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(371, 330);
            this.Controls.Add(this.windSpeedtxt);
            this.Controls.Add(this.resultslbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.enterbtn);
            this.Name = "Form1";
            this.Text = "Hurricane Detector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterbtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultslbl;
        private System.Windows.Forms.TextBox windSpeedtxt;
    }
}

