using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amanet
{
    class functiiDB
    {       
        public static List<Produse> listaProduse = new List<Produse>();

        public static List<claseDB.CbProduse> listaCbProduse = new List<claseDB.CbProduse>();
        public static List<claseDB.CbClienti> listaCbClienti = new List<claseDB.CbClienti>();
        public static List<claseDB.CbCalitati> listaCbCalitati = new List<claseDB.CbCalitati>();

        public static void Initializare()
        {
            var setari = File.ReadLines("setari.txt");
            foreach(string setare in setari)
            {
                if (setare.StartsWith("instanta")) global.instanta = setare.Substring(9);
                if (setare.StartsWith("db")) global.db = setare.Substring(3);
                if (setare.StartsWith("user")) global.user = setare.Substring(5);
                if (setare.StartsWith("pass")) global.pass = setare.Substring(5);
            }

            global.conString = @"metadata=res://*/AmanetModel.csdl|res://*/AmanetModel.ssdl|res://*/AmanetModel.msl;provider=System.Data.SqlClient;provider connection string=""data source="+global.instanta+@";initial catalog="+global.db+@";user id="+global.user+@";password="+global.pass+@";MultipleActiveResultSets=True;App=EntityFramework""";
        }

        #region nomenclator contracte

        public static void PopuleazaListaCbProduse()
        {
            listaCbProduse.Clear();
            using (var context = new AmanetEntities(global.conString))
            {
                listaCbProduse = context.Produses.Select(p => new claseDB.CbProduse { id = p.id, Denumire = p.denumire }).OrderBy(p=>p.Denumire).ToList();
            }
        }
        
        public static void PopuleazaListaCbClienti()
        {
            listaCbClienti.Clear();
            using (var context = new AmanetEntities(global.conString))
            {
                listaCbClienti = context.Clientis.Select(c => new claseDB.CbClienti { id = c.id, NumePrenume = c.nume +  " " + c.prenume }).OrderBy(c => c.NumePrenume).ToList();
            }
        }

        public static void PopuleazaListaCbCalitati()
        {
            listaCbCalitati.Clear();
            using (var context = new AmanetEntities(global.conString))
            {
                listaCbCalitati = context.Calitatis.Select(c => new claseDB.CbCalitati { id = c.id, Denumire = c.denumire }).OrderBy(c => c.Denumire).ToList();
            }
        }

        public static List<claseDB.ProduseContractView> PopuleazaProduseContractView(int _idContract)
        {
            using (var context = new AmanetEntities(global.conString))
            {
                return (from c in context.ContracteProduses
                        join p in context.Produses on c.idProdus equals p.id
                        where c.idContract == _idContract
                        select new claseDB.ProduseContractView
                        {
                            DenumireProdus = p.denumire,
                            Bucati = c.bucati,
                            GramajPiesa = c.gramajPiesa,
                            GramajAur = c.gramajAur,
                            DenumireCalitate = c.Calitati.denumire,
                            Descriere = c.descriere
                        }).OrderBy(pc=>pc.DenumireProdus).ToList();
            }
        }

        public static List<claseDB.ContracteView> PopuleazaContracteView(DateTime _scadenta, string _stare = "Toate", string _numePrenume = "")
        {
            using (var context = new AmanetEntities(global.conString))
            {
                if (_stare != "Toate")
                {
                    //nume prenume, scadenta si stare contracte
                    
                    return (from c in context.ContracteAntets
                            where (c.Clienti.nume + " " + c.Clienti.prenume).ToLower().StartsWith(_numePrenume) &&
                            c.stareContract == _stare &&
                            c.dataScadenta < _scadenta
                            join cp in context.ContracteProduses on c.id equals cp.idContract into c_cp
                            from cc in c_cp.DefaultIfEmpty()
                            group cc by c into cGrupat
                            from ccc in cGrupat
                            select new claseDB.ContracteView
                            {
                                idContract = cGrupat.Key.id,
                                NrContract = cGrupat.Key.nrContract,
                                DataContract = cGrupat.Key.dataContract,
                                NumePrenumeClient = cGrupat.Key.Clienti.nume + " " + cGrupat.Key.Clienti.prenume,
                                ValoareCredit = cGrupat.Key.valoareCredit,
                                ValoareDebit = cGrupat.Key.valoareDebit,
                                DataScadenta = cGrupat.Key.dataScadenta,
                                Telefon = cGrupat.Key.Clienti.telefon,
                                StareContract = cGrupat.Key.stareContract,
                                ValoareZi = cGrupat.Key.valoareCreditZi,
                                NrZile = cGrupat.Key.nrZile,
                                Observatii = cGrupat.Key.observatii,
                                GramajAurTotal = cGrupat.Sum(cProd=>cProd.gramajAur),
                                GramajPieseTotal = cGrupat.Sum(cProd => cProd.gramajPiesa)                                
                            }).Distinct().OrderBy(ca => ca.NrContract).ToList();
                }
                else
                {
                    //nume prenume si scadenta
                    return (from c in context.ContracteAntets
                            where (c.Clienti.nume + " " + c.Clienti.prenume).ToLower().StartsWith(_numePrenume) &&
                            c.dataScadenta < _scadenta
                            join cp in context.ContracteProduses on c.id equals cp.idContract into c_cp
                            from cc in c_cp.DefaultIfEmpty()
                            group cc by c into cGrupat
                            from ccc in cGrupat
                            select new claseDB.ContracteView
                            {
                                idContract = cGrupat.Key.id,
                                NrContract = cGrupat.Key.nrContract,
                                DataContract = cGrupat.Key.dataContract,
                                NumePrenumeClient = cGrupat.Key.Clienti.nume + " " + cGrupat.Key.Clienti.prenume,
                                ValoareCredit = cGrupat.Key.valoareCredit,
                                ValoareDebit = cGrupat.Key.valoareDebit,
                                DataScadenta = cGrupat.Key.dataScadenta,
                                Telefon = cGrupat.Key.Clienti.telefon,
                                StareContract = cGrupat.Key.stareContract,
                                ValoareZi = cGrupat.Key.valoareCreditZi,
                                NrZile = cGrupat.Key.nrZile,
                                Observatii = cGrupat.Key.observatii,
                                GramajAurTotal = cGrupat.Sum(cProd=>cProd.gramajAur),
                                GramajPieseTotal = cGrupat.Sum(cProd => cProd.gramajPiesa)
                            }).Distinct().OrderBy(ca => ca.NrContract).ToList();
                }
            }
        }

        /// <summary>
        /// Functia returneaza o lista a contractelor active cu scadenta anterioara celei din parametru.
        /// </summary>
        /// <param name="_scadenta"></param>
        /// <returns></returns>
        public static List<claseDB.SituatieScadente> ReturneazaSituatieScadente(DateTime _scadenta)
        {
            using (var context = new AmanetEntities(global.conString))
            {
                return (from c in context.ContracteAntets
                        where c.dataScadenta < _scadenta &&
                        c.stareContract == global.StareContracte.ACTIV.ToString()
                        select new claseDB.SituatieScadente
                        {
                            idContract = c.id,
                            NrContract = c.nrContract,
                            NumePrenumeClient = c.Clienti.nume + " " + c.Clienti.prenume,
                            ValoareCredit = c.valoareCredit,
                            DataScadenta = c.dataScadenta,
                            Telefon = c.Clienti.telefon,                            
                            Observatii = c.observatii
                        }).OrderBy(ca => ca.NrContract).ToList();
            }
        }

        /// <summary>
        /// Functia retuneaza numarul de contract nou care ar trebui sa urmeze
        /// </summary>
        /// <returns></returns>
        public static int GenereazaNumarContract()
        {
            using (var context = new AmanetEntities(global.conString))
            {
                if (context.ContracteAntets.Any())
                {
                    int ultimulNrContract = context.ContracteAntets.Max(c => c.nrContract);
                    return ultimulNrContract + 1;
                }                
            }
            return 1;
        }

        /// <summary>
        /// Functia returneaza false daca contractul reprezentat de datele din parametru exista deja in DB
        /// </summary>
        /// <param name="_nrCon"></param>
        /// <param name="_dataCon"></param>
        /// <param name="_idClient"></param>
        /// <returns></returns>
        public static bool VerificaUnicitateContract(int _nrCon, DateTime _dataCon, int _idClient)
        {
            using (var context = new AmanetEntities(global.conString))
            {
                if (context.ContracteAntets.Any(con => con.nrContract == _nrCon && con.dataContract == _dataCon && con.idClient == _idClient))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool SalveazaContract(ContracteAntet _contractAntet, List<claseDB.ProduseContractAdaugare> _listaProduseContract)
        {
            using (var context = new AmanetEntities(global.conString))
            {
                var tranzactie = context.Database.BeginTransaction();
                try
                {
                    context.ContracteAntets.Add(_contractAntet);
                    context.SaveChanges();
                    context.ContracteProduses.AddRange(_listaProduseContract
                        .Select(p => new ContracteProduse
                        {
                            creatLa = DateTime.Now,
                            gramajAur = p.GramajAur,
                            gramajPiesa = p.GramajPiesa,
                            descriere = p.Descriere,
                            bucati = p.Bucati,
                            idCalitate = p.idCalitate,
                            idContract = _contractAntet.id,
                            idProdus = p.idProdus,
                            inactiv = false,
                            lockVersion = 0,
                            modificatLa = DateTime.Now
                        }));
                    context.SaveChanges();

                    tranzactie.Commit();
                    return true;
                }
                catch
                {
                    tranzactie.Rollback();
                    return false;
                }
            }
        }

        /// <summary>
        /// Procedura genereaza informatiile necesare printarii raportului cu id-ul din parametru.
        /// </summary>
        /// <param name="_idContract"></param>
        public static lstPrintareContract GenereazaContractDePrintat(int _idContract)
        {
            using (var context = new AmanetEntities(global.conString))
            {
                context.PROC_RptPrintareContract(_idContract);
                return context.lstPrintareContracts.FirstOrDefault();
            }
        }
        
        #endregion

        #region nomenclator produse
        public static Produse ReturneazaProdusDupaId(int _idProdus)
        {
            using (var context = new AmanetEntities(global.conString))
            {
                return context.Produses.FirstOrDefault(prod => prod.id == _idProdus);
            }
        }

        public static List<claseDB.ProduseView> ReturneazaListaProduse()
        {
            using (var context = new AmanetEntities(global.conString))
            {
                return context.Produses.Select(p => new claseDB.ProduseView()
                {
                    ID = p.id,
                    Denumire = p.denumire,
                    Inactiv = p.inactiv,
                    lockVersion = p.lockVersion
                }).OrderBy(p => p.Denumire).ToList();
            }
        }
        
        /// <summary>
        /// Functia returneaza false daca denumirea de produs din parametru exista deja in DB
        /// </summary>
        /// <param name="_denumireProdus"></param>
        /// /// <param name="_modifica"></param>
        /// <returns></returns>
        public static bool VerificaUnicitateProdus(string _denumireProdus)
        {
            using (var context = new AmanetEntities(global.conString))
            {
                if(context.Produses.Any(p=>p.denumire.ToLower() == _denumireProdus.ToLower()))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool SalveazaProdusNou(Produse _produs)
        {
            using (var context = new AmanetEntities(global.conString))
            {
                context.Produses.Add(_produs);
                context.SaveChanges();
                return true;
            }
        }

        public static bool SalveazaProdusExistent(int _idProdus, Produse _produsDeModificat)
        {
            using (var context = new AmanetEntities(global.conString))
            {
                Produse produsModif = context.Produses.Where(p => p.id == _idProdus).FirstOrDefault();
                if (produsModif != null)
                {
                    produsModif.denumire = _produsDeModificat.denumire;
                    produsModif.lockVersion = _produsDeModificat.lockVersion;
                    produsModif.modificatLa = _produsDeModificat.modificatLa;
                    context.SaveChanges();
                    return true;
                }
                return false;                
            }
        }
        #endregion

        #region nomenclator calitati
        public static Calitati ReturneazaCalitateDupaId(int _idCalitate)
        {
            using (var context = new AmanetEntities(global.conString))
            {
                return context.Calitatis.FirstOrDefault(calit => calit.id == _idCalitate);
            }
        }

        public static List<claseDB.CalitatiView> ReturneazaListaCalitati()
        {
            using (var context = new AmanetEntities(global.conString))
            {
                return context.Calitatis.Select(calit => new claseDB.CalitatiView()
                {
                    ID = calit.id,
                    Denumire = calit.denumire,
                    Inactiv = calit.inactiv,
                    lockVersion = calit.lockVersion
                }).OrderBy(c => c.Denumire).ToList();                        
            }
        }

        /// <summary>
        /// Functia returneaza false daca denumirea de calitate din parametru exista deja in DB
        /// </summary>
        /// <param name="_denumireCalitate"></param>
        /// <returns></returns>
        public static bool VerificaUnicitateCalitate(string _denumireCalitate)
        {
            using (var context = new AmanetEntities(global.conString))
            {
                if (context.Calitatis.Any(c => c.denumire.ToLower() == _denumireCalitate.ToLower()))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool SalveazaCalitateNoua(Calitati _calitate)
        {
            using (var context = new AmanetEntities(global.conString))
            {
                context.Calitatis.Add(_calitate);
                context.SaveChanges();
                return true;
            }
        }

        public static bool SalveazaCalitateExistenta(int _idCalitate, Calitati _calitateDeModificat)
        {
            using (var context = new AmanetEntities(global.conString))
            {
                Calitati calitateModif = context.Calitatis.Where(c => c.id == _idCalitate).FirstOrDefault();
                if (calitateModif != null)
                {
                    calitateModif.denumire = _calitateDeModificat.denumire;
                    calitateModif.lockVersion = _calitateDeModificat.lockVersion;
                    calitateModif.modificatLa = _calitateDeModificat.modificatLa;
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
        }
        #endregion
        
        #region nomenclator clienti
        public static Clienti ReturneazaClientDupaId(int _idClient)
        {
            using (var context = new AmanetEntities(global.conString))
            {
                return context.Clientis.FirstOrDefault(cli=>cli.id == _idClient);
            }
        }

        public static List<claseDB.ClientiView> ReturneazaListaClienti()
        {
            using (var context = new AmanetEntities(global.conString))
            {
                return context.Clientis.Select(cli => new claseDB.ClientiView()
                {
                    ID = cli.id,
                    CIEliberatDe = cli.ciEliberatDe,
                    CIEliberatLa = cli.ciEliberatLa,
                    CINumar = cli.ciNumar,
                    CISerie = cli.ciSerie,
                    Domiciliul = cli.domiciliul,
                    Inactiv = cli.inactiv,
                    lockVersion = cli.lockVersion,
                    Nume = cli.nume,
                    Prenume = cli.prenume,
                    Telefon = cli.telefon
                }).OrderBy(c => c.Nume + " " + c.Prenume).ToList();
            }
        }

        /// <summary>
        /// Functia returneaza false daca clientul reprezentat de datele din parametru exista deja in DB
        /// </summary>
        /// <param name="_numeCli"></param>
        /// <param name="_denCli"></param>
        /// <param name="_serieCli"></param>
        /// <param name="_numarCli"></param>
        /// <returns></returns>
        public static bool VerificaUnicitateClient(string _numeCli, string _prenumeCli, string _serieCli, string _numarCli)
        {
            using (var context = new AmanetEntities(global.conString))
            {
                if (context.Clientis.Any(cli => cli.nume.ToLower() == _numeCli.ToLower() && cli.prenume.ToLower() == _prenumeCli.ToLower() && cli.ciSerie.ToLower() == _serieCli.ToLower() && cli.ciNumar.ToLower() == _numarCli.ToLower()))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool SalveazaClientNou(Clienti _client)
        {
            using (var context = new AmanetEntities(global.conString))
            {
                context.Clientis.Add(_client);
                context.SaveChanges();
                return true;
            }
        }

        public static bool SalveazaClientExistent(int _idClient, Clienti _clientDeModificat)
        {
            using (var context = new AmanetEntities(global.conString))
            {
                Clienti clientModif = context.Clientis.Where(cli => cli.id == _idClient).FirstOrDefault();
                if (clientModif != null)
                {
                    clientModif.ciEliberatDe = _clientDeModificat.ciEliberatDe;
                    clientModif.ciEliberatLa = _clientDeModificat.ciEliberatLa;
                    clientModif.ciNumar = _clientDeModificat.ciNumar;
                    clientModif.ciSerie = _clientDeModificat.ciSerie;
                    clientModif.domiciliul = _clientDeModificat.domiciliul;
                    clientModif.lockVersion = _clientDeModificat.lockVersion;
                    clientModif.modificatLa = _clientDeModificat.modificatLa;
                    clientModif.nume = _clientDeModificat.nume;
                    clientModif.prenume = _clientDeModificat.prenume;
                    clientModif.telefon = _clientDeModificat.telefon;
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
        }
        #endregion
        
        #region finalizare contract
        /// <summary>
        /// Functia returneaza informatiile necesare pentru finalizarea contractului cu id-ul din parametru.
        /// Se returneaza un obiect de tipul claseDB.InformatiiContractFinalizare
        /// </summary>
        /// <param name="_idContract"></param>
        /// <returns></returns>
        public static claseDB.InformatiiContractFinalizare ContractInfo(int _idContract)
        {
            using (var context = new AmanetEntities(global.conString))
            {
                return context.ContracteAntets
                    .Where(ca => ca.id == _idContract)
                    .Select(ca => new claseDB.InformatiiContractFinalizare
                    {
                        idContract = ca.id,
                        NrContract = ca.nrContract,
                        DataContract = ca.dataContract,
                        DataScadenta = ca.dataScadenta,
                        NrZile = ca.nrZile,
                        ValoareCredit = ca.valoareCredit,
                        ValoareZi = ca.valoareCreditZi
                    })
                    .FirstOrDefault();
            }
        }

        /// <summary>
        /// Functia returneaza true daca finalizarea/neachitarea contractului s-a realizat cu succes. Altfel returneaza false.
        /// </summary>
        /// <param name="_idContract"></param>
        /// <param name="_stare"></param>
        /// <returns></returns>
        public static bool InchideContract(int _idContract, global.StareContracte _stare)
        {
            using (var context = new AmanetEntities(global.conString))
            {
                var contractDeFinalizat = context.ContracteAntets.Where(ca => ca.id == _idContract).FirstOrDefault();
                if(contractDeFinalizat != null)
                {
                    contractDeFinalizat.stareContract = _stare.ToString();
                    context.SaveChanges();
                    return true;
                }
            }
            return false;
        }
        #endregion
        
    }
}
