using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    public class Screen : Comp_tech
    {
        public enum type_matrix
        {
            UNDEFINED, TN, IPS, VA, OLED, QLED
        };

        public type_matrix matrix { get; set; } // тип матрицы экрана

        private float _diagonal; // длина диагонали
        public float diagonal // не может быть меньше 0
        {
            get
            {
                return this._diagonal;
            }
            set
            {
                float t = value;
                if (t < 0)
                {
                    t = 0;
                }
                this._diagonal = t;
            }
        }

        private int _width; // штртна
        public int width // не может быть меньше 0
        {
            get
            {
                return this._width;
            }
            set
            {
                int t = value;
                if (t < 0)
                {
                    t = 0;
                }
                this._width = t;
            }
        }

        private int _height; // высота
        public int height // не может быть меньше 0
        {
            get
            {
                return this._height;
            }
            set
            {
                int t = value;
                if (t < 0)
                {
                    t = 0;
                }
                this._height = t;
            }
        }

        private int _frequency; // частота
        public int frequency // не может быть меньше 0
        {
            get
            {
                return this._frequency;
            }
            set
            {
                int t = value;
                if (t < 0)
                {
                    t = 0;
                }
                this._frequency = value;
            }
        }

        public Screen() : base()
        {
            this.matrix = type_matrix.UNDEFINED;
            this.diagonal = 0;
            this.width = 0;
            this.height = 0;
            this.frequency = 0;
        }

        public Screen(type_matrix matrix, float diagonal, int width, int height, int frequency, string firm, Colour colour, int price) : base(firm, colour, price)
        {
            this.matrix = matrix;
            if (diagonal < 0)
            {
                diagonal = 0;
            }
            this.diagonal = diagonal;
            if (width < 0)
            {
                width = 0;
            }
            this.width = width;
            if (height < 0)
            {
                height = 0;
            }
            this.height = height;
            if (frequency < 0)
            {
                frequency = 0;
            }
            this.frequency = frequency;
        }

        public override string ToString()
        {
            return $"Экран. Фирма: {firm}. Цвет: {colour}. Цена: {price}. Тип матрицы: {matrix}. Диагональ: {diagonal}. Ширина: {width}. Высота: {height}. Частота: {frequency}.";
        }
        public override void Print_Object()
        {
            Console.WriteLine($"Экран. Фирма: {firm}. Цвет: {colour}. Цена: {price}. Тип матрицы: {matrix}. Диагональ: {diagonal}. Ширина: {width}. Высота: {height}. Частота: {frequency}.");
        }
    }
}
