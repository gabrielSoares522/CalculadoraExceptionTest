namespace CalculadoraExceptionTest;

class Program{
    public double Somar(double x,double y){
        

        return x+y;
    }

    public double Subtrair(double x,double y){
        return x-y;
    }

    public double Dividir(double x,double y){
        if(y == 0){
            throw new DividirPorZeroException("Voce tentou dividir por zero!");
        }
        return x/y;
    }

    public double Multiplicar(double x,double y){
        return x*y;
    }
}
