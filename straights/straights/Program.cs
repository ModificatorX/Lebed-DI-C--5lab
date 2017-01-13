using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace straights
{
    public class Point
    {
        private float X, Y;
        public void set(float x, float y){
            X = x; Y = y;
        }
        public void set()
        {
            X = Console.Read(); Console.Read(); Y = Console.Read();
        }
        public float getX() { return X; }
        public float getY() { return Y; }
    }
    public class Otrezok
    {
        protected Point P1, P2;
        public void set(Point p1, Point p2)
        {
            P1.set(p1.getX(), p1.getY()); P2.set(p2.getX(), p2.getY());
        }
        public void set1() {
            
        }
    }
    public class Polupryamaya: Otrezok
    {
        private Point Pcross;
        public float prfunc(float x) {return P1.getY()+(P2.getY()- P1.getY())*(x-P1.getX())/(P2.getX()-P1.getX()); }
        public void intersect(Otrezok ot) {

        }
        

    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite koordinaty polypryamoy");
            

            Console.ReadKey();

        }
    }
}
