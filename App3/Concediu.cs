using System;
using System.Collections.Generic;
using System.Text;

namespace App3
{
    public class Concediu
    {
        public int ID_concediu { get; set; }
        public int ID_angajat { get; set; }
        public int numarDeZile { get; set; }

        public Concediu()
        {

        }

        public Concediu(int id_Concediu, int id_Angajat, int numarDeZile)
        {
            ID_concediu = id_Concediu;
            ID_angajat = id_Angajat;
            this.numarDeZile = numarDeZile;
        }

        //Afiseaza zile de concediu
        public void AfiseazaZileConcediu()
        {
            Console.WriteLine("\n\t\t" + ID_concediu + "\t\t" + ID_angajat + "\t\t" + numarDeZile);
        }
    }
}
