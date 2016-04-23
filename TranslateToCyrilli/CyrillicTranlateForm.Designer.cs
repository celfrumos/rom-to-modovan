namespace TranslateToCyrillic
{
    partial class ConvertForm
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
            this.btnConvert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxConverted = new System.Windows.Forms.RichTextBox();
            this.txtBoxInput = new System.Windows.Forms.RichTextBox();
            this.txtBoxOriginal = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(156, 419);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(122, 39);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Original";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cyrillic";
            // 
            // txtBoxConverted
            // 
            this.txtBoxConverted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxConverted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxConverted.Location = new System.Drawing.Point(113, 283);
            this.txtBoxConverted.Name = "txtBoxConverted";
            this.txtBoxConverted.ReadOnly = true;
            this.txtBoxConverted.Size = new System.Drawing.Size(496, 114);
            this.txtBoxConverted.TabIndex = 5;
            this.txtBoxConverted.Text = "";
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxInput.Location = new System.Drawing.Point(113, 23);
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.Size = new System.Drawing.Size(496, 114);
            this.txtBoxInput.TabIndex = 0;
            this.txtBoxInput.Text = "";
            // 
            // txtBoxOriginal
            // 
            this.txtBoxOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxOriginal.Location = new System.Drawing.Point(113, 153);
            this.txtBoxOriginal.Name = "txtBoxOriginal";
            this.txtBoxOriginal.ReadOnly = true;
            this.txtBoxOriginal.Size = new System.Drawing.Size(496, 114);
            this.txtBoxOriginal.TabIndex = 5;
            this.txtBoxOriginal.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Text";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(428, 419);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 39);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ConvertForm
            // 
            this.AcceptButton = this.btnConvert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 484);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtBoxInput);
            this.Controls.Add(this.txtBoxOriginal);
            this.Controls.Add(this.txtBoxConverted);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConvert);
            this.Name = "ConvertForm";
            this.Text = "Cyrillinator 5000";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtBoxConverted;
        private System.Windows.Forms.RichTextBox txtBoxInput;
        private System.Windows.Forms.RichTextBox txtBoxOriginal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
    }
}

