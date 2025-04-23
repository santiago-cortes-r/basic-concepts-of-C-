
Console.WriteLine("Hello, World!");


System.Random random = new System.Random();

Console.WriteLine("Hello, World!");

int compraPlatziCoins = 0;
int platziCoins = 0;
int num = 0;
string message = "";
string switchControl = "menu";
string controladorCarta = "";
int apuesta = 0;
//Blackjack, Juntar 21 pidiendo, en caso de pasarte de 21 pierdes.
//cartas o en caso de tener menos
//de 21 igual tener mayor puntuación que el dealer
while (true)
{
    compraPlatziCoins = 0;
    Console.WriteLine("Welcome al c a s i n o");
    Console.WriteLine($"ingrese cantidad de platziCoins a comprar tu actual es {platziCoins}" );
    compraPlatziCoins = int.Parse(Console.ReadLine());
    platziCoins = platziCoins + compraPlatziCoins;

    for (var i = 0; i < platziCoins; i++)
    {

        int totalJugador = 0;
        int totalDealer = 0;
        Console.Clear();
        switch (switchControl)
        {
            case "menu":
                Console.WriteLine($"Tus platzi coins son: {platziCoins - i}");
                Console.WriteLine("Escriba ‘21’ para jugar al 21");
                switchControl = Console.ReadLine();
                Console.WriteLine("cual es tu apuesta");
                apuesta = int.Parse(Console.ReadLine());
                if (apuesta>platziCoins)
                {
                    Console.WriteLine("platzicoins insuficientes");
                    switchControl = "menu";
                }
           
                i = i-1;
                break;
            case "21":
                do
                {
                    num = random.Next(1, 12);
                    totalJugador = totalJugador + num;
                    Console.WriteLine("Toma tu carta, jugador,");
                    Console.WriteLine($"Te salió el número: {num} ");
                    Console.WriteLine("¿Deseas otra carta ?");
                    controladorCarta = Console.ReadLine();

                } while (controladorCarta == "Si" ||
                         controladorCarta == "si" ||
                         controladorCarta == "yes");

                totalDealer = random.Next(14, 23);
                Console.WriteLine($"El dealer tiene {totalDealer}");

                if (totalJugador > totalDealer && totalJugador < 22)
                {
                    message = "Venciste al dealer, felicidades";
                    i = i-1;
                    platziCoins = platziCoins + apuesta;
                }
                else if (totalJugador >= 22)
                {
                    message = "Perdiste vs el dealer, te pasaste de 21";
                    i = i - 1;
                    platziCoins = platziCoins - apuesta;
                }
                else if (totalJugador <= totalDealer)
                {
                    message = "Perdiste vs el dealer, lo siento";
                    i = i - 1 ;
                    platziCoins = platziCoins - apuesta;

                }
                else
                {
                    message = "condición no válida";
                }
                Console.WriteLine(message);
                Console.WriteLine("Escribe menu para reiniciar o salir para finalizar");
                switchControl = Console.ReadLine( );
                break;
            case "salir":
                Console.WriteLine($"tus creditos son: {platziCoins}");
                i = platziCoins;
                break;
            default:
                Console.WriteLine("Valor ingresa no válido en el  C A S I N O");
                break;
        }
    }
}