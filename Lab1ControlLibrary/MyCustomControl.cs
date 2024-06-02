using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab1ControlLibrary
{
    [ToolboxBitmap(@"D:\KHAI\apz\lab1\Lab1Solution\Lab1ControlLibrary\Icon1.ico")]
    public partial class MyCustomControl : TextBox
    {
        public MyCustomControl()
        {
            InitializeComponent();
            this.TextChanged += MyCustomControl_TextChanged;
            this.ForeColor = InvalidValueColor;
        }

        public float FloatValue
        {
            get
            {
                float value;
                if (float.TryParse(this.Text, out value))
                {
                    return value;
                }
                return 0;
            }
        }

        public Color InvalidValueColor { get; set; } = Color.Red;

        public event EventHandler CorrectValueEntered;

        public event EventHandler IncorrectValueEntered;

        private void MyCustomControl_TextChanged(object sender, EventArgs e)
        {
            if (!this.Text.Contains(","))
            {
                this.ForeColor = InvalidValueColor;
                IncorrectValueEntered?.Invoke(this, EventArgs.Empty);
                return;
            }

            float value;
            if (!float.TryParse(this.Text, out value))
            {
                this.ForeColor = InvalidValueColor;
                IncorrectValueEntered?.Invoke(this, EventArgs.Empty);
                return;
            }


            this.ForeColor = Color.Black;
            CorrectValueEntered?.Invoke(this, EventArgs.Empty);
        }
    }
}
