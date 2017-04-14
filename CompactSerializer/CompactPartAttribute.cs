using System;

namespace CompactSerializer
{

    [AttributeUsage(AttributeTargets.Property)]
    public class CompactPartAttribute : Attribute
    {
        public CompactPartAttribute(int start, int lenght)
        {
            Start = start;
            Lenght = lenght;
        }

        public int Start { get; set; }
        public int Lenght { get; set; }
    }
    
}