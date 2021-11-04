using calcular.Domain.Interface;
using System;
namespace calcular.Domain.Entities
{
    public class colors :Icalculos
    {
        private string _resc1,_resc2,_resc3,_resc4,valor1,valor2,_Result;
        private int valor = 0;
        public double multi = 0.0;
        public double _Result2 = 0.0;

        public double _Result3 = 0.0;
        public double mayor=0.0;
        public double menor=0.0;

        public void resist1(string resc1)
        {
            _resc1 = resc1.ToLower();
            switch(_resc1){
                case "negro":
                valor1="0";
                break;
                case "cafe":
                valor1 = "1";
                break;
                case "rojo":
                valor1 = "2";
                break;
                case "naranja":
                valor1 = "3";
                break;
                case "amarillo":
                valor1 = "4";
                break;
                case "verde":
                valor1 = "5";
                break;
                case "azul":
                valor1= "6";
                break;
                case "violeta":
                valor1 = "7";
                break;
                case "gris":
                valor1 = "8";
                break;
                case "blanco":
                valor1 = "9";
                break;
        }
        }

        public void resist2(string resc2)
        {
           _resc2 = resc2.ToLower();
            switch(_resc2){
                case "negro":
                valor2="0";
                _Result = valor1 + valor2;
                valor = int.Parse(_Result);
                break;
                case "cafe":
                valor2 = "1";
                _Result = valor1 + valor2;
                valor = int.Parse(_Result);
                break;
                case "rojo":
                valor2 = "2";
                _Result = valor1 + valor2;
                valor = int.Parse(_Result);
                break;
                case "naranja":
                valor2 = "3";
                _Result = valor1 + valor2;
                valor = int.Parse(_Result);
                break;
                case "amarillo":
                valor2 = "4";
                _Result= valor1 + valor2;
                valor = int.Parse(_Result);
                break;
                case "verde":
                valor2 = "5";
                _Result= valor1 + valor2;
                valor = int.Parse(_Result);
                break;
                case "azul":
                valor2 = "6";
                _Result = valor1 + valor1;
                valor = int.Parse(_Result);
                break;
                case "violeta":
                valor2 = "7";
                _Result = valor1 + valor2;
                valor = int.Parse(_Result);
                break;
                case "gris":
                valor2 = "8";
                _Result= valor1 + valor2;
                valor = int.Parse(_Result);
                break;
                case "blanco":
                valor2 = "9";
                _Result = valor1 + valor2;
                valor = int.Parse(_Result);
                break; 
        }
        }

        public void resist3(string resc3)
        {
            _resc3 = resc3.ToLower();
            switch(_resc3){
                case "negro":
                _Result2 = 1;
                multi = valor * _Result2;
                break;
                case "cafe":
                _Result2 = 10;
                multi = valor * _Result2;
                break;
                case "rojo":
                _Result2 = 100;
                multi = valor * _Result2;
                break;
                case "naranja":
                _Result2 = 1000;
                multi = valor * _Result2;
                break;
                case "amarillo":
                _Result2 = 10000;
                multi = valor * _Result2;
                break;
                case "verde":
                _Result2 = 100000;
                multi = valor * _Result2;
                break;
                case "azul":
                _Result2 = 1000000;
                multi = valor * _Result2;
                break;
                case "violeta":
                _Result2 = 10000000;
                multi = valor * _Result2;
                break;
                case "gris":
                _Result2 = 100000000;
                multi = valor * _Result2;
                break;
                case "blanco":
                _Result2 = 1000000000;
                multi = valor * _Result2;
                break;
        }
        }

        public void resist4(string resc4)
        {
            _resc4 = resc4.ToLower();
                       
                if(_resc4 == "dorado"){
                _Result3 = (multi * 5)/100;   
                }
                if(_resc4 == "plata"){
                 _Result3 = (multi * 10)/100;
                }
    
            
         mayor= multi + _Result3;
         menor= multi - _Result3;  
        }
    

        public string devuelvemeinformacion()
        {
            return $"Su valor de la resitencia será {multi} y la tolerancia será {_Result3} El rango mayo de la tolerancia será{mayor} El rango menor de la tolerancia será {menor} ";
        }

        }
    }
