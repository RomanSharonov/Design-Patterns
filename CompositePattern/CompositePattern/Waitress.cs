namespace CompositePattern {
    public class Waitress {
        private  Menu _allMenus;

        public Waitress(Menu allMenus) {
            _allMenus = allMenus;
        }

        public void PrintMenu() {
            _allMenus.Print();
        }
    }
}
