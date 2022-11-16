int again = 1;
do
{
    float temperature = 0F;
    float convertedTemperature = 0F;
    string fromAndTo = ""; //Two character string. First character is the scale from, second character is the scale to

    int tempScaleFrom = ConsoleDisplay.inputTempScale(false);


    //Inversion of the selected temperature to find what temperature it should convert to. It is in string format as it is passed onto a WriteLine.

    string convertTo;
    if (tempScaleFrom == 1)
    {
        convertTo = "Fahrenheit";
    }
    else
    {
        convertTo = "Celsius";
    }

    temperature = ConsoleDisplay.inputTemperature();


    int tempScaleTo = ConsoleDisplay.inputTempScale(true, convertTo);

    if (tempScaleFrom == 1)
    {
        fromAndTo += "C";
        if (tempScaleTo == 1)
        {
            convertedTemperature = Temperature.celsiusToFahrenheit(temperature);
            fromAndTo += "F";
        }
        else
        {
            convertedTemperature = Temperature.celsiusToKelvin(temperature);
            fromAndTo += "K";
        }
    }
    else
    {
        fromAndTo += "F";
        if (tempScaleTo == 1)
        {
            convertedTemperature = Temperature.fahrenheitToCelsius(temperature);
            fromAndTo += "C";
        }
        else
        {
            convertedTemperature = Temperature.fahrenheitToKelvin(temperature);
            fromAndTo += "K";
        }
    }

    Console.WriteLine("The temperature has been converted from " + temperature + "°" + fromAndTo[0] + " to " + convertedTemperature + "°" + fromAndTo[1]);
    Console.WriteLine("Would you like to do more conversions? (Input 1 for yes, any other input is a no)");
    try
    {
        again = Convert.ToInt32(Console.ReadLine());
    }
    catch (System.FormatException)
    {
        //Nothing in here, this is just so the program closes safely instead of crashing
    }
}
while (again == 1);