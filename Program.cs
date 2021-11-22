using System;

namespace Structure
{
    class Program
    {

        struct Student
        {
            public string name;
            public int number;
           public int[] Mark;

            public Student(string name, int number, int[] Mark)
            {
                this.name = name;
                this.number = number;
                this.Mark = Mark;
            }

            public void Showinfo()
            {
                Console.WriteLine($"Имя:{name}, Группа:{number}");
            }
                
        }




        static void Main(string[] args)
        {
            Student student1 = new Student("Petya", 1, new int[]{ 5,3,4,4,3 });
            Student student2 = new Student("Vasya", 2, new int[] { 2, 2, 2, 2, 2 });


            Student[] students =
            {
                student1,
                student2

            };


            for(int i=0;i<students.Length;i++) // студенты
            {
                for(int j=0;j<students[i].Mark.Length;j++) // оценки
                {
                    if(students[i].Mark[j]!=4&& students[i].Mark[j] != 5)
                    {
                        continue;
                    }
                    else
                    {
                        students[i].Showinfo();
                    }
                }
            }


        }
    }
}
