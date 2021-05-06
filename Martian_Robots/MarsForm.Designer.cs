namespace Martian_Robots
{
    partial class MarsForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.marsSizebtn = new System.Windows.Forms.Button();
            this.robotsInstructionsbtn = new System.Windows.Forms.Button();
            this.marsSize = new System.Windows.Forms.TextBox();
            this.robotsInstructions = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // marsSizebtn
            // 
            this.marsSizebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marsSizebtn.Location = new System.Drawing.Point(279, 107);
            this.marsSizebtn.Name = "marsSizebtn";
            this.marsSizebtn.Size = new System.Drawing.Size(81, 29);
            this.marsSizebtn.TabIndex = 0;
            this.marsSizebtn.Text = "Create Mars";
            this.marsSizebtn.UseVisualStyleBackColor = true;
            this.marsSizebtn.Click += new System.EventHandler(this.marsSizebtn_Click);
            // 
            // robotsInstructionsbtn
            // 
            this.robotsInstructionsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.robotsInstructionsbtn.Location = new System.Drawing.Point(268, 315);
            this.robotsInstructionsbtn.Name = "robotsInstructionsbtn";
            this.robotsInstructionsbtn.Size = new System.Drawing.Size(118, 26);
            this.robotsInstructionsbtn.TabIndex = 1;
            this.robotsInstructionsbtn.Text = "Send Instructions";
            this.robotsInstructionsbtn.UseVisualStyleBackColor = true;
            this.robotsInstructionsbtn.Click += new System.EventHandler(this.robotsInstructionsbtn_Click);
            // 
            // marsSize
            // 
            this.marsSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marsSize.Location = new System.Drawing.Point(279, 77);
            this.marsSize.Name = "marsSize";
            this.marsSize.Size = new System.Drawing.Size(81, 24);
            this.marsSize.TabIndex = 2;
            // 
            // robotsInstructions
            // 
            this.robotsInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.robotsInstructions.Location = new System.Drawing.Point(227, 167);
            this.robotsInstructions.Multiline = true;
            this.robotsInstructions.Name = "robotsInstructions";
            this.robotsInstructions.Size = new System.Drawing.Size(183, 142);
            this.robotsInstructions.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome Mars!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(404, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Example: \r\n3 2 N";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(441, 208);
            this.label3.MaximumSize = new System.Drawing.Size(300, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 54);
            this.label3.TabIndex = 6;
            this.label3.Text = "Example:\r\n3 2 N\r\nF R R F L L F F R R F L L";
            this.label3.Visible = false;
            // 
            // Mars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 449);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.robotsInstructions);
            this.Controls.Add(this.marsSize);
            this.Controls.Add(this.robotsInstructionsbtn);
            this.Controls.Add(this.marsSizebtn);
            this.Name = "Mars";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button marsSizebtn;
        private System.Windows.Forms.Button robotsInstructionsbtn;
        private System.Windows.Forms.TextBox marsSize;
        private System.Windows.Forms.TextBox robotsInstructions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

