///Practica del uso de estructuras condicionales

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("PRACTICA DEL USO DE ESTRUCTURAS CONDICIONALES\n");
Console.ResetColor();

//Calcular el Mayor de Tres Números

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Calcular el Mayor de Tres Números\n");
Console.ResetColor();
try
{ 
Console.WriteLine("Escribe el primer numero");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Escribe el segundo numero");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Escribe el tercer numero");
int num3 = int.Parse(Console.ReadLine());

int mayor = num1;

if (num2 > mayor)
{
    mayor = num2;
}
if (num3 > mayor)
{
    mayor=num3;
}
Console.WriteLine("El numero mayor es:" + mayor);
 }
catch (FormatException e)
{
    Console.WriteLine("Error: " + e.Message);
}
//Validar Edad para Ingresar a un Club

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nValidar Edad para Ingresar a un Club\n");
Console.ResetColor();

try
{
    Console.WriteLine("¿Cual es tu edad?");
    int edad = int.Parse(Console.ReadLine());

    if (edad >= 18)
    {
        Console.WriteLine("Si puede entrar al club");
    }
    else
    {
        Console.WriteLine("No puede entrar al club");
    }
}
catch (FormatException e)
{
    Console.WriteLine("Error: " + e.Message);
}

//Calcular el Precio Final de un Producto

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nCalcular el Precio Final de un Producto\n");
Console.ResetColor();
try
{
    Console.WriteLine("¿Cual es el precio original del producto?");

    double productoO = double.Parse(Console.ReadLine());
    double descuento;
    if (productoO > 100)
    {
        descuento = productoO * 0.1;
    }
    else
    {
        descuento = 0;
    }
    double productoF = productoO - descuento;
    Console.WriteLine("El precio final con o sin descuento es: " + productoF);
}
catch (FormatException e)
{
    Console.WriteLine("Error: " + e.Message );
}

//Validar Usuario y Contraseña

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nValidar Usuario y Contraseña\n");
Console.ResetColor();

try
{
    Console.WriteLine("Escribe tu nombre de usuario");
    string usuario = Console.ReadLine();
    Console.WriteLine("Escribe tu contraseña");
    string contraseña = Console.ReadLine();

    if (usuario == "usuario" && contraseña == "contraseña")
    {
        Console.WriteLine("Acceso concedido");
    }
    else
    {
        Console.WriteLine("Acceso denegado");
    }
}
catch (FormatException e)
{
    Console.WriteLine("Error: " + e.Message);
}

//Determinar si un Número es Par o Impar

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nDeterminar si un Número es Par o Impar\n");
Console.ResetColor();

try
{
    Console.WriteLine("Escriba el numero");
    int N = int.Parse(Console.ReadLine());
    if (N % 2 == 0)
    {
        Console.WriteLine("El numero es Par");
    }
    else
    {
        Console.WriteLine("El numero es Impar");
    }
}
catch (FormatException e)
{ Console.WriteLine("Error: " + e.Message);
}

//Mostrar un Mensaje de Aprobación o Rechazo de Préstamo

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nMostrar un Mensaje de Aprobación o Rechazo de Préstamo\n");
Console.ResetColor();

try
{
    Console.WriteLine("Cual es el monto del prestamo");
    int Monto = int.Parse(Console.ReadLine());
    Console.WriteLine("Y su edad");
    int ed = int.Parse(Console.ReadLine());
    if (Monto < 5000 || ed > 60)
    {
        Console.WriteLine("Prestamo aprobado");
    }
    else
    {
        Console.WriteLine("Prestamo no aprobado");
    }
}
catch (FormatException e)
{
    Console.WriteLine("Error: " + e.Message);
}

//Calcular el Área de una Figura Geométrica

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nCalcular el Área de una Figura Geométrica\n");
Console.ResetColor();

