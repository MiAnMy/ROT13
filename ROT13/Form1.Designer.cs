namespace ROT13
{
    partial class ROT13
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.To_ROT13 = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.Value = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // To_ROT13
            // 
            this.To_ROT13.Location = new System.Drawing.Point(66, 38);
            this.To_ROT13.Name = "To_ROT13";
            this.To_ROT13.Size = new System.Drawing.Size(86, 23);
            this.To_ROT13.TabIndex = 0;
            this.To_ROT13.Text = "ROT13";
            this.To_ROT13.UseVisualStyleBackColor = true;
            this.To_ROT13.Click += new System.EventHandler(this.To_ROT13_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(104, 78);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 13);
            this.Result.TabIndex = 2;
            this.Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Value
            // 
            this.Value.Location = new System.Drawing.Point(1, 12);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(209, 20);
            this.Value.TabIndex = 3;
            // 
            // ROT13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 113);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.To_ROT13);
            this.Name = "ROT13";
            this.Text = "ROT13";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button To_ROT13;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.TextBox Value;
    }
}

