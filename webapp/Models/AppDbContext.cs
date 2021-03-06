﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Managers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Models;
using Services;

namespace Models
{

    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        // !@#$%^&* MET LE NOM DE TES ENTITES AU PLURIEL ICI !@#$%^&*  //

        public DbSet<Avatar> Avatars { get; set; }
        public DbSet<Business> Businesses { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventApplicationUser> EventApplicationUsers { get; set; }
        public DbSet<Message> Messages { get; set; }

        public DbSet<Commentaire> Commentaires { get; set; }
        public DbSet<MessageConversation> MessageConversations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            PasswordHasher<ApplicationUser> hasher = new PasswordHasher<ApplicationUser>();

            Dictionary<string, string> roleIds = new Dictionary<string, string>() { { "Admin", Guid.NewGuid ().ToString () }, { "CustomerPeople", Guid.NewGuid ().ToString () }, { "CustomerBusiness", Guid.NewGuid ().ToString () },
            };

            Dictionary<string, string> userIds = new Dictionary<string, string>() { { "jordangauthier@noname.com", Guid.NewGuid ().ToString () }, { "alexdufour@noname.com", Guid.NewGuid ().ToString () }, { "philippesoucy@noname.com", Guid.NewGuid ().ToString () }, { "alexhamel@noname.com", Guid.NewGuid ().ToString () }
            };

            var passwordHash = hasher.HashPassword(null, "admin123");

            base.OnModelCreating(modelBuilder);

            // Relation for an ApplicationUsers and Avatars

            modelBuilder.Entity<ApplicationUser>()
                .HasOne(x => x.Avatar)
                .WithOne(y => y.ApplicationUser)
                .HasForeignKey<Avatar>(x => x.ApplicationUserId);

            // RELATION 1 //

            modelBuilder.Entity<Event>()
                .HasOne(e => e.Business)
                .WithMany(e => e.Events)
                .OnDelete(DeleteBehavior.Restrict);

            // RELATION 2 //

            modelBuilder.Entity<Event>()
                .HasOne(e => e.Address)
                .WithMany(e => e.Events)
                .OnDelete(DeleteBehavior.Restrict);

            // RELATION 3 //

            modelBuilder.Entity<Event>()
                .HasOne(e => e.EventType)
                .WithMany(e => e.Events)
                .OnDelete(DeleteBehavior.Restrict);

            // RELATION 4 //

            modelBuilder.Entity<Event>()
                .HasOne(e => e.ApplicationUser)
                .WithMany(e => e.Events)
                .OnDelete(DeleteBehavior.Restrict);

            // RELATION 5 //

            modelBuilder.Entity<Business>()
                .HasOne(e => e.Address)
                .WithMany(e => e.Businesses)
                .OnDelete(DeleteBehavior.Cascade);

            // RELATION 6-7 //

            modelBuilder.Entity<EventApplicationUser>()
                .HasKey(e => new { e.ApplicationUserId, e.EventId });

            modelBuilder.Entity<EventApplicationUser>()
                .HasOne(e => e.ApplicationUser)
                .WithMany(e => e.EventsParticipation)
                .HasForeignKey(e => e.ApplicationUserId)
                .OnDelete(DeleteBehavior.Restrict);

            /* modelBuilder.Entity<EventApplicationUser>()
                 .HasOne(e => e.Event)
                 .WithMany(e => e.Members)
                 .HasForeignKey(e => e.EventId)
                 .OnDelete(DeleteBehavior.Restrict);*/

            modelBuilder.Entity<MessageConversation>()
                .HasMany(x => x.Messages)
                .WithOne(x => x.MessageConversation)
                .OnDelete(DeleteBehavior.Restrict);

            // modelBuilder.Entity<Message>()
            // .Ignore(x => x.MessageConversation);

            modelBuilder.Entity<Commentaire>()
                .HasOne(x => x.Event)
                .WithMany(x => x.Commentaires)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<MessageConversation>()
                .HasOne(x => x.Sender)
                .WithMany(x => x.MessageConversationsSender)
                .HasForeignKey(x => x.SenderId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<MessageConversation>()
                .HasOne(x => x.Receiver)
                .WithMany(x => x.MessageConversationsReceiver)
                .HasForeignKey(x => x.ReceiverId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = roleIds["Admin"],
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Id = roleIds["CustomerPeople"],
                    Name = "CustomerPeople",
                    NormalizedName = "CUSTOMERPEOPLE"
                },
                new IdentityRole
                {
                    Id = roleIds["CustomerBusiness"],
                    Name = "CustomerBusiness",
                    NormalizedName = "CUSTOMERBUSINESS"
                }
            );

            var jordan = new ApplicationUser
            {
                Id = userIds["jordangauthier@noname.com"],
                UserName = "jordangauthier@noname.com",
                Email = "jordangauthier@noname.com",
                FirstName = "Jordan",
                LastName = "Gauthier",
                Descrption = "J'aime les Teckels et je suis ici pour participer a des courses a Teckel",
                ville = "Terrebonne",
                NormalizedUserName = "JORDANGAUTHIER@NONAME.COM",
                NormalizedEmail = "JORDANGAUTHIER@NONAME.COM",
                PhoneNumber = "514-979-7316",
                PhoneNumberConfirmed = true,
                PasswordHash = passwordHash,

            };

            // SEEDING APPLICATION USERS //

            modelBuilder.Entity<ApplicationUser>().HasData(
                jordan,
                new ApplicationUser
                {
                    Id = userIds["alexdufour@noname.com"],
                    UserName = "alexdufour@noname.com",
                    Email = "alexdufour@noname.com",
                    FirstName = "Alex",
                    LastName = "Dufour",
                    Descrption = "J'aime le Hockey et je suis ici pour jouer au Hockey",
                    ville = "Montreal",
                    NormalizedUserName = "ALEXDUFOUR@NONAME.COM",
                    NormalizedEmail = "ALEXDUFOUR@NONAME.COM",
                    PhoneNumber = "514-911-9111",
                    PhoneNumberConfirmed = false,
                    PasswordHash = passwordHash
                },
                new ApplicationUser
                {
                    Id = userIds["alexhamel@noname.com"],
                    UserName = "alexhamel@noname.com",
                    Email = "alexhamel@noname.com",
                    FirstName = "Alexandre",
                    LastName = "Hamel-Boudreault",
                    Descrption = "J'aime le Karate et je suis ici pour ca",
                    ville = "Montreal",
                    NormalizedUserName = "alexhamel@noname.com",
                    NormalizedEmail = "alexhamel@noname.com",
                    PasswordHash = passwordHash
                },
                new ApplicationUser
                {
                    Id = userIds["philippesoucy@noname.com"],
                    UserName = "philippesoucy@noname.com",
                    Email = "philippesoucy@noname.com",
                    FirstName = "Philippe",
                    LastName = "Soucy",
                    Descrption = "J'aime les Statistiques et je suis ici pour rejoindre un club de chess",
                    ville = "Montreal",
                    NormalizedUserName = "PHILIPPESOUCY@NONAME.COM",
                    NormalizedEmail = "PHILIPPESOUCY@NONAME.COM",
                    PasswordHash = passwordHash
                }
            );

            // SEEDING APPLICATION USERS ROLES //

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = roleIds["Admin"],
                    UserId = userIds["jordangauthier@noname.com"]
                },
                new IdentityUserRole<string>
                {
                    RoleId = roleIds["Admin"],
                    UserId = userIds["alexdufour@noname.com"]
                },
                new IdentityUserRole<string>
                {
                    RoleId = roleIds["Admin"],
                    UserId = userIds["alexhamel@noname.com"]
                },
                new IdentityUserRole<string>
                {
                    RoleId = roleIds["Admin"],
                    UserId = userIds["philippesoucy@noname.com"]
                }
            );

            // SEEDING ADDRESS //

            modelBuilder.Entity<Address>().HasData(
                new Address
                {
                    Id = 1,
                    Street = "Des jacinthes",
                    PostalCode = "J6X 0A5",
                    State = "QC",
                    Country = "Canada",
                    CivicNumber = 2502,
                    City = "Terrebonne"
                },
                new Address
                {
                    Id = 2,
                    Street = "Boulevard PIE-IX",
                    PostalCode = "H1V 2E6",
                    State = "QC",
                    Country = "Canada",
                    CivicNumber = 2265,
                    City = "Montreal",
                    AppartmentNumber = 2
                },
                new Address
                {
                    Id = 3,
                    Street = "Hochelaga",
                    PostalCode = "H1V 3N8",
                    State = "QC",
                    Country = "Canada",
                    CivicNumber = 4500,
                    City = "Montreal"
                }
            );

            // SEEDIND BUSINESS //

            modelBuilder.Entity<Business>().HasData(
                new
                {
                    Id = 1,
                    Name = "Pro gym",
                    Description = " Nous offrons des services d'entrainement et des levers de fonds Venez essayer 1 mois gratuit" +
                        "Nous nos locaux Hochelga",
                    Phone = "(514) 252-8704",
                    AddressId = 3
                },
                new
                {
                    Id = 2,
                    Name = "Groupe tazor",
                    Description = " Nous offrons des services d'entrainement et des levers de fonds",
                    Phone = "(514) 911-9111",
                    AddressId = 1
                }
            );

            // SEEDING EVENTTYPE //

            modelBuilder.Entity<EventType>().HasData(
                new EventType
                {
                    Id = 1,
                    Title = "Entrainement"
                },
                new EventType
                {
                    Id = 2,
                    Title = "Lever de fond"
                }
            );

            modelBuilder.Entity<Commentaire>().HasData(
                new
                {
                    Id = 1,
                    Content = "Wow malade l'evenement",
                    UserId = userIds["jordangauthier@noname.com"],
                    EventId = 1,
                });

            // SEEDING EVENT //

            modelBuilder.Entity<Event>().HasData(
                new
                {
                    Id = 1,
                    AddressId = 3,
                    BusinessId = 1,
                    ApplicationUserId = userIds["jordangauthier@noname.com"],
                    StartDate = new DateTime(2020, 04, 25, 13, 30, 0),
                    EndDate = new DateTime(2020, 04, 25, 18, 30, 0),
                    PriceToPayToParticipate = 50.0,
                    Title = "Zumba de Jordan",
                    EventTypeId = 1,
                    Description = "Fun fun Zumba de Jordan perte de poids assurer 100% garantie.",

                },
                new
                {
                    Id = 2,
                    AddressId = 2,
                    BusinessId = 2,
                    ApplicationUserId = userIds["alexdufour@noname.com"],
                    StartDate = new DateTime(2020, 04, 25, 13, 30, 0),
                    EndDate = new DateTime(2020, 04, 25, 18, 30, 0),
                    PriceToPayToParticipate = 50.0,
                    Title = "Souper spaghetti de dufour (Lever de fond)",
                    EventTypeId = 2,
                    Description = "Venez reprendre le poids Perdu a La Zumba de jordan!"
                },
                new
                {
                    Id = 3,
                    AddressId = 2,
                    BusinessId = 2,
                    ApplicationUserId = userIds["alexdufour@noname.com"],
                    StartDate = new DateTime(2020, 02, 25, 13, 30, 0),
                    EndDate = new DateTime(2020, 02, 25, 18, 30, 0),
                    PriceToPayToParticipate = 50.0,
                    Title = "Evenement Dans le Passer",
                    EventTypeId = 1,
                    Description = "Je suis du passer!"
                },
                new
                {
                    Id = 4,
                    AddressId = 2,
                    BusinessId = 2,
                    ApplicationUserId = userIds["alexdufour@noname.com"],
                    StartDate = new DateTime(2020, 01, 25, 13, 30, 0),
                    EndDate = new DateTime(2020, 01, 25, 18, 30, 0),
                    PriceToPayToParticipate = 50.0,
                    Title = "Evenement De Tennis",
                    EventTypeId = 1,
                    Description = "Je suis du passer!"
                },
                new
                {
                    Id = 5,
                    AddressId = 2,
                    BusinessId = 2,
                    ApplicationUserId = userIds["alexdufour@noname.com"],
                    StartDate = new DateTime(2020, 01, 25, 13, 30, 0),
                    EndDate = new DateTime(2020, 01, 25, 18, 30, 0),
                    PriceToPayToParticipate = 50.0,
                    Title = "La Course de Montreal",
                    EventTypeId = 1,
                    Description = "Belle course de 50km"
                }

            );

            // SEEDING EVENT APPLICATION USER //

            modelBuilder.Entity<EventApplicationUser>().HasData(
                new EventApplicationUser
                {
                    ApplicationUserId = userIds["jordangauthier@noname.com"],
                    EventId = 1
                },
                new EventApplicationUser
                {
                    ApplicationUserId = userIds["alexdufour@noname.com"],
                    EventId = 1
                },
                new EventApplicationUser
                {
                    ApplicationUserId = userIds["jordangauthier@noname.com"],
                    EventId = 2
                },
                new EventApplicationUser
                {
                    ApplicationUserId = userIds["alexdufour@noname.com"],
                    EventId = 2
                },
                new EventApplicationUser
                {
                    ApplicationUserId = userIds["alexdufour@noname.com"],
                    EventId = 3
                },
                new EventApplicationUser
                {
                    ApplicationUserId = userIds["alexhamel@noname.com"],
                    EventId = 3
                },
                new EventApplicationUser
                {
                    ApplicationUserId = userIds["alexhamel@noname.com"],
                    EventId = 4
                },
                new EventApplicationUser
                {
                    ApplicationUserId = userIds["alexdufour@noname.com"],
                    EventId = 4
                },
                new EventApplicationUser
                {
                    ApplicationUserId = userIds["alexdufour@noname.com"],
                    EventId = 5
                },
                new EventApplicationUser
                {
                    ApplicationUserId = userIds["philippesoucy@noname.com"],
                    EventId = 2
                },
                new EventApplicationUser
                {
                    ApplicationUserId = userIds["alexhamel@noname.com"],
                    EventId = 2
                }
            );

            modelBuilder.Entity<MessageConversation>().HasData(
                new MessageConversation
                {
                    Id = 1,
                    SenderId = userIds["jordangauthier@noname.com"],
                    ReceiverId = userIds["alexdufour@noname.com"],
                    Subject = "tournois de cs pas d'awp"
                }
            );

            modelBuilder.Entity<Message>().HasData(
                new
                {
                    Id = 1,
                    Content = "Est-tu pret big ?",
                    MessageConversationId = 1,
                    UserId = userIds["jordangauthier@noname.com"]
                },
                new
                {
                    Id = 2,
                    Content = "Je sais pas toi ?",
                    MessageConversationId = 1,
                    UserId = userIds["alexdufour@noname.com"]
                },
                new
                {
                    Id = 3,
                    Content = "Je sais pas non plus.",
                    MessageConversationId = 1,
                    UserId = userIds["jordangauthier@noname.com"]
                },
                new
                {
                    Id = 4,
                    Content = "Mtseee",
                    MessageConversationId = 1,
                    UserId = userIds["alexdufour@noname.com"]
                }
            );

        }
    }
}