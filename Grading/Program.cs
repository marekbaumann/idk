using System;
using DisplayHelper;

namespace Grading
{
 
    class Program
    {
        static void Main(string[] args)
        {
            CertificateTable table = new CertificateTable();

            Display displayGrading = new Display(50, 20, 20, 20);
            displayGrading.AddItem(new Item("-- Vysvědčení --", ""));
            displayGrading.AddItem(new Item("", ""));
            Display displayInput = new Display(50, 20, 20, 20);
            displayInput.AddItem(new Item("---- zadávání předmětu ----", ""));
            displayInput.AddItem(new Item("Předmět", ""));
            Display displayInput2 = new Display(50, 20, 20, 20);
            displayInput2.AddItem(new Item("---- zadávání známky ----", ""));
            displayInput2.AddItem(new Item("Známka", ""));
            Display displayConfirm = new Display(50, 20, 20, 20);
            displayConfirm.AddItem(new Item("Chceš vložit dalšího? [A]", ""));

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


            foreach (var grade in grades)
            {
                GradeAvg ga = table.AddGrade(grade);
            }

            foreach (var item in table.GetAllGrades())
            {
                displayGrading.AddItem(new Item(item.Subject, item.GetAverage()));
            }



            Console.ReadKey();
        }
    }
}
