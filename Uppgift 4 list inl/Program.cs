using System;
using System.Net.Http.Headers;

namespace Uppgift_4_Listor_inl
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] heheheha = new string[]{"hej", "nej", "ja"};
            bool svar = FinnsTecknetIAllaSträngar(heheheha, 'j');
            Console.WriteLine(svar);

            svar = FinnsTecknetIAllaSträngar(heheheha, 'e');
            Console.WriteLine(svar);
        }
        static bool FinnsTecknetIAllaSträngar(string[] args, char tecken)
        {

            foreach (string teststärng in args)
            {
                if (!Finnstäckenisträng(teststärng, tecken))
                {
                    return false;
                }
            }
            return true;

        }
        static bool Finnstäckenisträng(string teststräng, char tecken) 
        {
            foreach (char teckenisträng in teststräng)
            {
                if (teckenisträng == tecken)
                {
                    return true;

                }
            }
            return false;
        }

    }
}