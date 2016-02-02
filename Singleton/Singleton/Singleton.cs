namespace Singleton {
    public class Singleton {
        private static Singleton _uniqueInstance;
        private Singleton() { }

        public static Singleton GetInstance() {
            return _uniqueInstance ?? (_uniqueInstance = new Singleton());
        }
    }
}
