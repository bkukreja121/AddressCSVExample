using System;
using System.Collections.Generic;
using CsvHelper.Configuration;

public class AddressInfoClassMap : ClassMap<AddressInfo>
{
    public AddressInfoClassMap()
    {
        Map(r => r.Name).Name("Name");
        Map(r => r.Organisation).Name("organisation");
        Map(r => r.Address).Name("Address");
        Map(r => r.JoiningDate).Name("JoiningDate").TypeConverterOption.Format("s");
    }
}

public class AddressInfo
{
    public string Name { get; set; }
    public string Organisation { get; set; }
    public string Address { get; set; }
    public DateTime JoiningDate { get; set; }


    public static List<AddressInfo> GetAddress()
    {
        return new List<AddressInfo>
        {
            new AddressInfo
            {
               Name = "Bhavesh",
                Organisation = "MorningStar",
                Address = "Mumbai",
                JoiningDate = new DateTime(2021, 11, 06)
            }
            ,
               new AddressInfo
            {
               Name = "Sagar",
                Organisation = "Accenture",
                Address = "Delhi",
                JoiningDate = new DateTime(2021, 11, 04)
            }
            ,

               new AddressInfo
            {
               Name = "Karan",
                Organisation = "MorningStar",
                Address = "Mumbai",
                JoiningDate = new DateTime(2021, 01, 06)
            },
               new AddressInfo
            {
               Name = "Ram",
                Organisation = "Axis",
                Address = "Nashik",
                JoiningDate = new DateTime(2020, 11, 06)
            },
               new AddressInfo
            {
               Name = "Rajesh",
                Organisation = "MorningStar",
                Address = "UK",
                JoiningDate = new DateTime(2018, 11, 06)
            },
               new AddressInfo
            {
               Name = "seema",
                Organisation = "ICICI",
                Address = "Chennai",
                JoiningDate = new DateTime(2012, 11, 06)
            },
               new AddressInfo
            {
               Name = "rita",
                Organisation = "MorningStar",
                Address = "Mumbai",
                JoiningDate = new DateTime(2021, 11, 06)
            }, new AddressInfo
            {
               Name = "Bhavesh",
                Organisation = "MorningStar",
                Address = "Mumbai",
                JoiningDate = new DateTime(2021, 11, 06)
            },
               new AddressInfo
            {
               Name = "Bhavesh",
                Organisation = "MorningStar",
                Address = "Mumbai",
                JoiningDate = new DateTime(2021, 11, 06)
            }

         ,
            new AddressInfo
            {
                Name = "Phoenix",
                Organisation = "NASA",
                 Address = "Mumbai",
                JoiningDate = new DateTime(2043, 04, 05)
            }
        };
    }
}