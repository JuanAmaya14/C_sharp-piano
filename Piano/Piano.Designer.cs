
namespace Piano
{
    partial class Piano
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
            this.Do = new System.Windows.Forms.Button();
            this.Re = new System.Windows.Forms.Button();
            this.Mi = new System.Windows.Forms.Button();
            this.Fa = new System.Windows.Forms.Button();
            this.Sol = new System.Windows.Forms.Button();
            this.La = new System.Windows.Forms.Button();
            this.Si = new System.Windows.Forms.Button();
            this.Do_a = new System.Windows.Forms.Button();
            this.piano_xd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Do
            // 
            this.Do.Location = new System.Drawing.Point(2, 75);
            this.Do.Name = "Do";
            this.Do.Size = new System.Drawing.Size(80, 173);
            this.Do.TabIndex = 0;
            this.Do.Text = "Do";
            this.Do.UseVisualStyleBackColor = true;
            // 
            // Re
            // 
            this.Re.Location = new System.Drawing.Point(79, 75);
            this.Re.Name = "Re";
            this.Re.Size = new System.Drawing.Size(80, 173);
            this.Re.TabIndex = 1;
            this.Re.Text = "Re";
            this.Re.UseVisualStyleBackColor = true;
            // 
            // Mi
            // 
            this.Mi.Location = new System.Drawing.Point(155, 75);
            this.Mi.Name = "Mi";
            this.Mi.Size = new System.Drawing.Size(80, 173);
            this.Mi.TabIndex = 2;
            this.Mi.Text = "Mi";
            this.Mi.UseVisualStyleBackColor = true;
            // 
            // Fa
            // 
            this.Fa.Location = new System.Drawing.Point(232, 75);
            this.Fa.Name = "Fa";
            this.Fa.Size = new System.Drawing.Size(80, 173);
            this.Fa.TabIndex = 3;
            this.Fa.Text = "Fa";
            this.Fa.UseVisualStyleBackColor = true;
            // 
            // Sol
            // 
            this.Sol.Location = new System.Drawing.Point(309, 75);
            this.Sol.Name = "Sol";
            this.Sol.Size = new System.Drawing.Size(80, 173);
            this.Sol.TabIndex = 4;
            this.Sol.Text = "Sol";
            this.Sol.UseVisualStyleBackColor = true;
            // 
            // La
            // 
            this.La.Location = new System.Drawing.Point(385, 75);
            this.La.Name = "La";
            this.La.Size = new System.Drawing.Size(80, 173);
            this.La.TabIndex = 5;
            this.La.Text = "La";
            this.La.UseVisualStyleBackColor = true;
            // 
            // Si
            // 
            this.Si.Location = new System.Drawing.Point(462, 75);
            this.Si.Name = "Si";
            this.Si.Size = new System.Drawing.Size(80, 173);
            this.Si.TabIndex = 6;
            this.Si.Text = "Si";
            this.Si.UseVisualStyleBackColor = true;
            // 
            // Do_a
            // 
            this.Do_a.Location = new System.Drawing.Point(538, 75);
            this.Do_a.Name = "Do_a";
            this.Do_a.Size = new System.Drawing.Size(80, 173);
            this.Do_a.TabIndex = 7;
            this.Do_a.Text = "Do";
            this.Do_a.UseVisualStyleBackColor = true;
            // 
            // piano_xd
            // 
            this.piano_xd.AutoSize = true;
            this.piano_xd.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.piano_xd.ForeColor = System.Drawing.Color.White;
            this.piano_xd.Location = new System.Drawing.Point(242, 20);
            this.piano_xd.Name = "piano_xd";
            this.piano_xd.Size = new System.Drawing.Size(132, 30);
            this.piano_xd.TabIndex = 8;
            this.piano_xd.Text = "Piano xd";
            // 
            // Piano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(619, 245);
            this.Controls.Add(this.piano_xd);
            this.Controls.Add(this.Do_a);
            this.Controls.Add(this.Si);
            this.Controls.Add(this.La);
            this.Controls.Add(this.Sol);
            this.Controls.Add(this.Fa);
            this.Controls.Add(this.Mi);
            this.Controls.Add(this.Re);
            this.Controls.Add(this.Do);
            this.Name = "Piano";
            this.Text = "Piano";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Do;
        private System.Windows.Forms.Button Re;
        private System.Windows.Forms.Button Mi;
        private System.Windows.Forms.Button Fa;
        private System.Windows.Forms.Button Sol;
        private System.Windows.Forms.Button La;
        private System.Windows.Forms.Button Si;
        private System.Windows.Forms.Button Do_a;
        private System.Windows.Forms.Label piano_xd;
    }
}

