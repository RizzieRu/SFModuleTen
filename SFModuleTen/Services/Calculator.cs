using SFModuleTen.Services.Inferfaces;

namespace SFModuleTen.Services;

public class Calculator : ICalculator
{
    public int Add(int a, int b) => a + b;
}