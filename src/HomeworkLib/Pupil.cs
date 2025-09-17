using System;

namespace HomeworkLib
{
    public class Pupil
    {
        public virtual void Study() => Console.WriteLine("Pupil: Study");
        public virtual void Read() => Console.WriteLine("Pupil: Read");
        public virtual void Write() => Console.WriteLine("Pupil: Write");
        public virtual void Relax() => Console.WriteLine("Pupil: Relax");
    }

    public class ExcelentPupil : Pupil
    {
        public override void Study() => Console.WriteLine("ExcellentPupil: studies excellently.");
        public override void Read()  => Console.WriteLine("ExcellentPupil: reads a lot.");
        public override void Write() => Console.WriteLine("ExcellentPupil: writes perfectly.");
        public override void Relax() => Console.WriteLine("ExcellentPupil: relaxes productively.");
    }

    public class GoodPupil : Pupil
    {
        public override void Study() => Console.WriteLine("GoodPupil: studies well.");
        public override void Read()  => Console.WriteLine("GoodPupil: reads regularly.");
        public override void Write() => Console.WriteLine("GoodPupil: writes well.");
        public override void Relax() => Console.WriteLine("GoodPupil: relaxes moderately.");
    }

    public class BadPupil : Pupil
    {
        public override void Study() => Console.WriteLine("BadPupil: studies poorly.");
        public override void Read()  => Console.WriteLine("BadPupil: rarely reads.");
        public override void Write() => Console.WriteLine("BadPupil: writes with mistakes.");
        public override void Relax() => Console.WriteLine("BadPupil: relaxes too much.");
    }

    public class ClassRoom
    {
        private Pupil[] pupils;
        public ClassRoom(params Pupil[] args)
        {
            pupils = new Pupil[4];
            for (int i = 0; i < pupils.Length; i++)
                pupils[i] = i < args.Length ? args[i] : new Pupil();
        }
        public void ShowAll()
        {
            for (int i = 0; i < pupils.Length; i++)
            {
                Console.WriteLine($"\nPupil #{i+1}:");
                pupils[i].Study();
                pupils[i].Read();
                pupils[i].Write();
                pupils[i].Relax();
            }
        }
        public Pupil[] Pupils => pupils;
    }
}
