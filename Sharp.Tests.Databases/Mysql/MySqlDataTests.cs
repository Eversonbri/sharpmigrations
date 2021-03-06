﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Sharp.Data;
using Sharp.Data.Databases;
using Sharp.Tests.Databases.Data;

namespace Sharp.Tests.Databases.Mysql {
	[TestFixture]
	public class MySqlDataTests : DataClientDataTests {
		[SetUp]
		public void SetUp() {
            _dataClient = DBBuilder.GetDataClient(DataProviderNames.MySql);
		}
	}
}
