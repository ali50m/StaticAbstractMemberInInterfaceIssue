using Microsoft.Extensions.DependencyInjection;

// these line works!
IFoo foo = new Foo();
Foo.GetCount();

var services = new ServiceCollection();
services.AddSingleton<IFoo, Foo>(); // why this line can not compile?

// error message:
// The interface 'IFoo' type cannot be used as a type argument for type parameter 'TService'.
// The interface has static abstract members without implementations: int IFoo.GetCount()

public interface IFoo
{
    static abstract int GetCount();
}

public class Foo : IFoo
{
    public static int GetCount()
    {
        return 1;
    }
}
