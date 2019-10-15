using System;
using System.Text;

public class Student
{
    public int facN, grade;
    public String name;

    public void input()
    {
        Console.Write("Факултетен номер :");
        facN = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nИме :");
        name = Console.ReadLine();
        Console.Write("\nОценка :");
        grade = Convert.ToInt32(Console.ReadLine());
    }
}
public class College : Student
{
    public void print()
    {
        Console.WriteLine("Факултетен номер: " + facN);
        Console.WriteLine("Името на студента е: " + name);
        Console.WriteLine("Оценката на студента е: " + grade);
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
            t1.print();
    }
}