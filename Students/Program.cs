using System;
using System.Text;

public class Student
{
    public int facN { get; set; }
    public int Grade { get; set; } 
    public String name { get; set; }

    public void input()
    {
        Console.Write("Факултетен номер :");
        facN = Convert.ToInt32(Console.ReadLine());
        Console.Write("Име :");
        name = Console.ReadLine();
        Console.Write("Оценка :");
        Grade = Convert.ToInt32(Console.ReadLine());
    }
}
public class College : Student
{
    public void print()
    {
        Console.WriteLine("\n\nФакултетен номер: " + facN);
        Console.WriteLine("Името на студента е: " + name);
        Console.WriteLine("Оценката на студента е: " + Grade);
    }

    static double sredenUspeh(int[] students)
    {
        double n = 0;
        double ocenka = 0;
        double sredno = 0;
        for (int i = 0; i < students.Length; i++)
        { 
            ocenka += students[i];
            n++;
        }
        
        return sredno = ocenka / n;
    }

    //public string otlichnici(int[] students)
    //{
    //    for (int i = 0; i < students.Length; i++)
    //    {
    //        if (Grade == 6)
    //        {
    //            return name;
    //        }
    //    }

    //}
    

    public void findX(int[] students)
    {
        Console.WriteLine("Въведете име на студент, за да разберете успеха му: ");
        string studname=Console.ReadLine();
        for (int i = 0; i < students.Length; i++)
        {
            if (students[i].ToString() == studname)
            {
                Console.WriteLine("Студентът с име {0} е с успех {1}",studname, Grade);
            }
        }
    }

    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8; // za kirilica


        College t1 = new College();
        int n;

        do
        {
            Console.WriteLine("Въведете броя на студентите (макс 100): ");
            n = int.Parse(Console.ReadLine());

        } while (n<1 || n>100);
        Student[] students = new Student[n];

        for (int stud = 0; stud < n; stud++)
        {
            t1.input();
        }
       // t1.findX();
    }
}