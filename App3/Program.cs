using System;
using System.Collections.Generic;
using System.Linq;

namespace App3
{
    class Program
    {
        static void Main(string[] args)
        {

            int alegere = 0;
            int alegere2 = 0;

            //Detalii angajati de baza
            List<Angajati> angajati = new List<Angajati>();
            angajati.Add(new Angajati(1, "Pandele Daniel", "Stelnica", "dangerovidiu@yahoo.com", 7656205308, "Maintenance"));
            angajati.Add(new Angajati(2, "Vasile Sorin", "Branesti", "sorinvasile@gmail.com", 7122345890, "Operator PC"));
            angajati.Add(new Angajati(3, "Tanase Boris", "Pitesti", "tanasebos@gmail.com", 7010204304, "Team Leader"));
            angajati.Add(new Angajati(4, "Creus Filip", "Iasi", "creusman@yahoo.com", 7654352189, "Security"));

            //Salarii de baza
            List<Plata> plati = new List<Plata>();
            plati.Add(new Plata(1, 51, 8, 30, "01/08/2020"));
            plati.Add(new Plata(2, 52, 8, 32, "02/04/2020"));
            plati.Add(new Plata(3, 53, 6, 22, "05/05/2021"));
            plati.Add(new Plata(4, 54, 10, 46, "02/08/2016"));

            //Zile de concediu
            List<Concediu> concedii = new List<Concediu>();
            concedii.Add(new Concediu(1, 51, 12));
            concedii.Add(new Concediu(2, 52, 8));
            concedii.Add(new Concediu(3, 53, 5));
            concedii.Add(new Concediu(4, 54, 10));


        Meniu_Principal:


            Console.WriteLine("\n....................Aplicatie Management Angajati....................\n\n");
            Console.WriteLine("Bine ati venit in Meniul Principal, alegeti o optiune\n");
            Console.WriteLine("Apasati 1 pentru Meniul Angatati");
            Console.WriteLine("Apasati 2 pentru Meniul Plata");
            Console.WriteLine("Apasati 3 pentru Meniul Concediu");
            Console.WriteLine("Apasati 4 pentru a iesi din program");

            Console.Write("\nIntroduceti Optiunea : ");
            string input = Console.ReadLine();

            while (true)
            {
                if (int.TryParse(input, out alegere))
                {
                    if (alegere.Equals(1))
                    {
                        Console.WriteLine("1");
                        Console.Clear();
                        Console.WriteLine("\n....................Aplicatie Management Angajati....................\n\n");
                        Console.WriteLine("Bine Ati Venit in Meniul Angajati, Alegeti o Optiune\n");
                        Console.WriteLine("Apasati pe 1 pentru afisarea tuturor angajatilor");
                        Console.WriteLine("Apasati pe 2 pentru adaugarea unui angajat nou");
                        Console.WriteLine("Apasati pe 3 pentru actualizarea angajatilor");
                        Console.WriteLine("Apasati pe 4 pentru stergerea angajatului");
                        Console.WriteLine("Apasati pe 5 pentru a va reintoarce in meniul principal");

                        Console.Write("\nIntroduceti Optiunea : ");
                        string input2 = Console.ReadLine();

                        while (true)
                        {
                            if (int.TryParse(input2, out alegere2))
                            {
                                if (alegere2.Equals(1))
                                {
                                    Console.WriteLine("\t\t\t------Detalii Angajat------");
                                    Console.WriteLine("\n\tID \t Nume \t\t Email \t\tTelefon \t Adresa \t Rol");

                                    angajati.ForEach(p => p.AfiseazaTotiAngajatii());

                                    Console.Write("\nIntroduceti Optiunea : ");
                                    input2 = Console.ReadLine();
                                }
                                else if (alegere2.Equals(2))
                                {
                                    Console.WriteLine("\n\t\t\t-------Adauga Angajat------");

                                    Angajati persoana = new Angajati();
                                    Console.Write("Introduceti ID Angajat : ");
                                    int id_persoana = Convert.ToInt32(Console.ReadLine());
                                    var info_angajat = angajati.Where(e => e.ID_angajat == id_persoana).FirstOrDefault();

                                    if (info_angajat == null)
                                    {
                                        info_angajat = persoana;
                                        info_angajat.ID_angajat = 0;
                                    }

                                    if (id_persoana != null)
                                    {
                                        if (info_angajat.ID_angajat != id_persoana || info_angajat.ID_angajat == null)
                                        {
                                            persoana.ID_angajat = id_persoana;
                                            Console.Write("Introduceti Nume : ");
                                            persoana.Nume = Console.ReadLine();
                                            Console.Write("Introduceti Email : ");
                                            persoana.Email = Console.ReadLine();
                                            Console.Write("Introduceti Adresa : ");
                                            persoana.Adresa = Console.ReadLine();
                                            Console.Write("Introduceti Telefon : ");
                                            persoana.Telefon = Convert.ToInt64(Console.ReadLine());
                                            Console.Write("Introduceti Rol : ");
                                            persoana.Rol = Console.ReadLine();

                                            angajati.Where(e => e.ID_angajat == persoana.ID_angajat);
                                            angajati.Where(e => e.Nume == persoana.Nume);
                                            angajati.Where(e => e.Email == persoana.Email);
                                            angajati.Where(e => e.Adresa == persoana.Adresa);
                                            angajati.Where(e => e.Telefon == persoana.Telefon);
                                            angajati.Where(e => e.Rol == persoana.Rol);
                                            angajati.Add(persoana);

                                            Console.WriteLine("\n\tAngajatul cu ID: " + id_persoana + " a fost adaugat cu succes");
                                        }
                                        else
                                        {
                                            Console.WriteLine("\n\tAngajatul " + info_angajat.ID_angajat + " deja exista, alege alta optiune");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Angajatul cu ID: " + id_persoana + " nu exista");
                                    }

                                    Console.WriteLine("\nIntroduceti Optiunea : ");
                                    input2 = Console.ReadLine();

                                }
                                else if (alegere2.Equals(3))
                                {
                                    Console.Write("Introduceti ID angajat pentru actualizarea profilului : ");
                                    int id_persoana = Convert.ToInt32(Console.ReadLine());
                                    Angajati persoana = new Angajati();

                                    var info_angajat = angajati.Where(e => e.ID_angajat == id_persoana).FirstOrDefault();
                                    if (info_angajat != null)
                                    {
                                        persoana.ID_angajat = id_persoana;
                                        Console.Write("Introduceti Nume : ");
                                        persoana.Nume = Console.ReadLine();
                                        Console.Write("Introduceti Email : ");
                                        persoana.Email = Console.ReadLine();
                                        Console.Write("Introduceti Adresa : ");
                                        persoana.Adresa = Console.ReadLine();
                                        Console.Write("Introduceti Telefon : ");
                                        persoana.Telefon = Convert.ToInt64(Console.ReadLine());
                                        Console.Write("Introduceti Rol : ");
                                        persoana.Rol = Console.ReadLine();

                                        angajati.Where(e => e.ID_angajat == id_persoana).FirstOrDefault().ID_angajat = persoana.ID_angajat;
                                        angajati.Where(e => e.ID_angajat == id_persoana).FirstOrDefault().Nume = persoana.Nume;
                                        angajati.Where(e => e.ID_angajat == id_persoana).FirstOrDefault().Email = persoana.Email;
                                        angajati.Where(e => e.ID_angajat == id_persoana).FirstOrDefault().Adresa = persoana.Adresa;
                                        angajati.Where(e => e.ID_angajat == id_persoana).FirstOrDefault().Telefon = persoana.Telefon;
                                        angajati.Where(e => e.ID_angajat == id_persoana).FirstOrDefault().Rol = persoana.Rol;

                                        Console.WriteLine("\n\tAngajatul cu ID : " + id_persoana + " a fost actualizat cu succes");

                                    }
                                    else
                                    {
                                        Console.WriteLine("\n\tAngajatul cu ID : " + id_persoana + " nu exista");
                                    }

                                    Console.Write("\nOptiunea : ");
                                    input2 = Console.ReadLine();
                                }
                                else if (alegere2.Equals(4))
                                {
                                    Console.Write("\n\tIntroduceti ID angajat pentru stergere : ");
                                    int id_persoana = Convert.ToInt32(Console.ReadLine());
                                    angajati.RemoveAll(e => e.ID_angajat == id_persoana);

                                    Console.Write("\nIntroduceti Optiunea : ");
                                    input2 = Console.ReadLine();
                                }
                                else if (alegere2.Equals(5))
                                {
                                    Console.Clear();
                                    goto Meniu_Principal;
                                }
                                else
                                {
                                    Console.WriteLine("Alegere invalida, Try Incearca din nou");
                                    Console.Write("\nIntroduceti Optiune : ");
                                    input2 = Console.ReadLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Alegere invalida, Try Incearca din nou");
                                Console.Write("\nIntroduceti Optiune : ");
                                input2 = Console.ReadLine();
                            }
                        }






                    }
                    else if (alegere.Equals(2))
                    {
                        Console.WriteLine("2");
                        Console.Clear();
                        Console.WriteLine("\n.................Aplicatie Management Angajati.................\n\n");
                        Console.WriteLine("Bine ati venit in Meniul Plata, Alegeti o Optiune\n");
                        Console.WriteLine("Apasati 1 pentru introducerea unei noi plati");
                        Console.WriteLine("Apasati 2 pentru afisarea intoricul platilor unui angajat");
                        Console.WriteLine("Apasati 3 pentru a va intoarce la Meniul Principal");

                        Console.Write("\nIntroduceti Optiune : ");
                        string input2 = Console.ReadLine();

                        while (true)
                        {
                            if (int.TryParse(input2, out alegere2))
                            {
                                if (alegere2.Equals(1))
                                {
                                    Plata plata = new Plata();
                                    Console.Write("Introduceti ID plata : ");
                                    int id_plata = Convert.ToInt32(Console.ReadLine());
                                    var info_plata = plati.Where(e => e.idPlata == id_plata).FirstOrDefault();

                                    if (info_plata == null)
                                    {
                                        info_plata = plata;
                                        info_plata.idPlata = 0;
                                    }

                                    if (id_plata != null)
                                    {
                                        if (info_plata.idAngajat != id_plata || info_plata.idAngajat == null)
                                        {
                                            plata.idPlata = id_plata;
                                            Console.Write("Introduceti ID angajat : ");
                                            plata.idAngajat = Convert.ToInt32(Console.ReadLine());
                                            Console.Write("Introduceti ore lucrate : ");
                                            plata.oreLucrateZilnic = Convert.ToDouble(Console.ReadLine());
                                            Console.Write("Introduceti plata pe ora : ");
                                            plata.plataPeOra = Convert.ToDouble(Console.ReadLine());
                                            Console.Write("Introduceti data : ");
                                            plata.data = Console.ReadLine();

                                            plati.Where(e => e.idPlata == plata.idPlata);
                                            plati.Where(e => e.idAngajat == plata.idAngajat);
                                            plati.Where(e => e.oreLucrateZilnic == plata.oreLucrateZilnic);
                                            plati.Where(e => e.plataPeOra == plata.plataPeOra);
                                            plati.Where(e => e.data == plata.data);

                                            plati.Add(plata);
                                            Console.WriteLine("\n\tAngajatul cu id : " + id_plata + " adaugat cu succes");
                                        }
                                        else
                                        {
                                            Console.WriteLine("\n\tAngajatul " + id_plata + " deja exista, alege alta optiune");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Angajatul cu ID " + id_plata + " nu exista");
                                    }


                                    Console.Write("\nIntroduceti Optiunea : ");
                                    input2 = Console.ReadLine();
                                }
                                else if (alegere2.Equals(2))
                                {
                                    Console.WriteLine("\n \t\t\t\t--------Detali Plata----------");
                                    Console.WriteLine("\n\t\tID plata \t\tID angajat\t\tOre pe zi\tPlata pe ora\tData \t");
                                    plati.ForEach(p => p.VizioneazaIstoric());

                                    Console.Write("\nIntroduceti Optiunea : ");
                                    input2 = Console.ReadLine();
                                }
                                else if (alegere2.Equals(3))
                                {
                                    Console.Clear();
                                    goto Meniu_Principal;
                                }
                                else
                                {
                                    Console.WriteLine("Alegere invalida, incearca din nou");
                                    Console.Write("\nIntroduceti Optiunea : ");
                                    input2 = Console.ReadLine();
                                }

                            }
                            else
                            {
                                Console.WriteLine("Alegere invalida, incearca din nou");
                                Console.Write("\nIntroduceti Optiunea : ");
                                input2 = Console.ReadLine();
                            }
                        }

                    }
                    else if(alegere.Equals(3))
                    {
                        Console.WriteLine("3");
                        Console.Clear();
                        Console.WriteLine("\n.................Aplicatie Management Angajati.................\n\n");
                        Console.WriteLine("Bine ati venit in Meniul de Concediu, Alegeti o Optiune\n");
                        Console.WriteLine("Apasati pe 1 pentru afisarea zilelor de concediu");
                        Console.WriteLine("Apasati pe 2 pentru a adauga zile de concediu");
                        Console.WriteLine("Apasati pe 3 pentru a te intoarce la meniul principal");


                        Console.Write("\nIntroduceti Optiunea : ");
                        string input2 = Console.ReadLine();

                        while (true)
                        {
                            if (int.TryParse(input2, out alegere2))
                            {
                                if (alegere2.Equals(1))
                                {
                                    Console.WriteLine("\n\n\t\t --------Detali Concediu--------");
                                    Console.WriteLine("\n\t\tID concediu \t\tID angajat\t\tNumar zile\t\t");
                                    concedii.ForEach(p => p.AfiseazaZileConcediu());

                                    Console.Write("\nIntroduceti Optiunea : ");
                                    input2 = Console.ReadLine();
                                }
                                else if (alegere2.Equals(2))
                                {
                                    Concediu concediu = new Concediu();
                                    Console.Write("\nIntroduceti ID concediu : ");
                                    int id_concediu = Convert.ToInt32(Console.ReadLine());
                                    var info_concediu = concedii.Where(e => e.ID_concediu == id_concediu).FirstOrDefault();

                                    if (info_concediu == null)
                                    {
                                        info_concediu = concediu;
                                        info_concediu.ID_concediu = 0;
                                    }

                                    if (id_concediu != null)
                                    {
                                        if (info_concediu.ID_concediu != id_concediu || info_concediu.ID_concediu == null)
                                        {
                                            concediu.ID_concediu = id_concediu;
                                            Console.Write("Introduceti ID angajat : ");
                                            concediu.ID_angajat = Convert.ToInt32(Console.ReadLine());
                                            Console.Write("Introduceti numar de zile : ");
                                            concediu.numarDeZile = Convert.ToInt32(Console.ReadLine());

                                            concedii.Where(e => e.ID_concediu == concediu.ID_concediu);
                                            concedii.Where(e => e.ID_angajat == concediu.ID_angajat);
                                            concedii.Where(e => e.numarDeZile == concediu.numarDeZile);

                                            concedii.Add(concediu);

                                            Console.WriteLine("\n\t Concediul cu ID : " + id_concediu + " a fost adaugat cu succes");
                                        }
                                        else
                                        {
                                            Console.WriteLine("\n\t Concediul cu ID : " + id_concediu + " deja exista, alege din nou alta optiune");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Concediul cu ID : " + id_concediu + " nu exista");
                                    }
                                    Console.Write("\nIntroduceti Optiunea : ");
                                    input2 = Console.ReadLine();
                                }
                                else if (alegere2.Equals(3))
                                {
                                    Console.Clear();
                                    goto Meniu_Principal;
                                }
                                else
                                {
                                    Console.WriteLine("Alegere invalida, incearca din nou");
                                    Console.Write("\nIntroduceti Optiunea : ");
                                    input2 = Console.ReadLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Alegere invalida, incearca din nou");
                                Console.Write("\nIntroduceti Optiunea : ");
                                input2 = Console.ReadLine();
                            }
                        }
                    }
                    else if (alegere.Equals(4))
                    {
                        Console.WriteLine("4");
                        Console.Clear();
                        System.Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Alegere invalida, incearca din nou");
                        Console.Write("\nIntroduceti Optiunea : ");
                        input = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Alegere invalida, incearca din nou");
                    Console.Write("\nIntroduceti Optiunea : ");
                    input = Console.ReadLine();
                }
            }
        }
    }
}
