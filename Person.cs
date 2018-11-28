using System;

namespace CSharpDynamicVsVar {
  public class Person {
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public void SayHello () {
      Console.WriteLine ($"Hello {FirstName} {LastName}");
    }

  }
}
