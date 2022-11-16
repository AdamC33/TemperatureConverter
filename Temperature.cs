static class Temperature
{
    public static float celsiusToFahrenheit(float celsius)
    {
        return (celsius * 1.8F) + 32; //Celsius to fahrenheit is multiply by 1.8 and add 32
    }
    public static float fahrenheitToCelsius(float fahrenheit)
    {
        return (fahrenheit - 32) / 1.8F; //Inverse of celsius to fahrenheit
    }
    public static float celsiusToKelvin(float celsius)
    {
        return celsius + 273.15F;
    }
    public static float fahrenheitToKelvin(float fahrenheit)
    {
        return ((fahrenheit - 32) / 1.8F) + 273.15F; //Converts from fahrenheit to celsius, then from celsius to kelvin
    }
}