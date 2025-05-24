using System;

namespace manipulaciondeObjetos {

    class Empleado {

        //campos privados encapsulados con propiedad
        //publicas
        private string nombre;
        private decimal salario;

        public string Nombre {

            get { return nombre; }

            set {
                if (!string.IsNullOrWhiteSpace(value))
                    nombre = value;
                else
                    nombre = "Sin nombre";
                        
            }
        
        }

        public decimal Salario
        { 
            get { return salario; }

            set { 
                if(value >=0)
                    salario = value;
                else
                    salario= 0;
                       
            }
        
        }
        //Metodo que puede ser ocultado

        public void MostrarInformacion()
        {
            Console.WriteLine($"Empleado: {Nombre}, Salario: {Salario}");
        
        }

        //Clase Hija para ocultar miembro

        class EmpleadoConComision : Empleado { 
        
            public decimal Comision { get; set; }

            //Ocultación de miembro usando NEW

            public new void MostrarInformacion()
            {
                Empleado empleado = new Empleado();
                empleado.MostrarInformacion();

                Console.WriteLine($"Empleado con comisión:{Nombre}, " +
                    $"Salario base: {Salario}, Comisión: {Comision}");
            
            }


        }

        class Program {
            static void Main(string[] args)
            {
                //Creación de objetos para el Empleado
                //Porque Elian No vino hoy y hay que dar todos los temas

                Empleado emp1 = new Empleado();
                emp1.Nombre = "Elian Camino Mercedes";
                emp1.Salario = 100;

                //Creación de objeto empleado con Comisión
                EmpleadoConComision emp2 = new EmpleadoConComision();
                emp2.Nombre = "Jeifferson";
                emp2.Salario = 200;
                emp2.Comision = 250;

                Console.WriteLine("====Información de Empleado====");
                emp1.MostrarInformacion();
                emp2.MostrarInformacion();

                Console.ReadKey();
            }
        
        
        
        }

    
    
    }



}