using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp6
{
    class thehangedman
    {
        public bool status = true;
        public int turnsleft;
        public string strdisplay;
        private string originalstr;
        public thehangedman(string oristr,int turnsava)
        {
            this.originalstr = oristr.ToLower();
            this.strdisplay = string.Concat(Enumerable.Repeat("*", oristr.Length));
            this.turnsleft = turnsava;
        }
        public string attemptchar(char attempt)
        {

            if(this.originalstr.Contains(attempt))
            {
                for (int i = 0; i < this.originalstr.Length; i++)
                {
                    if (this.originalstr[i] == attempt)
                    {
                        StringBuilder sb = new StringBuilder(this.strdisplay);
                        sb[i] = attempt;
                        this.strdisplay = sb.ToString();
                    }
                       
                }
                if (this.originalstr == this.strdisplay)
                {
                    this.status = false;
                    return "GG kid you won";
                }
                return "You found a char";
            }
            else
            {
                if(this.turnsleft == 0)
                {
                    this.status = false;
                    return "No attemps left originalstring = " + this.originalstr;
                }
                return "Char not in string attemps left = " + this.turnsleft--;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var Game1 = new thehangedman(Console.ReadLine(),6);
            while(Game1.status){
                Console.WriteLine(Game1.strdisplay);
                Console.WriteLine(Game1.attemptchar(char.Parse(Console.ReadLine())));
            }
        }
    }
}
