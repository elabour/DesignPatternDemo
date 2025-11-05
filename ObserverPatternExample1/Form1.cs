using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;


namespace ObserverPatternExample1
{
   

    public partial class Form1 : Form
    {
        public interface IObserver
        {
            void Update(float temperature);
        }

        public interface ISubject
        {
            void RegisterObserver(IObserver observer);
            void RemoveObserver(IObserver observer);
            void NotifyObservers();
        }

        public class WeatherStation : ISubject
        {
            private List<IObserver> observers = new List<IObserver>();
            private float temperature;

            public void SetTemperature(float temp)
            {
                temperature = temp;
                NotifyObservers();
            }

            public void RegisterObserver(IObserver observer) => observers.Add(observer);
            public void RemoveObserver(IObserver observer) => observers.Remove(observer);

            public void NotifyObservers()
            {
                foreach (var observer in observers)
                {
                    observer.Update(temperature);
                }
            }
        }

        public class LabelDisplay : IObserver
        {
            private Label _label;
            private string _name;

            public LabelDisplay(Label label, string name)
            {
                _label = label;
                _name = name;
            }

            public void Update(float temperature)
            {
                _label.Text = $"{_name}: {temperature} °C";
            }
        }


        private WeatherStation station;
        public Form1()
        {
            InitializeComponent();
            station = new WeatherStation();

            // Observers
            var display1 = new LabelDisplay(label1, "Display 1");
            var display2 = new LabelDisplay(label2, "Display 2");

            // Register Observers
            station.RegisterObserver(display1);
            station.RegisterObserver(display2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSetTemp_Click(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxTemp.Text, out float temp))
            {
                station.SetTemperature(temp);
            }
            else
            {
                MessageBox.Show("Enter a valid number!");
            }
        }
    }
}
