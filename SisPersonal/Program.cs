using personal;

Empleado[] empleado = new Empleado[3];
empleado[0] = new Empleado();
empleado[0].nombre = "Juan";
empleado[0].apellido = "Carrizo";
empleado[0].fechaDeIngreso = new DateTime(1990,5,13);
empleado[0].fechaDeNacimiento = new DateTime(1970,2,1);
empleado[0].cargo = Cargo.ingeniero;
empleado[0].estadoCivil = 'C';
empleado[0].sueldo = 650000;

empleado[1] = new Empleado();
empleado[1].nombre = "Esteba";
empleado[1].apellido = "Rodrigez";
empleado[1].fechaDeIngreso = new DateTime(2010,2,1);
empleado[1].fechaDeNacimiento = new DateTime(1990,6,28);
empleado[1].cargo = Cargo.especialista;
empleado[1].estadoCivil = 'S';
empleado[1].sueldo = 550000;

empleado[2] = new Empleado();
empleado[2].nombre = "Lucas";
empleado[2].apellido = "Fernandez";
empleado[2].fechaDeIngreso = new DateTime(2020,10,5);
empleado[2].fechaDeNacimiento = new DateTime(1960,12,3);
empleado[2].cargo = Cargo.auxiliar;
empleado[2].estadoCivil = 'C';
empleado[2].sueldo = 350000;


double sueldo1 = empleado[0].sueldoB(empleado[0].sueldo,empleado[0].añosDeServicio(empleado[0].fechaDeIngreso),empleado[0].cargo);
double sueldo2 = empleado[1].sueldoB(empleado[1].sueldo,empleado[1].añosDeServicio(empleado[1].fechaDeIngreso),empleado[1].cargo);
double sueldo3 = empleado[2].sueldoB(empleado[2].sueldo,empleado[2].añosDeServicio(empleado[2].fechaDeIngreso),empleado[2].cargo);

double total = sueldo1 + sueldo2 + sueldo3;
Console.WriteLine("El total a pagar de los 3 empleado es: $"+total);

int año1 = empleado[0].AñosParaJubilarse(empleado[0].fechaDeNacimiento);
int año2 = empleado[1].AñosParaJubilarse(empleado[1].fechaDeNacimiento);
int año3 = empleado[2].AñosParaJubilarse(empleado[2].fechaDeNacimiento);

int poco = Math.Min(año1,Math.Min(año2,año3));

for (int i = 0; i < 3; i++){
    if (empleado[i].AñosParaJubilarse(empleado[i].fechaDeNacimiento) == poco){
        Console.WriteLine("-----Datos del empleado proximo a jubilarse-----");
        Console.WriteLine("Nombre: "+empleado[i].nombre);
        Console.WriteLine("Apellido: "+empleado[i].apellido);
        Console.WriteLine("Fecha de ingreso: "+empleado[i].fechaDeIngreso.ToString("dd/MM/yyyy"));
        Console.WriteLine("antigüedad del empleado en la empresa: "+empleado[i].añosDeServicio(empleado[i].fechaDeIngreso));
        Console.WriteLine("edad: "+empleado[i].añosDelEmpleado(empleado[i].fechaDeNacimiento));
        Console.WriteLine("Años que le falta para jubilarse: "+empleado[i].AñosParaJubilarse(empleado[i].fechaDeNacimiento));
        Console.WriteLine("Fecha de nacimiento: "+empleado[i].fechaDeNacimiento.ToString("dd/MM/yyyy"));
        Console.WriteLine("Cargo: "+empleado[i].cargo);
        if (empleado[i].estadoCivil == 'C'){
            Console.WriteLine("Estado civil: Casado");
        }
        else{
            Console.WriteLine("Estado civil: Soltero");
        }
        Console.WriteLine("Sueldo: "+empleado[i].sueldoB(empleado[i].sueldo,empleado[i].añosDeServicio(empleado[i].fechaDeIngreso),empleado[i].cargo));

    }
}