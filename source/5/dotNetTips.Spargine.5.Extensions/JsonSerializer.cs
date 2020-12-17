// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions **
// Author           : David McCarter
// Created          : 09-16-2017
//
// Last Modified By : David McCarter
// Last Modified On : 06-03-2019
// ***********************************************************************
// <copyright file="JsonSerializer.cs" company="David McCarter - dotNetTips.com">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace dotNetTips.Spargine.Extensions
{
    /// <summary>
    /// Class JsonSerializer.
    /// </summary>
    internal static class JsonSerializer
    {
        /// <summary>
        /// De-serializes the specified Json.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="json">The json.</param>
        /// <returns>T.</returns>
        internal static T Deserialize<T>(string json)
            where T : class
        {
            var obj = Activator.CreateInstance<T>();

            using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
            {
                var ser = new DataContractJsonSerializer(obj.GetType());
                obj = ser.ReadObject(ms) as T;
            }

            return obj;
        }

        /// <summary>
        /// Serializes the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns>System.String.</returns>
        internal static string Serialize(object obj)
        {
            string json;

            using (var ms = new MemoryStream())
            {
                var ser = new DataContractJsonSerializer(obj.GetType(),
                                                         new DataContractJsonSerializerSettings
                                                         {
                                                             SerializeReadOnlyTypes = true,
                                                             UseSimpleDictionaryFormat = true,
                                                             EmitTypeInformation = EmitTypeInformation.AsNeeded
                                                         });

                ser.WriteObject(ms, obj);

                json = Encoding.UTF8.GetString(ms.ToArray());
            }

            return json;
        }
    }
}
