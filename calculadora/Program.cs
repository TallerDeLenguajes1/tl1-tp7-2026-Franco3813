using matematica;

Calculadora miCalculadora = new Calculadora();
miCalculadora.limpiar();
string continuar;
double num1;

Console.WriteLine("------Calculadora------");
do{

    Console.WriteLine("Ingrese una operacion \n1)sumar \n2)restar \n3)multiplicar \n4)dividir \n5)limpiar");
    string c = Console.ReadLine();

    Console.WriteLine("Ingrese un numero: ");
    string num = Console.ReadLine();
    double.TryParse(num, out num1);

    if (c == "1"){
        miCalculadora.sumar(num1);    
    }
    if (c == "2"){
        miCalculadora.restar(num1);    
    }
    if (c == "3"){
        miCalculadora.multiplicar(num1);    
    }
    if (c == "4"){
        miCalculadora.dividir(num1);    
    }
    if (c == "5"){
        miCalculadora.limpiar();    
    }

    Console.WriteLine("Resultado: "+miCalculadora.Resultado);

    Console.WriteLine("Desea continuar? \n1)no \n2)si");
    continuar = Console.ReadLine();
} while (continuar == "2");
