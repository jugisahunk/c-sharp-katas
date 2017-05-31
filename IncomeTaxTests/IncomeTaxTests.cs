using NUnit.Framework;
using System;

[TestFixture()]
public class IncomeTaxTests
{
    [Test()]
    public void No_Income_Resturns_0()
    {
      IncomeTax tax = new IncomeTax();
    }
}
