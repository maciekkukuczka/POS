using System;
using System.Collections.Generic;
using System.Linq;
using POS.Models;


namespace POS.Data
{

    public static class DataSeed
    {
        public static List<News> GetNewses()
        {
            List<News> Newses = new List<News>();
            Newses.Add(new News()
            {
                // Id = 10,
                Content = "Test content",
                Date = DateTime.Now,
                Title = "some title",
                IsVisible = true,
                AppUser = GetAppUsers().FirstOrDefault()
            });

            return Newses;
        }

        public static List<AppUser> GetAppUsers()
        {
            var users = new List<AppUser>();

            users.Add(new AppUser()
            {
                Id = 10,
                Avatar = null,
                Blood = GetBloods().FirstOrDefault(),
                Rank = GetRanks().FirstOrDefault(),
                LastName = "Kozielski",
                FirstName = "Adrian",
                NickName = "Kozieł",
                Contacts = GetContacts(),
                Addresses = GetAddresses()
            });

            users.Add(new AppUser()
            {
                Id = 20,
                Avatar = null,
                Blood = GetBloods().FirstOrDefault(),
                Rank = GetRanks().FirstOrDefault(),
                LastName = "Kukuczka",
                FirstName = "Maciek",
                NickName = "mac",
                Contacts = GetContacts(),
                Addresses = GetAddresses()
            });

            return users;
        }

        public static List<Address> GetAddresses()
        {
            var addresses = new List<Address>();
            addresses.Add(new Address()
            {
                // Id = 10,
                City = "Katowice",
                Code = "444-55",
                Comments = "Komentarz do adresy",
                Country = "Polska",
                Line1 = "Wyzwolenia 12",
                Line2 = "Line2 adres",
                Name = "Adres domowy",
            });

            return addresses;
        }

        public static List<Rank> GetRanks()
        {
            var ranks = new List<Rank>()
            {
                new Rank()
                {
                    // Id = 10,
                    Name = "Kapitan"
                }
            };

            return ranks;
        }


        public static List<Blood> GetBloods()
        {
            var bloods = new List<Blood>();
            bloods.Add(new Blood()
            {
                Name = "Rh=+"
            });

            return bloods;
        }

        public static List<Contact> GetContacts()
        {
            var contacts = new List<Contact>();
            contacts.Add(new Contact()
            {
                ContactType = new ContactType() {Name = "Mail"},
                ContactInformation = "contact Info"
            });

            return contacts;
        }
    }

}