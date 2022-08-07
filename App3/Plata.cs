using System;
using System.Collections.Generic;
using System.Text;

namespace App3
{
    public class Plata
    {
        public int idPlata { get; set; }
        public int idAngajat { get; set; }
        public double oreLucrateZilnic { get; set; }
        public double plataPeOra { get; set; }
        public string data { get; set; }

        public Plata()
        {

        }

        public Plata(int idPlata, int idAngajat, double oreLucrateZilnic, double plataPeOra, string data)
        {
            this.idPlata = idPlata;
            this.idAngajat = idAngajat;
            this.oreLucrateZilnic = oreLucrateZilnic;
            this.plataPeOra = plataPeOra;
            this.data = data;
        }

        //Adauga plata noua
        public static List<Plata> AdaugaPlataNoua(List<Plata> salariu, Plata plata)
        {
            salariu.Add(plata);
            return salariu;
        }

        //Vizioneaza istoric plata angajati
        public void VizioneazaIstoric()
        {
            Console.WriteLine("\n\t\t" + idPlata + "\t\t" + idAngajat + "\t\t" + oreLucrateZilnic + "\t\t" + plataPeOra + "\t\t" + data);
        }
    }
}
