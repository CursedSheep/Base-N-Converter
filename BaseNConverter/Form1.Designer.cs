namespace BaseNConverter
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
            this.FormulaTxt = new System.Windows.Forms.RichTextBox();
            this.SecondValue = new System.Windows.Forms.TextBox();
            this.FirstValue = new System.Windows.Forms.TextBox();
            this.SwapValue = new System.Windows.Forms.Button();
            this.secondBaseN = new System.Windows.Forms.NumericUpDown();
            this.firstBaseN = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.secondBaseN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstBaseN)).BeginInit();
            this.SuspendLayout();
            // 
            // FormulaTxt
            // 
            this.FormulaTxt.Location = new System.Drawing.Point(12, 67);
            this.FormulaTxt.Name = "FormulaTxt";
            this.FormulaTxt.Size = new System.Drawing.Size(243, 221);
            this.FormulaTxt.TabIndex = 3;
            this.FormulaTxt.Text = "";
            // 
            // SecondValue
            // 
            this.SecondValue.Location = new System.Drawing.Point(154, 13);
            this.SecondValue.Name = "SecondValue";
            this.SecondValue.Size = new System.Drawing.Size(100, 20);
            this.SecondValue.TabIndex = 8;
            // 
            // FirstValue
            // 
            this.FirstValue.Location = new System.Drawing.Point(11, 13);
            this.FirstValue.Name = "FirstValue";
            this.FirstValue.Size = new System.Drawing.Size(100, 20);
            this.FirstValue.TabIndex = 7;
            this.FirstValue.TextChanged += new System.EventHandler(this.FirstValue_TextChanged);
            // 
            // SwapValue
            // 
            this.SwapValue.Location = new System.Drawing.Point(117, 26);
            this.SwapValue.Name = "SwapValue";
            this.SwapValue.Size = new System.Drawing.Size(31, 23);
            this.SwapValue.TabIndex = 6;
            this.SwapValue.Text = "<->";
            this.SwapValue.UseVisualStyleBackColor = true;
            this.SwapValue.Click += new System.EventHandler(this.SwapValue_Click);
            // 
            // secondBaseN
            // 
            this.secondBaseN.Location = new System.Drawing.Point(154, 39);
            this.secondBaseN.Name = "secondBaseN";
            this.secondBaseN.Size = new System.Drawing.Size(100, 20);
            this.secondBaseN.TabIndex = 10;
            this.secondBaseN.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.secondBaseN.ValueChanged += new System.EventHandler(this.secondBaseN_ValueChanged);
            // 
            // firstBaseN
            // 
            this.firstBaseN.Location = new System.Drawing.Point(11, 39);
            this.firstBaseN.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.firstBaseN.Name = "firstBaseN";
            this.firstBaseN.Size = new System.Drawing.Size(100, 20);
            this.firstBaseN.TabIndex = 11;
            this.firstBaseN.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.firstBaseN.ValueChanged += new System.EventHandler(this.firstBaseN_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 302);
            this.Controls.Add(this.firstBaseN);
            this.Controls.Add(this.secondBaseN);
            this.Controls.Add(this.SecondValue);
            this.Controls.Add(this.FirstValue);
            this.Controls.Add(this.SwapValue);
            this.Controls.Add(this.FormulaTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "BaseN Converter";
            ((System.ComponentModel.ISupportInitialize)(this.secondBaseN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstBaseN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox FormulaTxt;
        private System.Windows.Forms.TextBox SecondValue;
        private System.Windows.Forms.TextBox FirstValue;
        private System.Windows.Forms.Button SwapValue;
        private System.Windows.Forms.NumericUpDown secondBaseN;
        private System.Windows.Forms.NumericUpDown firstBaseN;
    }
}