try
{
    Console.WriteLine("Introduzca el tipo de figura geométrica (triángulo, cuadrado o círculo) ");
    string TipoFigura = Console.ReadLine().ToLower();
    double area = 0;
    switch (TipoFigura)
    {
        case "triangulo":
            Console.WriteLine("Introduzca la base del triangulo");
            double basetri = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca la altura del triangulo");
            double alturatri = double.Parse(Console.ReadLine());
            area = (basetri / alturatri) * 2;
            break;
        case "cuadrado":
            Console.WriteLine("Introduzca el lado del cuadrado");
            double ladocuadrado = double.Parse(Console.ReadLine());
            area = (ladocuadrado * ladocuadrado);
            break;
        case "circulo":
            Console.WriteLine("Introduzca el radio del circulo");
            double radiocirculo = double.Parse(Console.ReadLine());
            area = Math.PI * Math.Pow(radiocirculo, 2);
            break;
        default:
            Console.WriteLine("Tipo de figura no valida");
            break;
    }
    if (area > 0)
    {
        Console.WriteLine("El área de la {0} es: {1}", TipoFigura, area);

    }
}
catch (Exception e) 
{
    Console.WriteLine("Error: " + e.Message);
        }

///Ejercicios usando switch:
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("\nEJERCICIOS USANDO SWITCH");
Console.ResetColor();

//Convertir un Número de Letra a Número

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nConvertir un Número de Letra a Número\n");
Console.ResetColor();

try
{
    Console.WriteLine("Escriba un numero del 1 al 5 en letra");
    string numletra = Console.ReadLine().ToLower();

    switch (numletra)
    {
        case "uno":
            Console.WriteLine("El numero es 1");
            break;
        case "dos":
            Console.WriteLine("El numero es 2");
            break;
        case "tres":
            Console.WriteLine("El numero es 3");
            break;
        case "cuatro":
            Console.WriteLine("El numero es 4");
            break;
        case "cinco":
            Console.WriteLine("El numero es 5");
            break;
        default:
            Console.WriteLine("El numero no esta entre el rango de 1 a 5");
            break;

    }
}
catch (Exception e)
{ 
    Console.WriteLine("Error: " + e.Message);
}

//Mostrar el Día de la Semana a partir de un Número

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nMostrar el Día de la Semana a partir de un Número\n");
Console.ResetColor();

try
{
    Console.WriteLine("Escriba un numero entre 1 y 7");
    string diasemana = Console.ReadLine().ToLower(); ;

    switch (diasemana)
    {
        case "1":
            Console.WriteLine("El dia es Lunes");
            break;
        case "2":
            Console.WriteLine("El dia es Martes");
            break;
        case "3":
            Console.WriteLine("El dia es Miercoles");
            break;
        case "4":
            Console.WriteLine("El dia es Jueves");
            break;
        case "5":
            Console.WriteLine("El dia es Viernes");
            break;
        case "6":
            Console.WriteLine("El dia es Sabado");
            break;
        case "7":
            Console.WriteLine("El dia es Domingo");
            break;
        default:
            Console.WriteLine("Numero no valido, debe de ser del 1 al 7");
            break;
    }
}
catch (Exception e)
{
    Console.WriteLine("Error: " + e.Message);
}

//Mostrar un Mensaje de Bienvenida en Diferentes Idiomas

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nMostrar un Mensaje de Bienvenida en Diferentes Idiomas\n");
Console.ResetColor();


Console.WriteLine("Elige el idioma que prefieras (\"español\", \"inglés\", \"francés\") ");
string Idioma = Console.ReadLine().ToLower();
switch (Idioma)
{
    case "español":
        Console.WriteLine("Hola bienvenido");
        break;
    case "ingles":
        Console.WriteLine("Hello welcome");
        break;
    case "frances":
        Console.WriteLine("Bonjour bienvenue");
        break;
    default:
        Console.WriteLine("El idima no esta entre los solicitados...");
        break;
}

//Evaluar la Calificación de un Examen

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nEvaluar la Calificación de un Examen\n");
Console.ResetColor();

try
{
    Console.WriteLine("Cual es la calificacion");
    int calificacion = int.Parse(Console.ReadLine());

    switch (calificacion)
    {
        case >= 90:
            Console.WriteLine("Sobre saliente");
            break;
        case >= 80:
            Console.WriteLine("Excelente");
            break;
        case >= 70:
            Console.WriteLine("Bueno");
            break;
        case >= 61:
            Console.WriteLine("Aprobado");
            break;
        case < 60:
            Console.WriteLine("No aprobado, la calificacion minima es 61");
            break;
        default:
            ConsoleKeyInfo tecla = Console.ReadKey();
            Console.WriteLine("La calificacion no es valida " + tecla.Key);
            break;
    }
}
catch (Exception e)
{
    Console.WriteLine("Error:" + e.Message);
}

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("\nESTO ES TODO, GRACIAS\n");
Console.ResetColor();


