using System;
using DisplayHelper;

namespace Grading
{
 
    class Program
    {
        static void Main(string[] args)
        {
            Grade[] grades = new Grade[9];
            grades[0] = new Grade() { Subject = "MAT", Score = 1 };
            grades[1] = new Grade() { Subject = "CJL", Score = 4 };
            grades[2] = new Grade() { Subject = "PRG", Score = 1 };
            grades[3] = new Grade() { Subject = "MAT", Score = 2 };
            grades[4] = new Grade() { Subject = "CJL", Score = 5 };
            grades[5] = new Grade() { Subject = "CJL", Score = 3 };
            grades[6] = new Grade() { Subject = "PRG", Score = 1 };
            grades[7] = new Grade() { Subject = "MAT", Score = 2 };
            grades[8] = new Grade() { Subject = "MAT", Score = 2 };

            CertificateTable table = new CertificateTable();

            Display displayGrading = new Display(40, 20, 10, 10);
            displayGrading.AddItem(new Item(" Vysvědčení ", ""));
            Display displayInput = new Display(40, 20, 60, 10);
            displayInput.AddItem(new Item(" zadávání předmětu ", ""));
            displayInput.AddItem(new Item("Předmět", ""));
            foreach (var grade in grades)
            {
                GradeAvg ga = table.AddGrade(grade);
            }
            foreach (var item in table.GetAllGrades())
            {
                displayGrading.AddItem(new Item(item.Subject, item.GetAverage()));
            }
            string x = Console.ReadLine();
            
            Console.ReadKey();
            Display displayInput2 = new Display(40, 20, 10, 30);
            displayInput2.AddItem(new Item(" zadávání známky ", ""));
            displayInput2.AddItem(new Item("Známka", ""));
            Display displayConfirm = new Display(40, 20, 60, 30);
            displayConfirm.AddItem(new Item("Chceš vložit dalšího? [A]", ""));

            Console.ReadKey();
        }
    }
}
