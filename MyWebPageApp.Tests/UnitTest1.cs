using Xunit;

namespace MyWebPageApp.Tests;

public class SampleTests
{
    [Fact]
    public void TrueShouldBeTrue_Test()
    {
        // Простейший тест для проверки CI-конвейера
        Assert.Equal(1, 2);
    }
}
