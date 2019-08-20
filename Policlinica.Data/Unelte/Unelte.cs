using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Policlinica.Data
{
    public static class Unelte
    {
        public static byte[] CriptareParola(string parola)
        {
            byte[] parolaCriptata = Encoding.UTF8.GetBytes(parola);

            parolaCriptata = SHA256.Create().ComputeHash(parolaCriptata);
            return parolaCriptata;
        }

        public static Dictionary<int, string> GetEnumValues(Type type)
        {
            Array enumArray = Enum.GetValues(type);
            int key = 1;
            Dictionary<int, string> dictionar = new Dictionary<int, string>();
            foreach (var item in enumArray)
            {
                dictionar.Add(key, item.ToString());
                key++;
            }
            return dictionar;
        }

        public static List<String> GetJudete()
        {
            return new List<String>() { "Alba",
                                        "Arad",
                                        "Arges",
                                        "Bacau",
                                        "Bihor",
                                        "Bistrita Nasaud",
                                        "Botosani",
                                        "Braila",
                                        "Brasov",
                                        "Bucuresti",
                                        "Buzau",
                                        "Calarasi",
                                        "Caras Severin",
                                        "Cluj",
                                        "Constanta",
                                        "Covasna",
                                        "Dambovita",
                                        "Dolj",
                                        "Galati",
                                        "Giurgiu",
                                        "Gorj",
                                        "Harghita",
                                        "Hunedoara",
                                        "Ialomita",
                                        "Iasi",
                                        "Ilfov",
                                        "Maramures",
                                        "Mehedinti",
                                        "Mures",
                                        "Neamt",
                                        "Olt",
                                        "Prahova",
                                        "Salaj",
                                        "Satu Mare",
                                        "Sibiu",
                                        "Suceava",
                                        "Teleorman",
                                        "Timis",
                                        "Tulcea",
                                        "Valcea",
                                        "Vaslui",
                                        "Vrancea" };
        }
    }
}
