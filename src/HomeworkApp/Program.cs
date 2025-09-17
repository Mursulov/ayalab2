using System;
using HomeworkLib;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Задание 1: ClassRoom ===");
        var cr = new ClassRoom(
            new ExcelentPupil(),
            new GoodPupil(),
            new BadPupil()
            // четвёртый ученик будет обычным Pupil
        );
        cr.ShowAll();

        Console.WriteLine("\n=== Задание 2: Vehicle ===");
        Vehicle[] vehicles = {
            new Plane(0, 0, 1_000_000, 900, 2022, 12000, 300),
            new Car(10, 5, 500_000, 180, 2020),
            new Ship(-5, 2, 2_000_000, 40, 2019, 1500, "Odessa")
        };
        foreach (var v in vehicles)
        {
            v.ShowInfo();
            Console.WriteLine();
        }

        Console.WriteLine("=== Задание 3: DocumentWorker ===");
        Console.Write("Введите ключ доступа (pro/exp, пусто для базовой): ");
        string? key = Console.ReadLine();
        DocumentWorker doc;
        if (key == "exp")
            doc = new ExpertDocumentWorker();
        else if (key == "pro")
            doc = new ProDocumentWorker();
        else
            doc = new DocumentWorker();
        doc.OpenDocument();
        doc.EditDocument();
        doc.SaveDocument();
    }
}
