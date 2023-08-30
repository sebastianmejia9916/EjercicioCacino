//EJEMPLO CONDICIONAL IF
//JUEGO BLACKJACK
//llegar a 21 puntos pidiendo cartas o en caso de tener menos
//sacar mas puntuacion que el dealer sin pasarte de 21
//Console.WriteLine("Hello, World!");
int totalJugador = 0;
int totalDealer = 0;
int numero= 0;
int apuesta = 0;
int monedas = 0;
bool puedeApostar;
int monedasRestantes = 0;
string seguirApostando;
string message = "";
string controlOtraCarta = "";
string switchControl;

System.Random random = new System.Random();

do
{
    Console.WriteLine("BIENVENIDO AL * C A S I N O * ");
    Console.WriteLine("¿* CUANTAS MONEDAS DESEA COMPRAR? *");
    monedas = int.Parse(Console.ReadLine());
    monedas = monedas + monedasRestantes;
    Console.WriteLine("BIENVENIDO AL JUEGO BLACKJACK");


    do
    {
        do
        {
            totalJugador = 0;
            totalDealer = 0;
            Console.WriteLine(" ACABAS DE COMPRAR : "  + monedas +  " MONEDAS ");
            Console.WriteLine("***¿CUANTAS DESEAS APOSTAR?***");
            apuesta = int.Parse(Console.ReadLine());
            if (apuesta > monedas)
            {
                Console.WriteLine($"!!!NO TIENES SUFICIENTES MONEDAS PARA JUGAR BLACKJACK, LO SIENTO !!!");
                puedeApostar = false;
               
            }
            else
            {
                puedeApostar = true;
            }

        } while (puedeApostar != true);
        Console.WriteLine("---ESCRIBA 1 PARA JUGAR AL BLACKJACK---");
        switchControl = Console.ReadLine();
        if (switchControl == "1")
        {
            do
            {
                numero = random.Next(1, 12);
                totalJugador = totalJugador + numero;
                Console.WriteLine($"TE SALIO EL NUMERO: {numero} ");
                Console.WriteLine("¿DESEAS OTRA CARTA?");
                controlOtraCarta = Console.ReadLine();

            } while (controlOtraCarta == "Si" ||
                        controlOtraCarta == "si" ||
                        controlOtraCarta == "yes");
        }

        totalDealer = random.Next(14, 23);
        Console.WriteLine($"El DEALER TIENE {totalDealer}");

        if (totalJugador > totalDealer && totalJugador < 22)
        {
            message = "VENCISTE AL DEALER, FELICITACIONES *GANASTE*";
            monedas  +=  apuesta;
            Console.WriteLine(message);
        }
        else if (totalJugador >= 22)
        {
            message = $"TE PASASTE DE 21, LO SIENTO EL DEALER TE GANO";
            monedas  -=  apuesta;
            Console.WriteLine(message);
        }
        else if (totalJugador <= totalDealer)
        {
            message = "EL DEALER TE GANO LO SIENTO, PERDISTE";
            monedas  -=  apuesta;
            Console.WriteLine(message);
        }
        else
        {
            message = "CONDICION DE JUEGO NO VALIDA";
        }
        Console.WriteLine("TIENES : " + monedas + " MONEDAS ");

        Console.WriteLine("¿DESEAS SEGUIR APOSTANDO?");
        seguirApostando = Console.ReadLine();

        monedasRestantes = +monedas;
        Console.Clear();
        if (monedas == 0)
        {
            Console.WriteLine("SIN MONEDAS, POR FAVOR COMPRE MAS...");
            break;
        }
    } while (seguirApostando == "si" || seguirApostando == "SI");
    Console.WriteLine("¿QUIERES SALIR DEL * C A S I N O * ?");
    seguirApostando = Console.ReadLine();
    if (seguirApostando == "si" || seguirApostando == "SI")
    {
        Console.WriteLine("GRACIAS POR JUGAR");
        Console.ReadKey();
    }
    else
    {
        Console.Clear();
    }
} while (seguirApostando == "no" || seguirApostando == "NO");