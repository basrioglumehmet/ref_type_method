using System;

namespace ref_type_method
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "mehmet basrioglu";
            ProgramUtil.ReverseString(ref fullName);
            Console.WriteLine(fullName); // Tersine çevrilmiş string yazdırılır
        }
    }

    class ProgramUtil
    {
        // Stringler birer char dizisidir.
        public static void ReverseString(ref string text) //Referans Tipler
        {
            if (text == null) return;
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            text = new string(array); // Orijinal string ref ile değiştirilir
        }
    }
}
