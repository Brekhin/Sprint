using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twitter_bot
{
    public class ContactInfo
    {
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
    }

    public class Country
    {
        public string countryCode { get; set; }
        public string countryFullName { get; set; }
    }

    public class CustomersList
    {
        public string kpp { get; set; }
        public int contractsCount { get; set; }
        public double contractsSum { get; set; }
        public string inn { get; set; }
        public string regNumber { get; set; }
        public string fullName { get; set; }
    }

    public class __invalid_type__2015
    {
        public int contractsCount { get; set; }
        public int contractsSum { get; set; }
    }

    public class __invalid_type__2014
    {
        public int contractsCount { get; set; }
        public int contractsSum { get; set; }
    }

    public class __invalid_type__2017
    {
        public int contractsCount { get; set; }
        public int contractsSum { get; set; }
    }

    public class __invalid_type__2016
    {
        public int contractsCount { get; set; }
        public int contractsSum { get; set; }
    }

    public class __invalid_type__2011
    {
        public int contractsCount { get; set; }
        public double contractsSum { get; set; }
    }

    public class __invalid_type__2010
    {
        public int contractsCount { get; set; }
        public int contractsSum { get; set; }
    }

    public class __invalid_type__2013
    {
        public int contractsCount { get; set; }
        public int contractsSum { get; set; }
    }

    public class __invalid_type__2012
    {
        public int contractsCount { get; set; }
        public int contractsSum { get; set; }
    }

    public class ContractsYearStats
    {
        public __invalid_type__2015 __invalid_name__2015 { get; set; }
        public __invalid_type__2014 __invalid_name__2014 { get; set; }
        public __invalid_type__2017 __invalid_name__2017 { get; set; }
        public __invalid_type__2016 __invalid_name__2016 { get; set; }
        public __invalid_type__2011 __invalid_name__2011 { get; set; }
        public __invalid_type__2010 __invalid_name__2010 { get; set; }
        public __invalid_type__2013 __invalid_name__2013 { get; set; }
        public __invalid_type__2012 __invalid_name__2012 { get; set; }
    }

    public class Coordinates
    {
        public string lat { get; set; }
        public string lon { get; set; }
    }

    public class Datum
    {
        public string kpp { get; set; }
        public string factualAddress { get; set; }
        public ContactInfo contactInfo { get; set; }
        public string organizationName { get; set; }
        public string organizationForm { get; set; }
        public int contractsCount { get; set; }
        public Country country { get; set; }
        public List<CustomersList> customers_list { get; set; }
        public ContractsYearStats contractsYearStats { get; set; }
        public Coordinates coordinates { get; set; }
        public string mongo_id { get; set; }
        public string regionCode { get; set; }
        public string inn { get; set; }
        public List<string> allNames { get; set; }
        public double contractsSum { get; set; }
        public string participantType { get; set; }
        public string postAddress { get; set; }
        public string contactFax { get; set; }
    }

    public class Suppliers
    {
        public int total { get; set; }
        public List<Datum> data { get; set; }
        public int page { get; set; }
        public int perpage { get; set; }
    }

    public class RootObject3
    {
        public Suppliers suppliers { get; set; }
    }
}
