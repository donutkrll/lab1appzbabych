namespace Lab1WinFormsApp
{
    partial class Form1
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
            myCustomControl1 = new Lab1ControlLibrary.MyCustomControl();
            SuspendLayout();
            // 
            // myCustomControl1
            // 
            myCustomControl1.Font = new Font("Segoe UI", 16F);
            myCustomControl1.ForeColor = Color.Red;
            myCustomControl1.InvalidValueColor = Color.Red;
            myCustomControl1.Location = new Point(81, 121);
            myCustomControl1.Name = "myCustomControl1";
            myCustomControl1.Size = new Size(234, 36);
            myCustomControl1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 380);
            Controls.Add(myCustomControl1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Lab1ControlLibrary.MyCustomControl myCustomControl1;
    }
}
