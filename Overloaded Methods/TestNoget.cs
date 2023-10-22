namespace Overloaded_methods
{
    public class TestNoget
    {
        public int Test(int a) {
            return a;
        }
        public int Test(int a, int b) {
            return a + b;
        }
        public int Test(int a, int b, int c) 
        {
            return a + b + c;
        }
    }
}
