using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_Conversion
{
    public partial class Form1 : Form
    {
        TemperatureConversion tempconvert = new TemperatureConversion();

        public Form1()
        {
            InitializeComponent();
            //Set up the data bindings.
            //new binding ("property changing", object, "object property", formatting (false), data source update mode)
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            CelsiusTextBox.DataBindings.Add(new Binding("Text", tempconvert, "Celsius", false, DataSourceUpdateMode.OnPropertyChanged));
            FahrenheitTextBox.DataBindings.Add(new Binding("Text", tempconvert, "Fahrenheit", false, DataSourceUpdateMode.OnPropertyChanged));
            KelvinTextBox.DataBindings.Add(new Binding("Text", tempconvert, "Kelvin", false, DataSourceUpdateMode.OnPropertyChanged));
        }
    }
}
