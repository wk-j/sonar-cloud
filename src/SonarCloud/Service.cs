using System;

namespace SonarCloud {
    public class Service {
        public void LockNull() {
            lock (null) {
                Console.WriteLine("This is bug");
            }
        }
    }
}