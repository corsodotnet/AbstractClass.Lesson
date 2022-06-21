using System;

namespace AbstractClass.Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Continente continente = new Continente();
            Console.WriteLine("Il varole del padre +: "+ continente.NPositivi); 
        }
    }

    public class AreaGeografica
    {  
        // membri
        public int _nPositivi = 10 ;
        public int _posizione;
        public int _nAbitanti;

    }
    public class Continente : AreaGeografica
    {
        // public int _nPositivi = 10 ;
           public new int _nPositivi = 20;
           public int NPositivi { get { return base._nPositivi; } } 
    }
}
