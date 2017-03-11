﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Newtonsoft.Json;

namespace ifme
{
    public static class Get
    {
		public static Dictionary<string, string> LanguageCode
		{
			get
			{
				return JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText("language.json"));
			}
		}

		public static Dictionary<string, string> MimeType
		{
			get
			{
				return JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText("mime.json"));
			}
		}

		public static string CodecFormat(string codecId)
        {
            var json = File.ReadAllText("format.json");
            var format = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            var formatId = string.Empty;

            if (format.TryGetValue(codecId, out formatId))
                return formatId;

            return "mkv";
        }
    }
}