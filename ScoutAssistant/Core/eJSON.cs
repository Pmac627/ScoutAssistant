using Newtonsoft.Json;
using System;
using System.Text;

namespace ScoutAssistant.Extensions
{
    /// <summary>
    /// Exposes a collection of JSON extensions.
    /// </summary>
    public static class eJSON
    {
        /// <summary>
        /// Deserializes the specified object from JSON to <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type of output desired.</typeparam>
        /// <param name="obj">The object to be deserialized.</param>
        /// <returns>
        /// Returns the object deserialized as type <typeparamref name="T"/>; otherwise returns type
        /// <typeparamref name="T"/> default value.
        /// </returns>
        public static T Deserialize<T>(this object obj)
        {
            if (obj != null && !string.IsNullOrWhiteSpace(obj.ToString()))
                return JsonConvert.DeserializeObject<T>(obj.ToString());
            else
                return default(T);
        }

        /// <summary>
        /// Serializes the specified object to a JSON string.
        /// </summary>
        /// <param name="obj">The object to be serialized.</param>
        /// <returns>
        /// Returns a serialized JSON representation of the object; otherwise string.Empty.
        /// </returns>
        public static string Serialize(this object obj)
        {
            try
            {
                if (obj != null)
                    return JsonConvert.SerializeObject(obj, Formatting.Indented, new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
                else
                    return string.Empty;
            }
            catch (Exception ex)
            {
                var x = ex;
                return string.Empty;
            }
        }
    }
}