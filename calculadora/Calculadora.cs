namespace matematica;
public class Calculadora{
    private double dato;
    public double Resultado {get => dato;}
    public void sumar(double termino){
        dato = dato + termino;
    }
    public void restar(double termino){
        dato = dato - termino;
    }
    public void multiplicar(double termino){
        dato = dato * termino;
    }

    public void dividir(double termino){
        dato = dato / termino;
    }

    public void limpiar(){
        dato = 0;
    }
}