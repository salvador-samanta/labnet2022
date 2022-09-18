using System;


namespace PracticaExtensionMethods
{
    public class Metodos
    {
        public static void DivisionPorCero()
        {

            try
            {
                int num = 0;
                Console.WriteLine("Ingrese un número para ver qué sucede:");
                num = Convert.ToInt32(Console.ReadLine());

                int divideCero = num / 0;
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("¡BUM! Hiciste explotar todo. ¿No sabías que sólo Chuck Norris puede dividir por cero?");
            }

            catch (FormatException e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                Console.WriteLine("Ha terminado...");
            }

        }

        public static float Division(float dividendo= 0, float divisor = 0)
        {
            float resultado = 0;
            try
            {
                Console.WriteLine("Hola! Ingresá un número que quieras dividir:\n");
                dividendo = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Perfecto, ahora ingresá el número por el cual querés dividirlo:");
                divisor = Convert.ToSingle(Console.ReadLine());
                Console.Write("Resultado: {0}\n", dividendo / divisor);

            }

            catch (DivideByZeroException te)
            {
                
                Console.WriteLine(te.Message);
                Console.WriteLine("Intentaste dividir por cero\n ...no vuelvas a hacer eso\n");

            }

            catch (FormatException e)
            {
                
                Console.WriteLine(e.Message);
                Console.WriteLine("Espero que no estés intentando romper mi código a propósito >:(");


            }
            finally
            {
                
                Console.WriteLine("Ha terminado...");
            }
            return resultado; //este return sólo lo puse porque el programa no me permitía poner Division como un public static float. por eso resultado está declarado antes del try.

        }

    }
}
