using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragControlsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<TextBox> aTextLst = new List<TextBox>();
        List<Label> aLabelLst = new List<Label>();
        List<Button> aButtonLst = new List<Button>();

        int countTextBox = 0;
        int countLabel = 0;
        int countButton = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            ControlExtension.Draggable(button1, true);

            foreach (TextBox item in aTextLst)
            {
                ControlExtension.Draggable(item, true);
            }

            foreach (Label item in aLabelLst)
            {
                ControlExtension.Draggable(item, true);
            }

            foreach (Button item in aButtonLst)
            {
                ControlExtension.Draggable(item, true);
            }

            ControlExtension.Draggable(MyPanel, false);
            ControlExtension.Draggable(textBox1, false);
            ControlExtension.Draggable(button1, false);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            countButton++;

            Button aButton = new Button();
            aButton.Name = "Button" + countTextBox;
            aButton.Text = "Your Custom Button";
            aButton.Font = new Font("Arial", 6, FontStyle.Bold);
            aButton.AutoSize = true;

            aButtonLst.Add(aButton);

            foreach (Button item in aButtonLst)
            {
                MyPanel.Controls.Add(item);
                ControlExtension.Draggable(item, true);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            countTextBox++;

            TextBox aTextBox = new TextBox();
            aTextBox.Name = "Text" + countTextBox;
            aTextBox.Text = "Your Custom TextBox";
            aTextBox.Font = new Font("Arial", 6, FontStyle.Bold);
            aTextBox.AutoSize = true;
            aTextBox.Multiline = true; 

            aTextLst.Add(aTextBox);

            foreach (TextBox item in aTextLst)
            {
                MyPanel.Controls.Add(item);
                ControlExtension.Draggable(item, true);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            countLabel++;

            Label aLabel = new Label();
            aLabel.Name = "Text" + countLabel;
            aLabel.Text = "Your Custom Label";
            aLabel.Font = new Font("Arial", 6, FontStyle.Bold);

            aLabelLst.Add(aLabel);

            foreach (Label item in aLabelLst)
            {
                MyPanel.Controls.Add(item);
                ControlExtension.Draggable(item, true);
            }
        }
    }
}
