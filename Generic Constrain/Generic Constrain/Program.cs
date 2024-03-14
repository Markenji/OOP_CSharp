public class MyClass<T> where T : class
{

}

public class MyGenericClass<T> where T : struct
{

}


public class MyConstuctorClass<T> where T : new()
{

}

public class MyDerrivedClass<T> where T : MyBaseClass
{

}

public class MyInterfaceClass<T> where T : IMyInterface

{ }
