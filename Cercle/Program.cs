using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;
using System.Security.Principal;
using System.Security.Cryptography.X509Certificates;
using System.Net.NetworkInformation;

namespace line_cercle
{
 
    public class Point
    {
        private int X;
        private int Y;
        private int originalX;
        private int originalY;
        public void Reset()
        {
            X = originalX;
            Y = originalY;
        }
        public Point(int x,int y)
        {
            X = x;
            Y = y;
            originalX = X;
            originalY = Y;
        }
        public void MoveX(int cord)
        {
            X = X + cord;
        }
        public void MoveY(int cord)
        {
            Y = Y + cord;
        }
        public string GetLocation()
        {
            return string.Format("location de cette point est {0},{1}", X, Y);
        }
    }
    public class Cercle
    {
        private float C,R;
        private const float pi=3.14;
        public Cercle(int c,int r)
        {
            this.C = c;
            this.R = r;
      
        }
        public Afficher()
        {
            Point p = new Point(x, y);
        }
        public getcirconférence(float C)
        {
            C=pi*2*R;
        }
        public getaire(float A)
        {
            A=pi*R*R;
        }
        public Intersection (Point p)
        {

        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}