namespace Enum2
{
    enum comision { bajo = 500, normal = 1000, bueno = 1500, extra = 2500 };
    internal class Program
    {

        static void Main(string[] args)
        {
            comision em1 = comision.bueno;
            //casting el tipo de variable que queremos usar, el nombre = a el tipo de dato y nombre de la variable.
            double comisionEmp1 = (double)em1;
            double Sueldoemp1 = 2000 + comisionEmp1;
            System.Console.WriteLine("la comision del empleado es: " + em1 + " el valor es: $ " + comisionEmp1);
            System.Console.WriteLine("El salario del empleado es:$ " + Sueldoemp1);

            CEmpleado empleado = new CEmpleado(em1,8000);

            //empleado.getSalario();

            System.Console.WriteLine(empleado.getSalario());

        }
    }

   
}







