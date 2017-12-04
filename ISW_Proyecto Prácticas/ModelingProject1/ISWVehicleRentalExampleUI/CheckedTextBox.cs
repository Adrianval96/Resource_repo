using System;
using System.Drawing;
using System.Windows.Forms;

namespace GestAcaUI
{
    class CheckedTextBox : UserControl
    {
        public TextBox textBox
        {
            get; set;
        }
        public Label errorLabel
        {
            get; set;
        }

        public delegate string DataCheckFunction(string rawData);

        public DataCheckFunction checkData
        {
            get; set;
        }

        public CheckedTextBox()
        {
            errorLabel = new Label()
            {
                BorderStyle = BorderStyle.Fixed3D,
                Anchor = AnchorStyles.Left,
                AutoSize = true,
                AutoEllipsis = true
            };
            errorLabel.Visible = false;
            errorLabel.Text = "error label";
            textBox = new TextBox()
            {
                BorderStyle = BorderStyle.FixedSingle,
            };
            Control innerContainer = new FlowLayoutPanel()
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(-1),
                FlowDirection = FlowDirection.LeftToRight
            };
            innerContainer.Controls.Add(textBox);
            innerContainer.Controls.Add(errorLabel);
            this.Controls.Add(innerContainer);

            DefaultBorderColor = SystemColors.ControlDark;
            CorrectBorderColor = Color.Green;
            ErrorBorderColor = Color.Red;
            BackColor = DefaultBorderColor;
            //Padding = new Padding(1);
            Size = textBox.Size;
            textBox.TextChanged += new System.EventHandler(this.updateStatus);
        }
        public void updateStatus(object o, EventArgs e)
        {
            string errMsg = checkData(textBox.Text);
            if (errMsg == null)
            {
                BackColor = CorrectBorderColor;
                errorLabel.Visible = false;
            } else if (! textBox.Modified)
            {
                BackColor = DefaultBorderColor;
                errorLabel.Visible = false;
            } else
            {
                BackColor = ErrorBorderColor;
                errorLabel.Visible = true;
                errorLabel.Text = errMsg;
            }
        }

        public Color DefaultBorderColor { get; set; }
        public Color ErrorBorderColor { get; set; }
        public Color CorrectBorderColor { get; set; }

        public override string Text
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }

        protected override void SetBoundsCore(int x, int y,
            int width, int height, BoundsSpecified specified)
        {
            base.SetBoundsCore(x, y, width, textBox.PreferredHeight, specified);
        }
    }
}
