internal class Program
{
    private static void Main(string[] args)
    {
        /*Imprimir en la consola
        Console.WriteLine("Hello, World!"); /* Automaticamente genera un salto de linea
        Console.Write("Hola, Mundo!");  /* No genera saltos de linea */

        /* Pedir informacion por consola 
        int edad;
        float precio=25.0f;
        Console.WriteLine("Ingrese su edad: ");
        try{
            precio=float.Parse(Console.ReadLine() ?? "0");
            edad=int.Parse(Console.ReadLine() ?? "0");
        }catch (Exception ex){
            Console.WriteLine("Error {0} ",ex.Message.ToString());
        }
        
        /* Estrucutras de control if/else if/else y switch 
        if(5>4)
        {
            Console.WriteLine("A");
        }
        else if(6>5)
        {
            Console.WriteLine("B");
        }
        else
        {
            Console.WriteLine("C");
        }
        int opcion=1;
        switch(opcion){
            case 0:
                Console.WriteLine("0");
                break;
            case 1:
                Console.WriteLine("1");
                break;
            case 2:
                Console.WriteLine("2");
                break;
            default:
                Console.WriteLine("X");
        }
        /* Modificadores de acceso, permite darle accesibilidad como alcance a una variable 
        var a=12.3;
        double b=12.5;
        Console.WriteLine($"El valor de a es= {a}");
        Console.WriteLine($"El valor de b es= {b}"); 
        double d = 3D;
        d = 4d;
        d = 3.934_001;
        Console.WriteLine($"{d}");
        float f =3_000.5F;
        f = 5.4f;
        Console.WriteLine($"{f}");
        decimal myMoney = 3_000.5m;
        myMoney = 400.75M;
        Console.WriteLine($"{myMoney}");

         Operador Ternario 
         
        bool check=true;
        Console.WriteLine(check ? "Activo" : "Inactivo" ); */
        decimal value = 123.456m; /* Se puede pasar al metodo TryFormat o a una sobrecarga del metodo ToString que tiene un parametro format. En el ejemplo siguiente se da formato a un valor numerico como una cadena de divisa en la referencia cultural actual (en este caso, en-US) */
        Console.WriteLine(value.ToString("C2")); // Display $123.46

        // Como realizo una amortizacion de un credito en el cual le voy a solcicitar al banco un credito , como se dividen las cuotas,intereses,mensuales,etc
    }
}