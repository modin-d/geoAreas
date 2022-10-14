using System;

namespace geoAreas
{
    public class Areas
    {
        //----------------нахождение площади треугольника по известным сторонам

        /// <summary>
        /// Площадь треугольника по известным трем сторонам
        /// </summary>
        /// <param name="a">длина 1й стороны</param>
        /// <param name="b">длина 2й стороны</param>
        /// <param name="c">длина 3й стороны</param>
        /// <returns>Площадь треугольника</returns>
        public static double getTriangleArea(double a, double b, double c)
        {
            //Проверка на нулевые и отрицательные значения
            if (a <= 0 || b <= 0 || c <= 0) { return 0; };

            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;
        }

        /// <summary>
        /// Площадь равностороннего треугольника (достаточно одной стороны)
        /// </summary>
        /// <param name="l">Длина стороны</param>
        /// <returns></returns>
        public static double getTriangleArea(double l)
        {
            return getTriangleArea(l, l, l);
        }

        /// <summary>
        /// Площадь треугольника из массива длин сторон (массив с одним значением для равностороннего, с тремя для любых треугольников)
        /// </summary>
        /// <param name="l">массив длин сторон</param>
        /// <returns>площадь</returns>
        public static double getTriangleArea(double[] l)
        {
            switch (l.Length)
            {
                case 1: return getTriangleArea(l[0]);
                case 3: return getTriangleArea(l[0], l[1], l[2]);
                default: return 0;
            }
        }



        // ----------------------------- Нахождение площади круга

        /// <summary>
        /// Площадь круга
        /// </summary>
        /// <param name="R">Значение радиуса</param>
        /// <returns>площадь</returns>
        public static double getСircleArea(double R)
        {
            //Проверка на нулевые и отрицательные значения
            if (R <= 0) { return 0; };

            double S = Math.PI * Math.Pow(R, 2);
            return S;
        }
    }
}
