using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    public class Keyboard : Comp_tech
    {

        public enum Type_KB
        {
            UNDEFINED, Membrane, Mechanical, Scissor, Optical
        };

        public enum KB_form
        {
            UNDEFINED, ANSI, ISO
        };

        public enum KB_Size
        {
            UNDEFINED,
            FullSize,    // Полноразмерная (100%)
            Eighty,      // 80%
            SeventyFive, // 75%
            SixtyFive,   // 65% (68%)
            Forty        // 40%
        };

        public Type_KB Type { get; set; } // тип клавиатуры
        public KB_form Format { get; set; } // формат данных клавиатуры
        public KB_Size Size { get; set; } // размер клавиатуры

        private int _durability; // прочность клавиатуры (количество нажатий)
        public int durability // прочность не может быть отрицательной
        {
            get
            {
                return this._durability;
            }
            set
            {
                int t = value;
                if (t < 0)
                {
                    t = 0;
                }
                this._durability = t;
            }
        }

        public Keyboard(): base()
        {
            Type_KB.TryParse("UNDEFINED", out Type_KB type);
            this.Type = type;
            KB_form.TryParse("UNDEFINED", out KB_form format);
            this.Format = format;
            KB_Size.TryParse("UNDEFINED", out KB_Size size);
            this.Size = size;
            this.durability = 10000;
        }

        public Keyboard(KB_Size Size, Type_KB Type, KB_form Format, string firm, Colour colour, int price, int durability = 10000) : base(firm, colour, price)
        {
            this.Type = Type;
            this.Format = Format;
            this.Size = Size;
            int t = durability;
            if (t < 10000) // прочность новой клавиатуры не может быть меньше десяти тысяч нажатий
            {
                t = 10000;
            }
            this.durability = t;
        }

        public override string ToString()
        {
            return $"Клавиатура. Фирма: {firm}. Цвет: {colour}. Цена: {price}. Тип клавиатуры: {Type}. Формат клавиатуры: {Format}. Размер клавиатуры: {Size}. Прочность: {durability}.";
        }

        public override void Print_Object()
        {
            Console.WriteLine($"Клавиатура. Фирма: {firm}. Цвет: {colour}. Цена: {price}. Тип клавиатуры: {Type}. Формат клавиатуры: {Format}. Размер клавиатуры: {Size}. Прочность: {durability}.");
        }
    }
}
