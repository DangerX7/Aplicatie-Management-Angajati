using System;
using System.Collections.Generic;
using System.Text;

namespace App3
{
    public class Angajati
    {
        public int ID_angajat { get; set; }
        public string Nume { get; set; }
        public string Adresa { get; set; }
        public string Email { get; set; }
        public long Telefon { get; set; }
        public string Rol { get; set; }

        public Angajati()
        {

        }

        public Angajati(int id_angajat, string nume, string adresa, string email, long telefon, string rol)
        {
            ID_angajat = id_angajat;
            Nume = nume;
            Adresa = adresa;
            Email = email;
            Telefon = telefon;
            Rol = rol;
        }

        //Afiseaza toti angajatii
        public void AfiseazaTotiAngajatii()
        {
            Console.WriteLine("\n\t" + ID_angajat + "\t" + Nume + "\t" + Email + "\t" + Telefon + "\t" + Adresa + "\t" + Rol);
        }

        //Adauga nou angajat
        public static List<Angajati> AdaugaAngajat(List<Angajati> angajat, Angajati persoana)
        {
            angajat.Add(persoana);
            return angajat;
        }

    }
}
