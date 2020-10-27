namespace CaesarCipher
{
    partial class CaesarCipher
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
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.caesarEncrypt = new System.Windows.Forms.TextBox();
            this.caesarDecrypt = new System.Windows.Forms.TextBox();
            this.key = new System.Windows.Forms.TextBox();
            this.tryDecode = new System.Windows.Forms.Button();
            this.bruteForce = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // caesarEncrypt
            // 
            this.caesarEncrypt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.caesarEncrypt.Location = new System.Drawing.Point(18, 10);
            this.caesarEncrypt.Margin = new System.Windows.Forms.Padding(0);
            this.caesarEncrypt.Multiline = true;
            this.caesarEncrypt.Name = "caesarEncrypt";
            this.caesarEncrypt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.caesarEncrypt.Size = new System.Drawing.Size(350, 100);
            this.caesarEncrypt.TabIndex = 2;
            this.caesarEncrypt.TextChanged += new System.EventHandler(this.encrypt_textChanged);
            // 
            // caesarDecrypt
            // 
            this.caesarDecrypt.Location = new System.Drawing.Point(18, 150);
            this.caesarDecrypt.Multiline = true;
            this.caesarDecrypt.Name = "caesarDecrypt";
            this.caesarDecrypt.Size = new System.Drawing.Size(350, 100);
            this.caesarDecrypt.TabIndex = 3;
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(150, 120);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(100, 20);
            this.key.TabIndex = 4;
            this.key.Text = "1";
            this.key.TextChanged += new System.EventHandler(this.key_textChanged);
            // 
            // tryDecode
            // 
            this.tryDecode.Location = new System.Drawing.Point(18, 120);
            this.tryDecode.Name = "tryDecode";
            this.tryDecode.Size = new System.Drawing.Size(75, 20);
            this.tryDecode.TabIndex = 5;
            this.tryDecode.Text = "Try Decode";
            this.tryDecode.UseVisualStyleBackColor = true;
            this.tryDecode.Click += new System.EventHandler(this.tryDecode_Click);
            // 
            // bruteForce
            // 
            this.bruteForce.Location = new System.Drawing.Point(293, 120);
            this.bruteForce.Name = "bruteForce";
            this.bruteForce.Size = new System.Drawing.Size(75, 20);
            this.bruteForce.TabIndex = 6;
            this.bruteForce.Text = "Brute-Force";
            this.bruteForce.UseVisualStyleBackColor = true;
            this.bruteForce.Click += new System.EventHandler(this.bruteForce_Click);
            // 
            // CaesarCipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.bruteForce);
            this.Controls.Add(this.tryDecode);
            this.Controls.Add(this.key);
            this.Controls.Add(this.caesarDecrypt);
            this.Controls.Add(this.caesarEncrypt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "CaesarCipher";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Szyfr Cezara";
            this.Load += new System.EventHandler(this.EncDecForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox caesarEncrypt;
        private System.Windows.Forms.TextBox caesarDecrypt;
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.Button tryDecode;
        private System.Windows.Forms.Button bruteForce;
    }
}

