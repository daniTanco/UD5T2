using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;

namespace UD5T2.MVVM.Models
{
    public class BMI : INotifyPropertyChanged
    {
        public float altura;
        public float peso;

        public float Altura
        {
            set { altura = value;
                NotifyPropertyChanged(nameof(Altura));
                NotifyPropertyChanged(nameof(Resultado));
                NotifyPropertyChanged(nameof(ResultadoBMI));

            }
            get { return altura; }
        }

        public float Peso
        {
            set { peso = value;
                NotifyPropertyChanged(nameof(Peso));
                NotifyPropertyChanged(nameof(Resultado));
                NotifyPropertyChanged(nameof(ResultadoBMI));
            }
            get { return peso; }
        }

        public float Resultado
        {
            get { return (peso / (altura * altura)) * 10000; }
        }

        public string ResultadoBMI
        {
            get
            {
                float resultado = Resultado;

                if (resultado <= 16)
                    return "BMI: Delgado Severo";
                else if (resultado <= 17)
                    return "BMI: Delgado Moderado";
                else if (resultado <= 18.5)
                    return "BMI: Delgado Medio";
                else if (resultado <= 25)
                    return "BMI: Normal";
                else if (resultado <= 30)
                    return "BMI: Sobrepeso";
                else if (resultado <= 35)
                    return "BMI: Obesidad Clase I";
                else if (resultado <= 40)
                    return "BMI: Obesidad Clase II";
                else
                    return "BMI: Obesidad Clase III";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
