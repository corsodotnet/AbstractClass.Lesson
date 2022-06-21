using System;

namespace AbstractClass.Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Continente continente = new Continente();                       
            Worker paolo = new Worker();            
            Manager bruno = new Manager(paolo); 
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

           Country _germany = null;
          // public int _nPositivi = 10 ;
           public new int _nPositivi = 11;
           public int NPositivi { get { return base._nPositivi; } }

        public Continente()
        {
            _germany = new Country(); // Una proprietà di Contiente  
        }

    }
    public class Country : AreaGeografica
    {
       
    }
    public class City : AreaGeografica
    {

    }

    public class Manager
    {
        Worker _worker1 = null;

        public Manager(Worker Worker)
        {
            _worker1 = Worker;
        }
    }
    public class Worker
    {

    }

    public class CoffeeMachine
    {
        public CoffeeMachine(Coffee caffe)
        {

        }

        public void MakeCoffee(Coffee caffe) // Stack  -> oggetti temporane + Metodi e funzioni
        {    
            // fa il caffe 
            // Esce dal ciclo 
            // rilasdciato dalla memoria 
        }
    }
    public class Coffee
    {

    }
}
