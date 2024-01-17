using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Conversion
{
    internal class TemperatureConversion: INotifyPropertyChanged
    {
        /// <summary>
        /// Variables for Celsius Temperature
        /// </summary>
        private double _celsius = 0;
        public double Celsius
        {
            get { return _celsius; }
            set { 
                _celsius = value;
                OnPropertyChanged("Celcius");
                ConvertCelsius();
            }
        }

        /// <summary>
        /// Temperature for Fahrenheit Temperatures
        /// </summary>
        private double _fahrenheit = 0;
        public double Fahrenheit
        {
            get { return _fahrenheit;}
            set { 
                _fahrenheit = value;
                OnPropertyChanged("Fahrenheit");
                ConvertFahrenheit();
            }
        }

        /// <summary>
        /// Variables for Kelvin Temperatures
        /// </summary>
        private double _kelvin = 0;
        public double Kelvin
        {
            get { return _kelvin; }
            set
            {
                _kelvin = value;
                OnPropertyChanged("Kelvin");
                ConvertKelvin();
            }
        }


        /// <summary>
        /// Calculate fahrenheit and kelvin when Celsius has changed
        /// </summary>
        public void ConvertCelsius()
        {
            _fahrenheit =  Math.Round((Celsius * 9 / 5) + 32, 2);
            _kelvin = Math.Round(Celsius + 273.15);
        }

        /// <summary>
        /// Calculate Celsius and Kelvin when Fahrenheit has changed
        /// </summary>
        public void ConvertFahrenheit()
        {
            _celsius = Math.Round((Fahrenheit - 32) * 5 / 9, 2) ;
            _kelvin = Math.Round((Fahrenheit - 32) * 5 / 9 + 273.15);
        }

        /// <summary>
        /// Calculate Fahrenheit and Celsius when Kelvin has changed
        /// </summary>
        public void ConvertKelvin()
        {
            _fahrenheit = (Kelvin - 273.15) * 9 / 5 + 32;
            _celsius = Kelvin - 273.15;
        }

        /// <summary>
        /// Create event handler for property changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// When a property has changed, Broadcast this to the whole program. 
        /// </summary>
        /// <param name="property">String name of the property that changed.</param>
        public void OnPropertyChanged(string property)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
