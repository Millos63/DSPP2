namespace Estructuras
{
    internal struct CEmpleado
    {
        double salarioBase;
        double comision;

        public CEmpleado(double pSalario, double pComision)
        {
            salarioBase = pSalario;
            comision = pComision;
        }

        public override string ToString()
        {
            return string.Format("El salario del empleado es: $" + salarioBase + " la comision es: $ " + comision + " El total es: $ " + (comision + salarioBase));
        }

        public void CambiarSalario(CEmpleado chambeador, double incremento)
        {
            //el signo += es sumale y asignale
            chambeador.salarioBase += incremento;
            chambeador.comision += incremento;
        }

    }
}
