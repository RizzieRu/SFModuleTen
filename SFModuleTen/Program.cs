using SFModuleTen.Services;
using SFModuleTen.Services.Inferfaces;

ICalculator calculator = new Calculator();
ILogger logger = new Logger();

try
{
    logger.LogEvent("Программа запущена. Введите два числа:");

    Console.Write("Введите первое число: ");
    int a = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException());

    Console.Write("Введите второе число: ");
    int b = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException());

    int result = calculator.Add(a, b);
    logger.LogEvent($"Результат сложения: {result}");
}
catch (FormatException)
{
    logger.LogError("Ошибка: введено некорректное число.");
}
catch (ArgumentNullException)
{
    logger.LogError("Ошибка: пустое значение.");
}
catch (Exception ex)
{
    logger.LogError($"Непредвиденная ошибка: {ex.Message}");
}
finally
{
    logger.LogEvent("Программа завершена.");
}