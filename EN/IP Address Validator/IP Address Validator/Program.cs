using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_Address_Validator {
    internal class Program {
        static void Main(string[] args) {
            String ip = "";
            String[] octets = new String[4];
            int dotCounter = 0;
            Boolean octetIsValid = false;

            //User input
            Console.Write("Insira um endereço de IP: ");
            ip = Console.ReadLine();
            //Count how many dots the IP address have
            for (int i = 0; i < ip.Length; i++) {
                if (ip[i] == '.') {
                    dotCounter++;
                }
            }
            //Create the octet array
            octets = ip.Split('.');
            //Check if the IP address have 4 octets
            if (octets.Length == 4) {
                //Check if every octet between 0 and 255
                if ((Convert.ToInt32(octets[0]) >= 0 && Convert.ToInt32(octets[0]) <= 255) &&
                    (Convert.ToInt32(octets[1]) >= 0 && Convert.ToInt32(octets[1]) <= 255) &&
                    (Convert.ToInt32(octets[2]) >= 0 && Convert.ToInt32(octets[2]) <= 255) &&
                    (Convert.ToInt32(octets[3]) >= 0 && Convert.ToInt32(octets[3]) <= 255)) {
                    octetIsValid = true;
                }
                else {
                    Console.WriteLine("INVALID IP: All octets need to have a value between 0 and 255.");
                    octetIsValid = false;
                }
            }
            else {
                Console.WriteLine("INVALID IP: The IP Address need to have 4 octets.");
                octetIsValid = false;
            }
            if (dotCounter == 3 && octetIsValid) {
                Console.WriteLine($"The IP {ip} is a valid address!", ip);
            }
        }
    }
}
