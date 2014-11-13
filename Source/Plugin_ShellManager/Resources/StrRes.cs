﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Altman.Plugin;
using Altman.Plugin.Interface;

namespace Plugin_ShellManager.Resources
{
	public static class StrRes
	{
		private static IHost _host;

		public static void SetHost(IHost host)
		{
			_host = host;
		}

		public static string GetString(string strName, string strDefault)
		{
			if (_host != null)
			{
				return _host.Ui.GetTranslatedText(strName, strDefault);
			}
			return strDefault;
		}
	}
}
