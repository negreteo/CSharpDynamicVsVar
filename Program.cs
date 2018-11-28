using System;

namespace CSharpDynamicVsVar {
  class Program {
    static void Main (string[] args) {

      // Example 1

      // Object, type can be changed after being assigned      
      dynamic testDynamic = "";

      // Changes at design time, it has to be initialized in order to know what type is going to be.
      // Once the type has been assigned, it cannot be changed.
      var testVar = 2;

      // Will not work because testVar was initialized as an int
      // testVar = 1.1;

      testDynamic = 1;
      testDynamic = testDynamic + 2.1;

      Console.WriteLine (testDynamic);

      // Example 2

      dynamic testDynamic2 = new Person ();
      var testVar2 = new Person ();

      // No intellisense
      testDynamic2.FirstName = "Matt";
      testDynamic2.LastName = "Murdock";
      // Will not fail until code is executed
      // testDynamic2.Email = "daredevil@email.com";

      testVar2.FirstName = "Jessica";
      testVar2.LastName = "Jones";

      testDynamic2.SayHello ();
      testVar2.SayHello ();

      // Example 3

      dynamic testDynamic3 = "";
      var testVar3 = "";

      Console.WriteLine (GetMessage ());
    }

    // we cannot return a var type
    // static var GetMessage()  
    // we can return a dynamic type
    // static dynamic GetMessage()
    static string GetMessage () {
      return "This is a test";
    }

  }
}
