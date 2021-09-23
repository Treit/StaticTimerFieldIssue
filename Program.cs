namespace Something
{
    class Test
    {
        static Timer? _timer;

        public static void Main()
        {
            TimerTest();

            while (true)
            {
                Thread.Sleep(500);
                GC.Collect(2, GCCollectionMode.Forced);
            }
        }

        static void TimerTest()
        {
            try
            {
                static void timerCallback(object? _)
                {
                    Console.WriteLine("Callback!");
                }

                Timer timer = new(timerCallback, null, TimeSpan.Zero, TimeSpan.FromSeconds(2));

                _timer = timer;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}