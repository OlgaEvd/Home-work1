//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N");
Console.WriteLine("    ");
Console.Write("Введите число N: ");

int n = Convert.ToInt32(Console.Read());
for (int i= 1; i <= n;)
        {
            if (i % 2 == 0) 
        
          Console.Write(i+ " ");  
        
            i++;    
        }

   
