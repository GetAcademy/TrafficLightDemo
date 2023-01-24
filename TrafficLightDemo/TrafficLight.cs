namespace TrafficLightDemo
{
    internal class TrafficLight
    {
        private int _phase;

        //public bool IsRedOn => _phase is 1 or 2;
        public bool IsRedOn => _phase < 3;
        public bool IsYellowOn => _phase is 2 or 4;
        //public bool IsYellowOn => _phase % 2 == 0;
        public bool IsGreenOn => _phase == 3;

        public TrafficLight()
        {
            //IsRedOn = true;
            _phase = 1;
        }

        public void Next()
        {
            _phase++;
            if (_phase == 5) _phase = 1;
        }
        //    if (IsRedOn && IsYellowOn)
        //    {
        //        IsRedOn = false;
        //        IsYellowOn = false;
        //        IsGreenOn = true;
        //    }
        //    else if (IsRedOn)
        //    {
        //        IsYellowOn = true;
        //    }
        //    else if (IsGreenOn)
        //    {
        //        IsGreenOn = false;
        //        IsYellowOn = true;
        //    }
        //    else
        //    {
        //        IsRedOn = true;
        //        IsYellowOn = false;
        //    }

        public void Show()
        {
            Console.ForegroundColor = IsRedOn ? ConsoleColor.Red : ConsoleColor.Gray;
            Console.Write("O");
            Console.ForegroundColor = IsYellowOn ? ConsoleColor.Yellow : ConsoleColor.Gray;
            Console.Write("O");
            Console.ForegroundColor = IsGreenOn ? ConsoleColor.Green : ConsoleColor.Gray;
            Console.WriteLine("O");
        }
    }
}
