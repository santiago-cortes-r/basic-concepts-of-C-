// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!");

// prgrama para hacer nomina 

// el empleado puede trabajar en el dia o en la noche o ambas lo que hace que haya un recargo noctuno
// si el empleado trabaja mas de 8 horas en el dia le corresponde un pago mayo por extras 
//Valor de la hora ordinaria laboral con base en 1 smmlv = $4.936
//Recargo nocturno	35 %	$6.664
//Recargo dominical o festivo	75 %	$8.638, el programa solo se usara en semana asi que el domingo se hara en un programa despues
//Hora extra diurna	25 %	$6.170
//Hora extra nocturna	75 %	$8.638
const double pagoPorHora = 4.935;
const double recargoNocturno = 0.35;
const double horaExtraDiurna = 0.25;
const double horaExtraNocturna = 0.35;
int horaEntrada = 0;
int horaDeEntradaMinutos = 0;
int horaSalida = 0;
int horaDeSalidaMinutos = 0;
float horasTrabajadas = 0;
var sueldoTrabajador = 0.00;








//if (horaDeSalida<6 && horaDeSalida<21)
//{
//    horasTrabajadas = horaDeSalida - horaDeEntrada;
//    Console.WriteLine($"El colaborador trabajo: {horasTrabajadas}");
//    if (horasTrabajadas<=8)
//    {
//        sueldoTrabajador = (horasTrabajadas*pagoPorHora);
//        Console.WriteLine($"Su sueldo del dia es {sueldoTrabajador}");
//    }else if(horasTrabajadas>8) {
//        sueldoTrabajador = ( (horasTrabajadas - 8)*(pagoPorHora *(1+ 0.35) ) ) + (pagoPorHora * 8);
//        Console.WriteLine($"Su sueldo del dia es {sueldoTrabajador}");
//    }
//}

//--------------------------------------------------------------------------------------------------------------

while (true)
{
    int horaEntrada
    Console.WriteLine("hora de entrada? use el la hora en formato 24 solo el entero");
   
    bool horaDeEntradaValida = false;
    while (!horaDeEntradaValida)
    {
        if not (int.TryParse(input, out horaEntrada))
            return Console.WriteLine("⚠ Error: Ingresa un número válido. Inténtalo de nuevo.");

        Console.WriteLine($"Hora ingresada correctamente: {horaEntrada}")
        horaDeEntradaValida = true;
    }
    

    Console.WriteLine("minutos adicionales de la hora entrada?");
    horaDeEntradaMinutos = int.Parse(Console.ReadLine());

    Console.WriteLine("hora de salida? use el la hora en formato 24 ");
    horaSalida = int.Parse(Console.ReadLine());

    Console.WriteLine("minutos adicionales de la hora de salida?");
    horaDeSalidaMinutos = int.Parse(Console.ReadLine());
    
    public 

    if (horaEntrada>=horaSalida)
    {
        horasTrabajadas = (horaSalida + 24) - (horaEntrada+1) ;
    }
    else
    {
        horasTrabajadas = horaSalida - (horaEntrada+1);
    }

    if (horaDeEntradaMinutos == 0)
    {
        horasTrabajadas++;
    }
    else
    {
        horasTrabajadas +=  ((60 - horaDeEntradaMinutos) / 60f);
    }
    
    horasTrabajadas +=  (horaDeSalidaMinutos / 60f);

    // usando el switch, este debe de tener una variable controladora, esta se compara con el valor
    // que le demos al caso pero no se reciben experesiones complejas como condiciones logicas

   
            Console.WriteLine($"El colaborador trabajo: {horasTrabajadas}");
            sueldoTrabajador = (horasTrabajadas * pagoPorHora);
            Console.WriteLine($"Su sueldo del dia es {sueldoTrabajador}");
      
}











