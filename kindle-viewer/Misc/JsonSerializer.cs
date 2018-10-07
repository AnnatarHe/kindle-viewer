﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp.Deserializers;
using RestSharp.Serializers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kindle_viewer.Misc {



    class JsonSerializer {
        private readonly Newtonsoft.Json.JsonSerializer _serializer;

        public JsonSerializer() {
            ContentType = "application/json";
            _serializer = new Newtonsoft.Json.JsonSerializer {
                MissingMemberHandling = MissingMemberHandling.Ignore,
                NullValueHandling = NullValueHandling.Include,
                DefaultValueHandling = DefaultValueHandling.Include,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = DateTimeZoneHandling.Unspecified
            };
        }

        public JsonSerializer(Newtonsoft.Json.JsonSerializer serializer) {
            ContentType = "application/json";
            _serializer = serializer;
        }

        public string Serialize(object obj) {
            using (var stringWriter = new StringWriter()) {
                using (var jsonTextWriter = new JsonTextWriter(stringWriter)) {
                    jsonTextWriter.Formatting = Formatting.Indented;
                    jsonTextWriter.QuoteChar = '"';

                    _serializer.Serialize(jsonTextWriter, obj);

                    var result = stringWriter.ToString();
                    return result;
                }
            }
        }

        public string DateFormat { get; set; }
        public string RootElement { get; set; }
        public string Namespace { get; set; }
        public string ContentType { get; set; }

        public T Deserialize<T>(string content) {
            using (var stringReader = new StringReader(content)) {
                using (var jsonTextReader = new JsonTextReader(stringReader)) {
                    return _serializer.Deserialize<T>(jsonTextReader);
                }
            }
        }

        public T Deserialize<T>(object content) {
            return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(content));
        }
    }
}
