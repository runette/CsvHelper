﻿using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CsvHelper.Tests.Mappings.Attribute
{
	public class InjectionOptionsTests
	{
		[Fact]
		public void ConstructorAttributeTest()
		{
			var config = CsvConfiguration.FromType<Foo>(CultureInfo.InvariantCulture);
			Assert.Equal(InjectionOptions.Escape, config.InjectionOptions);
		}

		[InjectionOptions(InjectionOptions.Escape)]
		private class Foo { }
	}
}
