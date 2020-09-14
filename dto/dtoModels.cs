using System;

namespace MassBalans.dto
{
    public class clientDto
    {
        public int code { get; set; }
        public string name { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string zipCode { get; set; }
        public string street { get; set; }
        public bool contract { get; set; }
        public string certVerto { get; set; }
    }

    public class outputDto
    {
        public int id { get; set; }
        public int buyer { get; set; }
        public int quantity { get; set; }
        public DateTime date { get; set; }
    }

    public class inputDto
    {
        public int code { get; set; }
        public int supplier { get; set; }
        public int resource { get; set; }
        public bool conversion { get; set; }
        public int quantity { get; set; }
        public int trucksneed { get; set; }
        public int truckFull { get; set; }
        public int truckEmpty { get; set; }
        public string orgCountry { get; set; }
    }

    public class resourceDto
    {
        public int codeSource { get; set; }
        public string name { get; set; }
        public int gasYield { get; set; }
        public string altName { get; set; }
        public string valueISCC { get; set; }
        public int classificationGroup { get; set; }
    }

    public class supplierDto
    {
        public int code { get; set; }
        public string name { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public int truckCap { get; set; }
        public string certCode { get; set; }
        public DateTime enddate { get; set; }
    }

    public class supplierCertDto
    {
        public string serial { get; set; }
        public bool selfdec { get; set; }
        public DateTime startdate { get; set; }
        public DateTime enddate { get; set; }
        public int supplierCode { get; set; }
        public string name { get; set; }
        public int selfdecmeth { get; set; }
    }

    public class vertoValuesDto
    {
        public string serialCert { get; set; }
        public int quantity { get; set; }
        public int ntaCode { get; set; }
        public DateTime transactionDate { get; set; }
        public int accountTo { get; set; }
    }
}
