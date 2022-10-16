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
/* Ответ на вопрос о выборке из базы данных (SQL запрос для выбора всех пар «Имя продукта – Имя категории»)
 Пусть таблица продуктов называется Goods

CREATE TABLE dbo.Goods (
id int primary key identity, 
GoodName varchar(250))

, таблица категорий Categories. 

CREATE TABLE dbo.Categories (
id int primary key identity, 
CatName varchar(100))

В задании не сказано каким образом осуществляется множественная свящь между продуктами и категориями, исходя из опаыта предложу связь в виде таблицы вида GoodCats содержащую следующие поля 

CREATE TABLE dbo.GoodCats (
id int primary key identity, 
Good_id int,
Сategory_id int)
  
тогда запрос на выборку согласно задания будет 

SELECT 
g.GoodName as 'Имя продукта', 
c.CatName as 'Имя категории'
FROM Goods as g
LEFT JOIN GoodCats as gc ON g.id=gc.Good_id
LEFT JOIN Categories as c ON gc.Сategory_id=c.id
ORDER BY GoodName
 */
