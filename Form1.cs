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
        /// <summary>
        /// Instantise the temperature conversion object
        /// </summary>
        TemperatureConversion tempconvert = new TemperatureConversion();

        /// <summary>
        /// Initialise the Form
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            //Set up the data bindings.
            //new binding ("property changing", object, "object property", formatting (false), data source update mode)
            //}
            InitBindings();
        }

        /// <summary>
        /// Initialise the bindings for the text boxes.
        /// This will listen for a property change and update themselves.
        /// </summary>
        private void InitBindings()
        {
            CelsiusTextBox.DataBindings.Add(new Binding("Text", tempconvert, "Celsius", false, DataSourceUpdateMode.OnPropertyChanged));
            FahrenheitTextBox.DataBindings.Add(new Binding("Text", tempconvert, "Fahrenheit", false, DataSourceUpdateMode.OnPropertyChanged));
            KelvinTextBox.DataBindings.Add(new Binding("Text", tempconvert, "Kelvin", false, DataSourceUpdateMode.OnPropertyChanged));
        }
    }
}
