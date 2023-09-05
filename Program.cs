using System.Collections;

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
        Console.WriteLine($"El va
        lor de b es= {b}"); 
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
        Console.WriteLine(check ? "Activo" : "Inactivo" ); 
        decimal value = 123.456m; /* Se puede pasar al metodo TryFormat o a una sobrecarga del metodo ToString que tiene un parametro format. En el ejemplo siguiente se da formato a un valor numerico como una cadena de divisa en la referencia cultural actual (en este caso, en-US) 
        Console.WriteLine(value.ToString("C2")); // Display $123.46

        // Como realizo una amortizacion de un credito en el cual le voy a solcicitar al banco un credito , como se dividen las cuotas,intereses,mensuales,etc
         
        //Arreglos Unidimensionales , diferentes tipos con datos
        //Declaracion 
        int[] arrx;
        string[] arry;
        double[] arrz;

        //Inicializacion
        string[] nombres=new string[4];
        string[] nombres={"Jose","Samuel","Alvarez","Silva"};
        string[] nombres2=new string[]{"Maritza","Silva","Manrique"};
        int[] numeros={1,2,3,4,5};
        int[] arr1=new int[5];
        Array.Copy(numeros,arr1,5);  // Copía los elementos de arrelo numeros al arr1 y va a copiar en total 5 elementos de diferentes espacios
        int longitud=0;
        foreach(int i in arr1){
            numeros[longitud]=longitud-1;
            Console.WriteLine(numeros[longitud]);
            longitud++;
        }
        foreach(string i in nombres){
            Console.WriteLine(i);
        }
        //Metodo Length
        int len=numeros.Length;
        double[] precios={5.908885,78.001,6.305,90.40};

        //Metodo sort
         //ArrayList
         ArrayList myAL=new ArrayList();
         myAL.Add( "The" );
         myAL.Add( "quick" );  // Agrega informacion a una ArrayList
         myAL.Add( "brown" );                  
         myAL.Add( "fox" );
         Console.WriteLine( " --- List Inmodified --- " );
         foreach(Object n in myAL){
            Console.WriteLine(n.ToString());
         }
         myAL.Remove("brown");     // Elimina elementos a un ArrayList
         Console.WriteLine( " --- List Modified --- " );
         foreach(Object n in myAL){
            Console.WriteLine(n.ToString());
         }
        Console.WriteLine(myAL.Contains("fox") ? "El elemento esta disponible" : "El elemento no esta disponible" ); TRUE 
         
         ArrayList Carnivoros=new ArrayList();
         ArrayList Acuaticos=new ArrayList();
         ArrayList Animales=new ArrayList();

        Carnivoros.Add("Tigre");
        Carnivoros.Add("Leon");
        Carnivoros.Add("Pantera");
        Carnivoros.Add("Leopardo");   
        Acuaticos.Add("Tiburon");
        Acuaticos.Add("Delfin");
        Acuaticos.Add("Ballena");
        Acuaticos.Add("Pulpo");   
        
        //Metodo AddRange combina varias ArrayList en una sola ArrayList si se quiere
        Animales.AddRange(Carnivoros);
        foreach (Object n in Animales){     // Agrega toda la ArrayList Carnivoros a la ArrayList Animales
            Console.WriteLine(n.ToString());
        }   
        Console.WriteLine("--------------------");

        Animales.AddRange(Acuaticos);
        foreach (Object n in Animales){     // Finalmente agrega la ArrayList Acuaticos a la ArrayList Animal
            Console.WriteLine(n.ToString());
        }  
        /* 
        Console.WriteLine("--------------------");
        Console.WriteLine("Escriba un Animal para buscar: ");
        string animal=Console.ReadLine();
        Console.WriteLine(Animales.IndexOf(animal));   // Muestra dentro de la ArrayList Animales los index de cada posicion , en este caso mostrara el index de el animal ingresado por el cliente para buscar   
        //Metodo clear,elimina todos lo elementos de una ArrayList         Animales.Clear(); 
        int idx;
        do{
            Console.WriteLine("Ingrese la posicion donde desea insertar la Asignatura: ");
            idx=Convert.ToInt32(Console.ReadLine());
        }while(idx > Animales.Count);
        Console.WriteLine("Escriba un Animal para insertar: ");   // Insertar animales en posiciones cambiando elementos
        animal=Console.ReadLine();
        Animales.Insert(idx,animal);   */
        
        // Metodo InserRange
        
}        


        // Declarar e inicializar dos ArrayList
        ArrayList miArrayList = new ArrayList();
        // Agregar elementos al primer ArrayList
        miArrayList.Add("hola");
        miArrayList.Add(5);
        miArrayList.Add(true);

        var[] miArrayList2 = {"adios",6,false};

        
        
        // Agregar el segundo ArrayList al primero
        miArrayList.Add(miArrayList2);

        // Mostrar el contenido del primer ArrayList
        foreach (var item in miArrayList)
        {
            Console.WriteLine(item);
        }
    }


    
