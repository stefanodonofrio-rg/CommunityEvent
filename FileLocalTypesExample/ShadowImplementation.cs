namespace FileLocalTypesExample
{
    class ShadowImplementation
    {
        public ShadowImplementation()
        {
            var testShadow = new TestShadow();
        }
    }

    file class TestShadow
    {
        public TestShadow()
        {
            Console.WriteLine("Test from file class");
        }
    }
}
