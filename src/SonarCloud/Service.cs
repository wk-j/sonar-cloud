using System;
using System.IO;

namespace SonarCloud {
    public enum Color { Green, Blue }

    public class Service {

        public Color GetNextColor(Color input) {
            var color = input + 1;
            return color;
        }

        public Color GetNextColor2(Color input) {
            var color = input + 1;
            return color;
        }

        public static void LockNull() {
            lock (null) {
                Console.WriteLine("This is bug");
            }
        }

        public static void A() {
            using (var fs = new FileStream("path", FileMode.OpenOrCreate))
            using (var sr = new StreamReader(fs)) {
                Console.Write(sr.ReadLine());
            }
        }
    }
}