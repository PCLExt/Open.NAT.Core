using System;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Open.Nat.UnitTests
{
	[TestClass]
	public class UpnpNatDeviceInfoTests
	{
#if !NETCOREAPP2_0
        [TestMethod]
		public void x()
		{
			var info = new UpnpNatDeviceInfo(IPAddress.Loopback, new Uri("http://127.0.0.1:3221"), "/control?WANIPConnection", null);
			Assert.AreEqual("http://127.0.0.1:3221/control?WANIPConnection", info.ServiceControlUri.ToString());
		}
#endif
    }
}
