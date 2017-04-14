using System;
using System.Reflection;

namespace CompactSerializer
{

    [AttributeUsage(AttributeTargets.Class)]
    public class KnownChildAttribute : Attribute
    {
        public KnownChildAttribute(Type type)
        {
            if (type.GetCustomAttribute<CompactSerializableAttribute>() == null)
                throw new InvalidOperationException("BsKnownTypes should have BsSerializable atttribute on them.");
            Type = type;
        }

        public Type Type { get; set; }
    }
    
}