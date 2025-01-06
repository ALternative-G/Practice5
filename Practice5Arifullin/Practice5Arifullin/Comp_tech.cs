using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    public interface IPrintable
    {
        void Print_Object();
    }

    public class Comp_tech : IPrintable
    {

        public enum Colour
        {
            UNDEFINED, White, Gray, Black, Blue, Red, Green, Purple
        };

        public string firm { get; set; } // фирма-производитель
        public Colour colour { get; set; } // цвет

        private int _price; // цена
        public int price // цена не может быть отрицательной
        {
            get
            {
                return this._price;
            }
            set
            {
                int t = value;
                if (t < 0)
                {
                    t = 0;
                } 
                this._price = t;
            }
        }

        public Comp_tech() : this("UNKNOWN", Colour.UNDEFINED, 1)
        {

        }

        public Comp_tech(string firm, Colour colour, int price)
        {
            this.firm = firm;
            this.colour = colour;
            if (price < 0)
            {
                price = 0;
            }
            this._price = price;
        }

        public override string ToString()
        {
            return $"Компьютерная техника. Фирма: {firm}. Цвет: {colour}. Цена: {price}.";
        }

        public virtual void Print_Object()
        {
            Console.WriteLine($"Компьютерная техника. Фирма: {firm}. Цвет: {colour}. Цена: {price}.");
        }

    }
}
