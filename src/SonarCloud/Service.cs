using System;
using System.IO;

namespace SonarCloud {
    public class Service {

        enum Color { Green, Blue }

        public static void Enummmm() {
            var color = Color.Green - 1;
            Console.WriteLine(color);
        }

        public static void LockNull() {
            lock (null) {
                Console.WriteLine("This is bug");
            }
        }

        public static void A() {
            using (var fs = new FileStream("path", FileMode.OpenOrCreate))
            using (var sr = new StreamReader(fs)) {
            }
        }
    }
}