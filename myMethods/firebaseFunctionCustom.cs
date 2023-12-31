﻿using Google.Cloud.Storage.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace Upic.myMethods.firebaseFunctionCustom
{
    class firestoreDatabase
    {
        public void connectToDatabase(string configFileName)
        {
            // Config file must be in "AppDomain.CurrentDomain.BaseDirectory" directory
            string path = AppDomain.CurrentDomain.BaseDirectory + '/' + configFileName;
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
        }

        public string getProjectID(string configFileName)
        {
            string jsonFile = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + '/' + configFileName);
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            Dictionary<string, object> json_Dictionary = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonFile);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

#pragma warning disable CS8603 // Possible null reference return.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            return json_Dictionary["project_id"].ToString();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
#pragma warning restore CS8603 // Possible null reference return.
        }
    }

    class firebaseStorage
    {
        public string getBucketName(string configFileName)
        {
            string jsonFile = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + '/' + configFileName);
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            Dictionary<string, object> json_Dictionary = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonFile);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            var bucketName = json_Dictionary["bucketName"].ToString();
#pragma warning restore CS8602 // Dereference of a possibly null reference.

#pragma warning disable CS8603 // Possible null reference return.
            return bucketName;
#pragma warning restore CS8603 // Possible null reference return.
        }
    }
}
