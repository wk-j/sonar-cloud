using System;
using System.IO;

namespace SonarCloud {
    public class Service {
        public static void LockNull() {
            lock (null) {
                Console.WriteLine("This is bug");
            }
        }

        public static void A() {
            using (var fs = new FileStream("path", FileMode.OpenOrCreate)) { // RCS1005
                using (var sr = new StreamReader(fs)) {
                }
            }
        }
    }
}