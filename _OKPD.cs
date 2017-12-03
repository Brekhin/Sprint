using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twitter_bot
{
    class _OKPD
    {
        public class Scan
        {
            public string url { get; set; }
            public string docDescription { get; set; }
            public string fileName { get; set; }
        }

        public class SingleCustomerReason
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class FcsOrder
        {
            public string notificationNumber { get; set; }
            public string lotNumber { get; set; }
            public string placing { get; set; }
        }

        public class Foundation
        {
            public FcsOrder fcsOrder { get; set; }
        }

        public class Execution
        {
            public DateTime startDate { get; set; }
            public DateTime endDate { get; set; }
        }

        public class Customer
        {
            public string kpp { get; set; }
            public string regNum { get; set; }
            public string fullName { get; set; }
            public string inn { get; set; }
            public string postalAddress { get; set; }
        }

        public class Currency
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class LegalForm
        {
            public string code { get; set; }
            public string singularName { get; set; }
        }

        public class ContactInfo
        {
            public string middleName { get; set; }
            public string lastName { get; set; }
            public string firstName { get; set; }
        }

        public class Supplier
        {
            public string kpp { get; set; }
            public string factualAddress { get; set; }
            public string organizationName { get; set; }
            public LegalForm legalForm { get; set; }
            public string inn { get; set; }
            public string participantType { get; set; }
            public ContactInfo contactInfo { get; set; }
        }

        public class BudgetLevel
        {
            public string code { get; set; }
        }

        public class Payments
        {
            public string KBK { get; set; }
            public string paymentYear { get; set; }
            public string paymentSumRUR { get; set; }
            public string paymentMonth { get; set; }
            public string paymentSum { get; set; }
        }

        public class Stage
        {
            public DateTime endDate { get; set; }
            public Payments payments { get; set; }
        }

        public class BudgetFunds
        {
            public List<Stage> stages { get; set; }
        }

        public class Budget
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class Finances
        {
            public BudgetLevel budgetLevel { get; set; }
            public BudgetFunds budgetFunds { get; set; }
            public Budget budget { get; set; }
        }

        public class OKPD
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class OKEI
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class Product
        {
            public string name { get; set; }
            public OKPD OKPD { get; set; }
            public OKEI OKEI { get; set; }
            public double sum { get; set; }
            public string sid { get; set; }
            public double price { get; set; }
            public string quantity { get; set; }
        }

        public class EconomicSector
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class Datum
        {
            public List<Scan> scan { get; set; }
            public string number { get; set; }
            public string currentContractStage { get; set; }
            public string id { get; set; }
            public string fileVersion { get; set; }
            public string placing { get; set; }
            public string regionCode { get; set; }
            public string contractUrl { get; set; }
            public SingleCustomerReason singleCustomerReason { get; set; }
            public DateTime signDate { get; set; }
            public double price { get; set; }
            public string placingWayCode { get; set; }
            public Foundation foundation { get; set; }
            public string fz { get; set; }
            public DateTime publishDate { get; set; }
            public string regNum { get; set; }
            public int versionNumber { get; set; }
            public string schemaVersion { get; set; }
            public Execution execution { get; set; }
            public Customer customer { get; set; }
            public Currency currency { get; set; }
            public List<Supplier> suppliers { get; set; }
            public int loadId { get; set; }
            public Finances finances { get; set; }
            public string mongo_id { get; set; }
            public List<Product> products { get; set; }
            public string printFormUrl { get; set; }
            public List<EconomicSector> economic_sectors { get; set; }
        }

        public class Contracts
        {
            public int total { get; set; }
            public List<Datum> data { get; set; }
            public int page { get; set; }
            public int perpage { get; set; }
        }

        public class RootObject2
        {
            public Contracts contracts { get; set; }
        }
    }
}
