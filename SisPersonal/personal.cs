namespace personal;
public class Empleado{
    public string nombre;
    public string apellido;
    public DateTime fechaDeNacimiento;
    public char estadoCivil;
    public DateTime fechaDeIngreso;
    public double sueldo;
    public Cargo cargo; 

}

enum Cargo {
    administrativo = 1,
    auxiliar = 2,
    ingeniero = 3;
    especialista = 4;
    investigador = 5;
}