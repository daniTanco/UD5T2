using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UD5T2.MVVM.Models;

namespace UD5T2.MVVM.ViewModels
{
    class BMIViewModel
    {
        public BMI BMI { get; set; }

        public BMIViewModel()
        {
            BMI = new BMI
            {
                Peso = 50,
                Altura = 25
            };
        }
    }
}
