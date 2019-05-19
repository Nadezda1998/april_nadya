using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ConsoleApp2;

namespace ConsoleApp2
{
    /*Структурный тест*/
    /*1*/
    [TestClass]
    public class MinMaxLenTest
    {
        [TestMethod]
        public void MinTest()
        {
            string input = "Люблю грозу в начале мая";
            string[] str;
            int max, min;

            MinMaxLen.Proverka(input, out str, out max, out min);

            Assert.AreEqual(2, min);
            Assert.AreEqual(3, max);
            Assert.IsTrue(str.SequenceEqual(new String[] { "Люблю", "грозу", "в", "начале", "мая" }));
        }

        /*2 структурный и функциональный тест, граничное значение*/
        [TestMethod]
        public void MinTest2()
        {
            string input = "";
            string[] str;
            int max, min;

            MinMaxLen.Proverka(input, out str, out max, out min);

            Assert.AreEqual(0, min);
            Assert.AreEqual(0, max);
            Assert.IsTrue(str.SequenceEqual(new String[] { }));
        }

        /*Структурный тест*/
        /*3*/
        [TestMethod]
        public void MinTest3()
        {
            string input = "!";
            string[] str;
            int max, min;

            MinMaxLen.Proverka(input, out str, out max, out min);

            Assert.AreEqual(0, min);
            Assert.AreEqual(0, max);
            Assert.IsTrue(str.SequenceEqual(new String[] { }));
        }

        /*Структурный тест*/
        /*4*/
        [TestMethod]
        public void MinTest4()
        {
            string input = "Seattle is a big city";
            string[] str;
            int max, min;

            MinMaxLen.Proverka(input, out str, out max, out min);

            Assert.AreEqual(2, min);
            Assert.AreEqual(0, max);
            Assert.IsTrue(str.SequenceEqual(new String[] { "Seattle", "is", "a", "big", "city" }));
        }

        /*2 и структурный, и функциональный тест*/
        /*5*/
        [TestMethod]
        public void MinTest5()
        {
            string input = "В городе было тепло";
            string[] str;
            int max, min;

            MinMaxLen.Proverka(input, out str, out max, out min);

            Assert.AreEqual(0, min);
            Assert.AreEqual(1, max);
            Assert.IsTrue(str.SequenceEqual(new String[] { "В", "городе", "было", "тепло" }));
        }

        /*ФункциональнЫЙ тест*/
        /*6*/
        [TestMethod]
        public void MinTest6()
        {
            string input = "Из истории вычислительной техники";
            string[] str;
            int max, min;

            MinMaxLen.Proverka(input, out str, out max, out min);

            Assert.AreEqual(0, min);
            Assert.AreEqual(2, max);
            Assert.IsTrue(str.SequenceEqual(new String[] { "Из", "истории", "вычислительной", "техники" }));
        }

        /*ФункциональнЫЙ тест*/
        /*7*/
        [TestMethod]
        public void MinTest7()
        {
            string input = "Сегодня холодно";
            string[] str;
            int max, min;

            MinMaxLen.Proverka(input, out str, out max, out min);

            Assert.AreEqual(0, min);
            Assert.AreEqual(0, max);
            Assert.IsTrue(str.SequenceEqual(new String[] { "Сегодня", "холодно" }));
        }

        /*ФункциональнЫЙ тест и граничное значение*/
        /*8*/
        [TestMethod]
        public void MinTest8()
        {
            string input = "Я";
            string[] str;
            int max, min;

            MinMaxLen.Proverka(input, out str, out max, out min);

            Assert.AreEqual(0, min);
            Assert.AreEqual(0, max);
            Assert.IsTrue(str.SequenceEqual(new String[] { "Я" }));
        }


        /*ФункциональнЫЙ тест*/
        /*9*/
        [TestMethod]
        public void MinTest9()
        {
            string input = "Тысячадевятьсотвосьмидесятидевятимиллиметровый";
            string[] str;
            int max, min;

            MinMaxLen.Proverka(input, out str, out max, out min);
        
            Assert.AreEqual(0, min);
            Assert.AreEqual(0, max);
            Assert.IsTrue(str.SequenceEqual(new String[] { "Тысячадевятьсотвосьмидесятидевятимиллиметровый" }));
        }
    }
}
