using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandPatternExample
{
    public partial class Form1 : Form
    {

        public interface ICommand
        {
            void Execute();
        }
        public class LabelReceiver
        {
            private Label _label;
            public LabelReceiver(Label label)
            {
                _label = label;
            }
            public void ChangeText(string text)
            {
                _label.Text = text;
            }
            public void ChangeColor(Color color)
            {
                _label.BackColor = color;
            }
        }

        public class ChangeTextCommand : ICommand
        {
            private LabelReceiver _receiver;
            private string _text;

            public ChangeTextCommand(LabelReceiver receiver, string text)
            {
                _receiver = receiver;
                _text = text;
            }

            public void Execute()
            {
                _receiver.ChangeText(_text);
            }
        }

        public class ChangeColorCommand : ICommand
        {
            private LabelReceiver _receiver;
            private Color _color;

            public ChangeColorCommand(LabelReceiver receiver, Color color)
            {
                _receiver = receiver;
                _color = color;
            }

            public void Execute()
            {
                _receiver.ChangeColor(_color);
            }
        }

        public class ButtonInvoker
        {
            private ICommand _command;

            public void SetCommand(ICommand command)
            {
                _command = command;
            }

            public void ExecuteCommand()
            {
                _command?.Execute();
            }
        }


        private ButtonInvoker _invoker = new ButtonInvoker();
        private LabelReceiver _labelReceiver;

        public Form1()
        {
            InitializeComponent();
            _labelReceiver = new LabelReceiver(label1);
        }

        private void BtnChangeText_Click(object sender, EventArgs e)
        {
            var textCommand = new ChangeTextCommand(_labelReceiver, "Hello Command Pattern!");
            _invoker.SetCommand(textCommand);
            _invoker.ExecuteCommand();
        }

        private void BtnChangeColor_Click(object sender, EventArgs e)
        {
            var colorCommand = new ChangeColorCommand(_labelReceiver, Color.LightBlue);
            _invoker.SetCommand(colorCommand);
            _invoker.ExecuteCommand();
        }
    }
}
