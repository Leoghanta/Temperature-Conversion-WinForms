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


        public void ConvertCelsius()
        {
            _fahrenheit =  Math.Round((Celsius * 9 / 5) + 32, 2);
            _kelvin = Math.Round(Celsius + 273.15);
        }

        public void ConvertFahrenheit()
        {
            _celsius = Math.Round((Fahrenheit - 32) * 5 / 9, 2) ;
            _kelvin = Math.Round((Fahrenheit - 32) * 5 / 9 + 273.15);
        }

        public void ConvertKelvin()
        {
            _fahrenheit = (Kelvin - 273.15) * 9 / 5 + 32;
            _celsius = Kelvin - 273.15;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string property)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
