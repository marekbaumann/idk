using System;
using DisplayHelper;

namespace Grading
{

    class Program
    {
        static void Main(string[] args)
        {
            CertificateTable table = new CertificateTable();

            Display displayConfirm = new Display(35, 15, 10, 10);
            Display displayInput = new Display(35, 15, 10, 10);
            Display displayInput2 = new Display(35, 15, 10, 10);
            Display displayGrading = new Display(35, 15, 10, 10);

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

            displayInput.AddItem(new Item("---- zadávání předmětu ----", ""));
            displayInput.AddItem(new Item("Zadejte předmět: ", ""));
            displayInput2.AddItem(new Item("---- zadávání známky ----", ""));
            displayInput2.AddItem(new Item("Zadejte známku: ", ""));
            displayConfirm.AddItem(new Item("Chceš vložit dalšího? [A/N]", ""));
            string pokracovat = "A";
            while (true)
            {
                if (pokracovat != "A")
                {
                    break;
                }
                else
                {
                    Grade[] grades1 = new Grade[grades.Length + 1];
                    for (int i = 0; i < grades.Length; i++)
                    {
                        grades1[i] = grades[i];
                    }
                    grades = grades1;
                    displayInput.Repaint();
                    string subject = Console.ReadLine();
                    while ((subject != "PRG") && (subject != "MAT") && (subject != "CJL"))
                    {
                        Console.WriteLine("Nevalidní předmět. Zadejte znovu: ");
                        subject = Console.ReadLine();
                        if (subject == "PRG" || subject == "MAT" || subject == "CJL")
                        {
                            break;
                        }
                    }
                    displayInput2.Repaint();
                    string znamčička = Console.ReadLine();
                    while (true)
                    {
                        while (!(int.TryParse(znamčička, out int result)))
                        {
                            Console.WriteLine("Zadej číslo: ");
                            znamčička = Console.ReadLine();
                        }
                        int znamka = int.Parse(znamčička);
                        if (znamka > 5 || znamka < 1)
                        {
                            Console.WriteLine("Zadej číslo v rozmezí 1-5: ");
                            znamčička = Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                    grades[grades.Length - 1] = new Grade() { Subject = subject, Score = Convert.ToDouble(znamčička) };

                    displayConfirm.Repaint();
                    pokracovat = Console.ReadLine();
                }

            }

            displayGrading.AddItem(new Item("-- Vysvědčení --", ""));
            displayGrading.AddItem(new Item("", ""));
            foreach (var grade in grades)
            {
                GradeAvg ga = table.AddGrade(grade);
            }

            foreach (var item in table.GetAllGrades())
            {
                displayGrading.AddItem(new Item(item.Subject, item.GetAverage()));
            }
            displayGrading.Repaint();
            Console.ReadKey();
        }
    }
}