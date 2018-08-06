using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace SonarCloud {
    public enum Color { Green, Blue }

    public class Service {

        public int Add(int a, int b) => a + b;
        public int Add3(int a) => a + 3;
        public int Add4(int a) => a + 4;


        public Color GetNextColor(Color input) {
            var color = input + 1;
            return color;
        }

        public static void LockNull() {
            lock (null) {
                Console.WriteLine("This is ...");
            }
        }

        [SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times")]
        public static void A() {
            using (var fs = new FileStream("path", FileMode.OpenOrCreate))
            using (var sr = new StreamReader(fs)) {
                Console.Write(sr.ReadLine());
            }
        }
    }
}