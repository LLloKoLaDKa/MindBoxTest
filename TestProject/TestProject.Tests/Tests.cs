using NUnit.Framework;
using System;
using TestProject.FigureCalculating;
using TestProject.FigureCalculating.Models;

namespace TestProject.Tests
{
    public class Tests
    {
        [Test]
        public void Circle_R2_Result12DOT57()
        {
            //arrange
            Circle circle = new(2);

            //act
            Double result = Calculate.GetFigureSquare(circle);

            //assert
            Assert.AreEqual(result, 12.57);
        }

        [Test]
        public void RightTriangle_6_8_10_Result24()
        {
            //arrange
            Triangle triangle = new(6,8,10);

            //act
            Double result = Calculate.GetFigureSquare(triangle);

            //assert
            Assert.AreEqual(result, 24);
        }


        [Test]
        public void Triangle_6_8_4_Result11DOT62()
        {
            //arrange
            Triangle triangle = new(6, 8, 4);

            //act
            Double result = Calculate.GetFigureSquare(triangle);

            //assert
            Assert.AreEqual(result, 11.62);
        }
    }
}