using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program;
using Program.Properties;
namespace Essai
{
    class ApplicationConsole
    {
        static void Main(string[] args)
        {
            Projet p;
            Employe e;
            Departement d;
            Participation pa;
            ProgramMain.bdconx = ProgramMain.DataConx();
            int choix;
            int Mchoix;
            Console.WriteLine("Tapez votre choix \n 1-Employer\n2-Departement\n3-Projet\n4-Participation");
            choix = int.Parse(Console.ReadLine());
            Console.Clear();
            while (choix != 0)
            {
                switch(choix)
                {
                    case 1://Employer
                        {
                            Console.WriteLine("Employe !!!\nTapez Votre Choix \n1-Ajouter\n2-Update\n3-Delete\n4-Select*\n99-Precedant");
                            Mchoix = int.Parse(Console.ReadLine());
                            Console.Clear();
                            while(Mchoix!=99)
                            {
                                switch (Mchoix)
                                {
                                    case 1:
                                        {
                                            e = new Employe();
                                            Console.WriteLine("Matr(int) :");
                                            e.Matr = int.Parse(Console.ReadLine());
                                            Console.WriteLine("NomE :");
                                            e.NomE = Console.ReadLine();
                                            Console.WriteLine("Post(string) :");
                                            e.Post=Console.ReadLine();
                                            //Console.WriteLine("DateEmb(string) :");
                                            
                                            e.DateEmb = DateTime.Today;
                                            Console.WriteLine("Sup(int) :");
                                            e.Sup = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Salaire(int) :");
                                            e.Salaire = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Comm(int) :");
                                            e.Comm = int.Parse(Console.ReadLine());
                                            Console.WriteLine("NumDep(int) :");
                                            e.NumDep = int.Parse(Console.ReadLine());
                                            DALEmploye.Insert(e);
                                            Console.WriteLine("Employer !!!\nTapez Votre Choix \n1-Ajouter\n2-Update\n3-Delete\n4-Select*\n99-Precedant");
                                            Mchoix = int.Parse(Console.ReadLine());
                                        }break;
                                    case 2://Update(Employer old ,Employer new)
                                        {
                                            e = new Employe();
                                            int Matr;
                                            Console.WriteLine("OldMatr ? :");
                                            Matr = int.Parse(Console.ReadLine());
                                            e.Matr = Matr;
                                            Console.WriteLine("NomE :");
                                            e.NomE = Console.ReadLine();
                                            Console.WriteLine("Post(string) :");
                                            e.Post = Console.ReadLine();
                                            Console.WriteLine("DateEmb(string) :");
                                            e.DateEmb = DateTime.Parse(Console.ReadLine());
                                            Console.WriteLine("Sup(int) :");
                                            e.Sup = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Salaire(int) :");
                                            e.Salaire = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Comm(int) :");
                                            e.Comm = int.Parse(Console.ReadLine());
                                            Console.WriteLine("NumDep(int) :");
                                            e.NumDep = int.Parse(Console.ReadLine());
                                            
                                            DALEmploye.Update(Matr,e);
                                            Console.WriteLine("Employer !!!\nTapez Votre Choix \n1-Ajouter\n2-Update\n3-Delete\n4-Select*\n99-Precedant");
                                            Mchoix = int.Parse(Console.ReadLine());
                                            
                                        }break;
                                    case 3://Delete(int)
                                        {
                                            Console.WriteLine("Matr ? :");
                                            int Matr;
                                            Matr = int.Parse(Console.ReadLine());
                                            DALEmploye.Delete(Matr);
                                            Console.WriteLine("Employer !!!\nTapez Votre Choix \n1-Ajouter\n2-Update\n3-Delete\n4-Select*\n99-Precedant");
                                            Mchoix = int.Parse(Console.ReadLine());
                                        }break;
                                    case 4://Affiche()
                                        {
                                            DALEmploye.AfficheConsole();
                                            Console.WriteLine("Employer !!!\nTapez Votre Choix \n1-Ajouter\n2-Update\n3-Delete\n4-Select*\n99-Precedant");
                                            Mchoix = int.Parse(Console.ReadLine());
                                        }break;
                                    default: break;
                                }
                            }
                            Console.WriteLine("Tapez votre choix \n 1-Employer\n2-Departement\n3-Projet\n4-Participation");
                            choix = int.Parse(Console.ReadLine());
                
                        } break;
                    case 2://Departement
                        {
                            Console.WriteLine("Departement !!!\nTapez Votre Choix \n1-Ajouter\n2-Update\n3-Delete\n4-Select*\n99-Precedant");
                            Mchoix = int.Parse(Console.ReadLine());
                            while (Mchoix != 99)
                            {
                                switch (Mchoix)
                                {
                                    case 1://Insert(departement)
                                        {
                                            d = new Departement();
                                            Console.WriteLine("NumDep(int) :");
                                            d.NumDep = int.Parse(Console.ReadLine());
                                            Console.WriteLine("NomDep(string) :");
                                            d.NomDep = Console.ReadLine();
                                            Console.WriteLine("Lien(string) :");
                                            d.Lieu = Console.ReadLine();
                                            DALDepartement.Insert(d);
                                            Console.WriteLine("Departement !!!\nTapez Votre Choix \n1-Ajouter\n2-Update\n3-Delete\n4-Select*\n99-Precedant");
                                            Mchoix = int.Parse(Console.ReadLine());
                                        } break;
                                    case 2://Update(int , Departement)
                                        {
                                            d = new Departement();
                                            int NumDep;
                                            Console.WriteLine("NumDep(int) :");
                                            NumDep = int.Parse(Console.ReadLine());
                                            
                                            d.NumDep = NumDep;
                                            Console.WriteLine("NomDep(string) :");
                                            d.NomDep = Console.ReadLine();
                                            Console.WriteLine("Lieu(string) :");
                                            d.Lieu = Console.ReadLine();
                                            
                                            DALDepartement.Update(NumDep, d);
                                            Console.WriteLine("Departement !!!\nTapez Votre Choix \n1-Ajouter\n2-Update\n3-Delete\n4-Select*\n99-Precedant");
                                            Mchoix = int.Parse(Console.ReadLine());
                                        } break;
                                    case 3://Delete(int )
                                        {
                                            Console.WriteLine("NumDep(int) :");
                                            int NumDep;
                                            NumDep = int.Parse(Console.ReadLine());
                                            DALDepartement.Delete(NumDep);
                                            Console.WriteLine("Departement !!!\nTapez Votre Choix \n1-Ajouter\n2-Update\n3-Delete\n4-Select*\n99-Precedant");
                                            Mchoix = int.Parse(Console.ReadLine());
                                        } break;
                                    case 4://Affiche()
                                        {
                                            DALDepartement.AfficheConsole();
                                            Console.WriteLine("Departement !!!\nTapez Votre Choix \n1-Ajouter\n2-Update\n3-Delete\n4-Select*\n99-Precedant");
                                            Mchoix = int.Parse(Console.ReadLine());
                                        } break;
                                    default: break;
                                }
                            }
                            Console.WriteLine("Tapez votre choix \n 1-Employer\n2-Departement\n3-Projet\n4-Participation");
                            choix = int.Parse(Console.ReadLine());
                        }break;
                    case 3://Projet
                        {
                            Console.WriteLine("Projet !!!\nTapez Votre Choix \n1-Ajouter\n2-Update\n3-Delete\n4-Select*\n99-Precedant");
                            Mchoix = int.Parse(Console.ReadLine());
                            while (Mchoix != 99)
                            {
                                switch (Mchoix)
                                {
                                    case 1:
                                        {
                                            p = new Projet();
                                            Console.WriteLine("Pour Insere :\nSaisir le NumProjet :");
                                            p.CodeP = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Bien!\nMaintenant Saisir le NomProjet :");
                                            p.NomP = Console.ReadLine();
                                            DALProjet.Insert(p);
                                            Console.WriteLine("Tapez votre choix \n1:Insere\n2:Update\n3:Delete\n4:affiche tt\n99:Precedant");
                                            Mchoix = int.Parse(Console.ReadLine());
                                        } break;
                                    case 2://update
                                        {
                                            p = new Projet();
                                            Console.WriteLine("Pour Update :\nSaisir OldNumProjet :");
                                            int x = int.Parse(Console.ReadLine());
                                            
                                            p.CodeP = x;
                                            Console.WriteLine("Bien!\nMaintenant Saisir le NomProjet :");
                                            p.NomP = Console.ReadLine();
                                            DALProjet.Update(x, p);
                                            Console.WriteLine("Tapez votre choix \n1:Insere\n2:Update\n3:Delete\n4:Select *\n99:sortie");
                                            Mchoix = int.Parse(Console.ReadLine());
                                        } break;
                                    case 3:
                                        {
                                            
                                            Console.WriteLine("Pour Delete :\nil suffit de Saisir Le NumProjet:");
                                            int x = int.Parse(Console.ReadLine());
                                            DALProjet.Delete(x);
                                            Console.WriteLine("Tapez votre choix \n1:Insere\n2:Update\n3:Delete\n4:Select *\n99:sortie");
                                            Mchoix = int.Parse(Console.ReadLine());
                                        } break;
                                    case 4:
                                        {
                                            DALProjet.Affiche();
                                            Console.WriteLine("\n\nTapez votre choix \n1:Insere\n2:Update\n3:Delete\n4:select *\n99:sortie");
                                            Mchoix = int.Parse(Console.ReadLine());
                                        } break;
                                    default: break;
                                }
                            }
                            Console.WriteLine("Tapez votre choix \n 1-Employer\n2-Departement\n3-Projet\n4-Participation");
                            choix = int.Parse(Console.ReadLine());
                        }break;
                    case 4://Participation
                        {
                            Console.WriteLine("Participation !!!\nTapez Votre Choix \n1-Ajouter\n2-Update\n3-Delete\n4-Select*\n99-Precedant");
                            Mchoix = int.Parse(Console.ReadLine());
                            while (Mchoix != 99)
                            {
                                switch (Mchoix)
                                {
                                    case 1:
                                        {
                                            pa = new Participation();
                                            Console.WriteLine("CodeP(int) : ");
                                            pa.CodeP = int.Parse(Console.ReadLine());                                            
                                            Console.WriteLine("Matr(int) :");
                                            pa.Matr = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Fonction(string) : ");
                                            pa.Fonction = Console.ReadLine();
                                            DALParticipation.Insert(pa);
                                            Console.WriteLine("Participation !!!\nTapez Votre Choix \n1-Ajouter\n2-Update\n3-Delete\n4-Select*\n99-Precedant");
                                            Mchoix = int.Parse(Console.ReadLine());
                                        } break;
                                    case 2:
                                        {
                                            pa = new Participation();
                                            Console.WriteLine("OldMatr(int) :");
                                            int Matr;
                                            Matr = int.Parse(Console.ReadLine());
                                            
                                            Console.WriteLine("CodeP(int) : ");
                                            pa.CodeP = int.Parse(Console.ReadLine());
                                            
                                            pa.Matr = Matr;
                                            Console.WriteLine("Fonction(string) : ");
                                            pa.Fonction = Console.ReadLine();
                                            DALParticipation.Update(Matr, pa);
                                            Console.WriteLine("Participation !!!\nTapez Votre Choix \n1-Ajouter\n2-Update\n3-Delete\n4-Select*\n99-Precedant");
                                            Mchoix = int.Parse(Console.ReadLine());
                                        } break;
                                    case 3:
                                        {
                                            int Matr;
                                            Console.WriteLine("Matr(int) :");
                                            Matr = int.Parse(Console.ReadLine());
                                            DALParticipation.Delete(Matr);
                                            Console.WriteLine("Participation !!!\nTapez Votre Choix \n1-Ajouter\n2-Update\n3-Delete\n4-Select*\n99-Precedant");
                                            Mchoix = int.Parse(Console.ReadLine());
                                        } break;
                                    case 4:
                                        {
                                            DALParticipation.Affiche();
                                            Console.WriteLine("Participation !!!\nTapez Votre Choix \n1-Ajouter\n2-Update\n3-Delete\n4-Select*\n99-Precedant");
                                            Mchoix = int.Parse(Console.ReadLine());
                                        } break;
                                    default: break;
                                }
                            }
                            Console.WriteLine("Tapez votre choix \n 1-Employer\n2-Departement\n3-Projet\n4-Participation");
                            choix = int.Parse(Console.ReadLine());
                        }break;
                    default: break;
                }
            }
        }
    }
}
