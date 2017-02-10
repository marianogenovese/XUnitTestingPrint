using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace XUnitTestingPrint
{
    public class Class1
    {
		private readonly ITestOutputHelper output;

		public Class1(ITestOutputHelper output)
		{
			this.output = output;
		}

		[Fact]
		public void PassingTest()
		{
			this.output.WriteLine("Hola");
			Assert.Equal(4, Add(2, 2));
		}

		[Fact]
		public void FailingTest()
		{
			Assert.Equal(5, Add(2, 2));
		}

		int Add(int x, int y)
		{
			return x + y;
		}
	}
}
