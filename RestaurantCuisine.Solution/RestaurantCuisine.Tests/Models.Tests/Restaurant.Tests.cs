using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantCuisine.Models;

namespace RestaurantCuisine.Models.Tests
{
  [TestClass]
  public class RestaurantTests : IDisposable
  {
    public void Dispose()
    {
      Restaurant.ClearAll();
    }
    // [TestMethod]
    // public void Method_Description_ExpectedValue()
    // {
    //   Assert.AreEqual(var1, method(input));
    // }
  }
}
