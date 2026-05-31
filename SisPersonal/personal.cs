namespace personal;
public class Empleado{
    public string nombre;
    public string apellido;
    public DateTime fechaDeNacimiento;
    public char estadoCivil;
    public DateTime fechaDeIngreso;
    public double sueldo;
    public Cargo cargo;

    public double añosDeServicio(DateTime fechaDeIngreso){
        DateTime fechaActual = DateTime.Now;
        double añosDeServicio = fechaActual.Year - fechaDeIngreso.Year;
        return añosDeServicio;
    }
    public int añosDelEmpleado(DateTime fechaDeNacimiento){
        DateTime fechaActual = DateTime.Now;
        int añosDelEmpleado = fechaActual.Year - fechaDeNacimiento.Year;;
        return añosDelEmpleado;
    }
    public int AñosParaJubilarse(DateTime fechaDeNacimiento){
        DateTime fechaActual = DateTime.Now;
        int añosDelEmpleado = fechaActual.Year - fechaDeNacimiento.Year;
        int AñosParaJubilarse = 65 - añosDelEmpleado;
        return AñosParaJubilarse;
    }


    public double sueldoB(double sueldo,double añosDeServicio,Cargo cargo){
        if (añosDeServicio >= 20){
            sueldo = sueldo + (sueldo*0.25);

            if (cargo == Cargo.ingeniero || cargo == Cargo.especialista){
                sueldo = sueldo + (sueldo*0.5);
            }
            if (estadoCivil == 'C'){
                sueldo = sueldo + 150000;
            }
        }else if(añosDeServicio > 1){
            sueldo = sueldo + (sueldo*(añosDeServicio/100));

            if (cargo == Cargo.ingeniero || cargo == Cargo.especialista){
                sueldo = sueldo + (sueldo*0.5);
            }
            if (estadoCivil == 'C'){
                sueldo = sueldo + 150000;
            }
    
        }

        return sueldo;
    }

}

public enum Cargo {
    administrativo = 1,
    auxiliar = 2,
    ingeniero = 3,
    especialista = 4,
    investigador = 5,
}

