using calcular.Domain.Entities;
using Microsoft.AspNetCore.Mvc;


/* Nombre de la escuela: Universidad Tecnológica Metropolitana
Profesor: Joel Chuc Uc
Materia: Aplicaciones web orientadas a sercivios
Alumna: Ada Nazcais Martin Morales
Grupo: A
Semestre: Cuarto cuatrimestre
Parcial 2
Práctica 2: Crear y desarrollar API'S*/

namespace calcular.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class bandascontroller : ControllerBase
    {
        [HttpGet]
        [Route("calcular")]
        public IActionResult Bandas(string _resc1 ,string _resc2,string _resc3,string _resc4)
        {
            var cal = new colors();
            cal.resist1(_resc1);
            if(_resc1.ToLower() != "negro" && _resc1.ToLower() != "amarillo" && _resc1.ToLower() != "violeta" && _resc1.ToLower() != "naranja" &&_resc1.ToLower() != "blanco" 
            &&_resc1.ToLower() != "azul" && _resc1.ToLower()!= "verde" && _resc1.ToLower() != "rojo" && _resc1.ToLower() != "cafe" && _resc1.ToLower()!= "gris" )
            {
                return Ok( "Error en el color 1 ");
            }
             cal.resist2(_resc2);
            if(_resc2.ToLower() != "negro" && _resc2.ToLower() != "amarillo" && _resc2.ToLower() != "violeta" && _resc2.ToLower() != "naranja" &&_resc2.ToLower() != "blanco" 
            &&_resc2.ToLower() != "azul" && _resc2.ToLower()!= "verde" && _resc2.ToLower() != "rojo" && _resc2.ToLower() != "cafe" && _resc2.ToLower()!= "gris" )
            {
                return Ok("Error en el color 2");
            }
            cal.resist3(_resc3);
            if(_resc3.ToLower() =="violeta" || _resc3.ToLower() =="blanco" ||_resc3.ToLower() =="gris" )
            {
                
                 return Ok(" Error en el color 3");
            }
             cal.resist4(_resc4);
            if( _resc4.ToLower() != "dorado" && _resc4.ToLower() != "plata" )
            {
                return Ok("Error en la bandeja 4 ");
            }
            cal.devuelvemeinformacion();
            return Ok(cal.devuelvemeinformacion());
        }
    }
}