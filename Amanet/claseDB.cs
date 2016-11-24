using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amanet
{
    public static class claseDB
    {
        public class ProduseContractAdaugare
        {
            public int idProdus { get; set; }
            public string DenumireProdus { get; set; }
            public int Bucati { get; set; }            
            public decimal GramajPiesa { get; set; }
            public decimal GramajAur { get; set; }
            public decimal ValoareProdus { get; set; }
            public int idCalitate { get; set; }
            public string DenumireCalitate { get; set; }
            public string Descriere { get; set; }
        }

        public class ProduseContractView
        {            
            public string DenumireProdus { get; set; }
            public int Bucati { get; set; }
            public decimal? GramajAur { get; set; }
            public decimal? GramajPiesa { get; set; }            
            public string DenumireCalitate { get; set; }
            public string Descriere { get; set; }
        }

        public class ProduseView
        {
            public int ID { get; set; }
            public string Denumire { get; set; }
            public bool Inactiv { get; set; }
            public int lockVersion { get; set; }
        }

        public class CalitatiView
        {
            public int ID { get; set; }
            public string Denumire { get; set; }
            public bool Inactiv { get; set; }
            public int lockVersion { get; set; }
        }

        public class ClientiView
        {
            public int ID { get; set; }
            public string Nume { get; set; }
            public string Prenume { get; set; }
            public string Domiciliul { get; set; }
            public string CISerie { get; set; }
            public string CINumar { get; set; }
            public string CIEliberatDe { get; set; }
            public Nullable<System.DateTime> CIEliberatLa { get; set; }
            public string Telefon { get; set; }
            public bool Inactiv { get; set; }
            public int lockVersion { get; set; }
        }

        public class ContracteView
        {
            public int idContract { get; set; }
            public int NrContract { get; set; }
            public DateTime DataContract { get; set; }
            public string NumePrenumeClient { get; set; }
            public decimal? ValoareCredit { get; set; }
            public decimal? ValoareDebit { get; set; }
            public DateTime? DataScadenta { get; set; }
            public string Telefon { get; set; }
            public string Observatii { get; set; }
            public string StareContract { get; set; }
            public int? NrZile { get; set; }
            public decimal? ValoareZi { get; set; }
            public decimal? GramajAurTotal { get; set; }
            public decimal? GramajPieseTotal { get; set; }
        }

        public class SituatieScadente
        {
            public int idContract { get; set; }
            public int NrContract { get; set; }            
            public string NumePrenumeClient { get; set; }
            public decimal? ValoareCredit { get; set; }
            public DateTime? DataScadenta { get; set; }
            public string Telefon { get; set; }
            public string Observatii { get; set; }            
        }

        public class InformatiiContractFinalizare
        {
            public int idContract { get; set; }
            public int NrContract { get; set; }
            public DateTime DataContract { get; set; }
            public DateTime? DataScadenta { get; set; }
            public int? NrZile { get; set; }
            public decimal? ValoareCredit { get; set; }
            public decimal? ValoareZi { get; set; }            
        }
   
        public class CbClienti
        {
            public int id { get; set; }
            public string NumePrenume { get; set; }
        }

        public class CbProduse
        {
            public int id { get; set; }
            public string Denumire { get; set; }
        }

        public class CbCalitati
        {
            public int id { get; set; }
            public string Denumire { get; set; }
        }
    }
}
