static class ConsoleDisplay
{
    public static int inputTempScale(bool convertingTo, string scaleConvertingTo = "") //The scaleConvertingTo parameter is optional. It is only needed when displaying the converting to screen.
    {
        int tempScale = 0;
        string toOrFrom = "";
        string scale1 = "";
        string scale2 = "";
        if (convertingTo == false)
        {
            toOrFrom = "from";
            scale1 = "Celsius";
            scale2 = "Fahrenheit";
        }
        else
        {
            toOrFrom = "to";
            scale1 = scaleConvertingTo;
            scale2 = "Kelvin";
        }
        do
        {
            Console.WriteLine("Please select the temperature scale you'd like to convert "+ toOrFrom + ":\n[1] "+ scale1 + "\n[2] "+ scale2 +"\nInput the number to make your selection.");
            try
            {
                tempScale = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                tempScale = 0;
                Console.WriteLine("Please only enter either 1 or 2.");
            }
            if (tempScale != 1 && tempScale != 2)
            {
                Console.WriteLine("Please only enter either 1 or 2.");
            }
        }
        while (tempScale != 1 && tempScale != 2);
        return tempScale;
    }
    public static float inputTemperature()
    {
        float temperature = 0F;
        bool floatParseSuccessful = true;
        do
        {
            floatParseSuccessful = true; //Every time the loop starts this is true. It only goes to false if an exception is caught.
            Console.WriteLine("Please enter the temperature in the selected scale.");
            try
            {
                temperature = Single.Parse(Console.ReadLine()); //Created by adapting examples shown at
                //https://learn.microsoft.com/en-us/dotnet/api/system.single.parse?view=net-6.0
            }
            catch (System.FormatException)
            {
                floatParseSuccessful = false;
                temperature = 0;
                Console.WriteLine("Please only enter float values.");
            }
        }
        while (floatParseSuccessful == false);
        return temperature;
    }
}