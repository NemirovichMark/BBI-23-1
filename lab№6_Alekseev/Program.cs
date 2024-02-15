using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab_6_Alekseev
{
    public class Participant
    {
        public string Surname { get; set; }
        public string Teacher { get; set; }
        public string Group { get; set; }
        public double Result { get; set; } //Time in sec
        public bool Normative { get; private set; }

        public Participant(string surname, string teacher, string group, double result)
        {
            Surname = surname;
            Teacher = teacher;
            Group = group;
            Result = result;
            CheakNormative();
        }
        private void CheakNormative()
        {
            Normative = Result <= 2 * 60; // Норматив для юноши 1-го курса на оцеку 3 равен 2 минутам
        }
        public static void Main()
        {
   
        }
    }
}
