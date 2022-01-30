using System;

namespace StringProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] helloArray = { 'h', 'e', 'l', 'l', 'o'};
            char[] worldArray = { 'w', 'o', 'r', 'l', 'd'};

            String hello = new String(helloArray);

            //String world = new String(worldArray);

            //hello.Show();
            //world.Show();



            //String helloWorld = hello.Concatenate(world);
            //for (int i = 0; i < helloWorld.Length; i++)
            //{
            //    Console.WriteLine(helloWorld[i]);
            //}

            //helloWorld.ToUpper().Show();
            //helloWorld.Apply((char symbol) => '_').Show();
        }
    }
}
