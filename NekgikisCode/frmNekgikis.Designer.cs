
namespace NekgikisCode
{
    partial class frmNekgikis
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
            this.labelTitleMessage = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelTitleNumbers = new System.Windows.Forms.Label();
            this.labelNumbers = new System.Windows.Forms.Label();
            this.btnDecode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitleMessage
            // 
            this.labelTitleMessage.AutoSize = true;
            this.labelTitleMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleMessage.Location = new System.Drawing.Point(254, 40);
            this.labelTitleMessage.Name = "labelTitleMessage";
            this.labelTitleMessage.Size = new System.Drawing.Size(100, 25);
            this.labelTitleMessage.TabIndex = 0;
            this.labelTitleMessage.Text = "Message";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.Location = new System.Drawing.Point(157, 90);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(320, 25);
            this.labelMessage.TabIndex = 1;
            this.labelMessage.Text = "Cómo será dar con Nekgikis V...";
            // 
            // labelTitleNumbers
            // 
            this.labelTitleNumbers.AutoSize = true;
            this.labelTitleNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleNumbers.Location = new System.Drawing.Point(230, 178);
            this.labelTitleNumbers.Name = "labelTitleNumbers";
            this.labelTitleNumbers.Size = new System.Drawing.Size(151, 25);
            this.labelTitleNumbers.TabIndex = 2;
            this.labelTitleNumbers.Text = "Number series";
            // 
            // labelNumbers
            // 
            this.labelNumbers.AutoSize = true;
            this.labelNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumbers.Location = new System.Drawing.Point(35, 231);
            this.labelNumbers.Name = "labelNumbers";
            this.labelNumbers.Size = new System.Drawing.Size(587, 20);
            this.labelNumbers.TabIndex = 3;
            this.labelNumbers.Text = "23, 24, 25, 18, 19, 5, 6, 7, 20, 15, 17, 8, 10, 11, 4, 3, 12, 2, 16, 14, 9, 21, 0" +
    ", 1, 13, 22";
            // 
            // btnDecode
            // 
            this.btnDecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecode.Location = new System.Drawing.Point(235, 322);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(135, 64);
            this.btnDecode.TabIndex = 4;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // frmNekgikis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.labelNumbers);
            this.Controls.Add(this.labelTitleNumbers);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.labelTitleMessage);
            this.Name = "frmNekgikis";
            this.Text = "frmNekgikis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitleMessage;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelTitleNumbers;
        private System.Windows.Forms.Label labelNumbers;
        private System.Windows.Forms.Button btnDecode;
    }
}

