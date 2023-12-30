
namespace Lesson
{
    public class MusicalInstrument
    {
        public string? MusicalInstrumentHistory { get; set; }  //історію створення музичного інструменту
        public string? MusicalInstrumentProperties { get; set; }  //опис музичного інструменту  (Desc)
        public string? MusicalInstrumentName { get; set; }  //назву музичного інструменту (Show)
        public string? MusicalInstrumentSound { get; set; }  //звук музичного інструменту

        public virtual void Sound()
        {
            Console.WriteLine($"Play sound {MusicalInstrumentSound}");
        }
        public virtual void Desc()
        {
            Console.WriteLine($"Show {MusicalInstrumentProperties}");
        }
        public virtual void History()
        {
            Console.WriteLine($"Show {MusicalInstrumentHistory}");
        }
        public virtual void Show()
        {
            Console.WriteLine($"{MusicalInstrumentName}");
        }
    }
    public class Violin : MusicalInstrument
    {
        public Violin(string name, string properties, string sound, string history)
        {
            MusicalInstrumentHistory = history;
            MusicalInstrumentProperties = properties;
            MusicalInstrumentName = name;
            MusicalInstrumentSound = sound;
        }


        public override void Sound()
        {
            Console.WriteLine($"{MusicalInstrumentName} sound like:\n{MusicalInstrumentSound}");
        }
        public override void Desc()
        {
            Console.WriteLine($"Properties {MusicalInstrumentName}:\n{MusicalInstrumentProperties}");
        }
        public override void History()
        {
            Console.WriteLine($"History of {MusicalInstrumentName}:\n{MusicalInstrumentHistory}");
        }
        public override void Show()
        {
            Console.WriteLine($"Instrument name:\n{MusicalInstrumentName}");
        }

    }
    public class Trombone : MusicalInstrument
    {

        public Trombone(string name, string properties, string sound, string history)
        {
            MusicalInstrumentHistory = history;
            MusicalInstrumentProperties = properties;
            MusicalInstrumentName = name;
            MusicalInstrumentSound = sound;
        }
        public override void Sound()
        {
            Console.WriteLine($"{MusicalInstrumentName} sound like:\n{MusicalInstrumentSound}");
        }
        public override void Desc()
        {
            Console.WriteLine($"Properties {MusicalInstrumentName}:\n{MusicalInstrumentProperties}");
        }
        public override void History()
        {
            Console.WriteLine($"History of {MusicalInstrumentName}:\n{MusicalInstrumentHistory}");
        }
        public override void Show()
        {
            Console.WriteLine($"Instrument name:\n{MusicalInstrumentName}");
        }
    }
    public class Ukulele : MusicalInstrument
    {
        public Ukulele(string name, string properties, string sound, string history)
        {
            MusicalInstrumentHistory = history;
            MusicalInstrumentProperties = properties;
            MusicalInstrumentName = name;
            MusicalInstrumentSound = sound;
        }
        public override void Sound()
        {
            Console.WriteLine($"{MusicalInstrumentName} sound like:\n{MusicalInstrumentSound}");
        }
        public override void Desc()
        {
            Console.WriteLine($"Properties {MusicalInstrumentName}:\n{MusicalInstrumentProperties}");
        }
        public override void History()
        {
            Console.WriteLine($"History of {MusicalInstrumentName}:\n{MusicalInstrumentHistory}");
        }
        public override void Show()
        {
            Console.WriteLine($"Instrument name:\n{MusicalInstrumentName}");
        }
    }
    public class Cello : MusicalInstrument
    {

        public Cello(string name, string properties, string sound, string history)
        {
            MusicalInstrumentHistory = history;
            MusicalInstrumentProperties = properties;
            MusicalInstrumentName = name;
            MusicalInstrumentSound = sound;
        }
        public override void Sound()
        {
            Console.WriteLine($"{MusicalInstrumentName} sound like:\n{MusicalInstrumentSound}");
        }
        public override void Desc()
        {
            Console.WriteLine($"Properties {MusicalInstrumentName}:\n{MusicalInstrumentProperties}");
        }
        public override void History()
        {
            Console.WriteLine($"History of {MusicalInstrumentName}:\n{MusicalInstrumentHistory}");
        }
        public override void Show()
        {
            Console.WriteLine($"Instrument name:\n{MusicalInstrumentName}");
        }
    }
}
