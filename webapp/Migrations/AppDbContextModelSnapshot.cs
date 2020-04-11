﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models;

namespace webapp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "9de7451e-9259-4295-8ea3-8e550349f481",
                            ConcurrencyStamp = "6906ef49-ce96-473e-8aa8-e2fdd3b990d8",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "69276be7-92f8-46d4-ae7f-c89401f89b7b",
                            ConcurrencyStamp = "bb47ce6b-51b4-4bd6-929a-9c3c2e38e33f",
                            Name = "CustomerPeople",
                            NormalizedName = "CUSTOMERPEOPLE"
                        },
                        new
                        {
                            Id = "13e2c407-4e80-4aad-b3a0-f42faf8527b4",
                            ConcurrencyStamp = "6fb6c7b4-2f50-4df9-afa9-71c00681bbff",
                            Name = "CustomerBusiness",
                            NormalizedName = "CUSTOMERBUSINESS"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "3958266f-67b7-4bd7-9dd1-f5e0a6efa8ca",
                            RoleId = "9de7451e-9259-4295-8ea3-8e550349f481"
                        },
                        new
                        {
                            UserId = "015dd6e3-065d-4846-b268-a6217e7f6b29",
                            RoleId = "9de7451e-9259-4295-8ea3-8e550349f481"
                        },
                        new
                        {
                            UserId = "27c72385-07ff-4852-9a67-dd9a253cbc68",
                            RoleId = "9de7451e-9259-4295-8ea3-8e550349f481"
                        },
                        new
                        {
                            UserId = "cd18dc91-554c-4b75-9171-455c4be6cd7e",
                            RoleId = "9de7451e-9259-4295-8ea3-8e550349f481"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AppartmentNumber")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CivicNumber")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Terrebonne",
                            CivicNumber = 2502,
                            Country = "Canada",
                            PostalCode = "J6X 0A5",
                            State = "QC",
                            Street = "Des jacinthes"
                        },
                        new
                        {
                            Id = 2,
                            AppartmentNumber = 2,
                            City = "Montreal",
                            CivicNumber = 2265,
                            Country = "Canada",
                            PostalCode = "H1V 2E6",
                            State = "QC",
                            Street = "Boulevard PIE-IX"
                        },
                        new
                        {
                            Id = 3,
                            City = "Montreal",
                            CivicNumber = 4500,
                            Country = "Canada",
                            PostalCode = "H1V 3N8",
                            State = "QC",
                            Street = "Hochelaga"
                        });
                });

            modelBuilder.Entity("Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descrption")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("ville")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "3958266f-67b7-4bd7-9dd1-f5e0a6efa8ca",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "69b00e7b-da0d-4292-bd33-5153a7e3c03f",
                            Descrption = "J'aime les Teckels et je suis ici pour participer a des courses a Teckel",
                            Email = "jordangauthier@noname.com",
                            EmailConfirmed = false,
                            FirstName = "Jordan",
                            LastName = "Gauthier",
                            LockoutEnabled = false,
                            NormalizedEmail = "JORDANGAUTHIER@NONAME.COM",
                            NormalizedUserName = "JORDANGAUTHIER@NONAME.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEEeNtkQHnpbEQF0+5nVO+24XfpkPp0u4ubhjR7Wz0jUNhApU4sNXk4/RWTPZkD/+qQ==",
                            PhoneNumber = "514-979-7316",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "87ae8e44-3e19-48ef-bb30-d025ab6f883a",
                            TwoFactorEnabled = false,
                            UserName = "jordangauthier@noname.com",
                            ville = "Terrebonne"
                        },
                        new
                        {
                            Id = "015dd6e3-065d-4846-b268-a6217e7f6b29",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fd121b93-1564-4bf8-bbe2-f9079b20f64a",
                            Descrption = "J'aime le Hockey et je suis ici pour jouer au Hockey",
                            Email = "alexdufour@noname.com",
                            EmailConfirmed = false,
                            FirstName = "Alex",
                            LastName = "Dufour",
                            LockoutEnabled = false,
                            NormalizedEmail = "ALEXDUFOUR@NONAME.COM",
                            NormalizedUserName = "ALEXDUFOUR@NONAME.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEEeNtkQHnpbEQF0+5nVO+24XfpkPp0u4ubhjR7Wz0jUNhApU4sNXk4/RWTPZkD/+qQ==",
                            PhoneNumber = "514-911-9111",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c57b0d42-035a-4418-9a16-ac7e8922e470",
                            TwoFactorEnabled = false,
                            UserName = "alexdufour@noname.com",
                            ville = "Montreal"
                        },
                        new
                        {
                            Id = "27c72385-07ff-4852-9a67-dd9a253cbc68",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "624bfb9f-4030-4325-8920-83e18511e662",
                            Descrption = "J'aime le Karate et je suis ici pour ca",
                            Email = "alexhamel@noname.com",
                            EmailConfirmed = false,
                            FirstName = "Alexandre",
                            LastName = "Hamel-Boudreault",
                            LockoutEnabled = false,
                            NormalizedEmail = "alexhamel@noname.com",
                            NormalizedUserName = "alexhamel@noname.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEEeNtkQHnpbEQF0+5nVO+24XfpkPp0u4ubhjR7Wz0jUNhApU4sNXk4/RWTPZkD/+qQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b02a0808-5724-416f-a3bb-0920174e8f2f",
                            TwoFactorEnabled = false,
                            UserName = "alexhamel@noname.com",
                            ville = "Montreal"
                        },
                        new
                        {
                            Id = "cd18dc91-554c-4b75-9171-455c4be6cd7e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "57384a10-2bc9-4d0c-933a-89e42d8cd851",
                            Descrption = "J'aime les Statistiques et je suis ici pour rejoindre un club de chess",
                            Email = "philippesoucy@noname.com",
                            EmailConfirmed = false,
                            FirstName = "Philippe",
                            LastName = "Soucy",
                            LockoutEnabled = false,
                            NormalizedEmail = "PHILIPPESOUCY@NONAME.COM",
                            NormalizedUserName = "PHILIPPESOUCY@NONAME.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEEeNtkQHnpbEQF0+5nVO+24XfpkPp0u4ubhjR7Wz0jUNhApU4sNXk4/RWTPZkD/+qQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "435f05ee-be88-4e14-ba24-8927b57f6aa3",
                            TwoFactorEnabled = false,
                            UserName = "philippesoucy@noname.com",
                            ville = "Montreal"
                        });
                });

            modelBuilder.Entity("Models.Business", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Businesses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressId = 3,
                            Description = " Nous offrons des services d'entrainement et des levers de fonds Venez essayer 1 mois gratuitNous nos locaux Hochelga",
                            Name = "Pro gym",
                            Phone = "(514) 252-8704"
                        },
                        new
                        {
                            Id = 2,
                            AddressId = 1,
                            Description = " Nous offrons des services d'entrainement et des levers de fonds",
                            Name = "Groupe tazor",
                            Phone = "(514) 911-9111"
                        });
                });

            modelBuilder.Entity("Models.Commentaire", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("UserId");

                    b.ToTable("Commentaires");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Wow malade l'evenement",
                            EventId = 1,
                            UserId = "3958266f-67b7-4bd7-9dd1-f5e0a6efa8ca"
                        });
                });

            modelBuilder.Entity("Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("BusinessId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EventTypeId")
                        .HasColumnType("int");

                    b.Property<double>("PriceToPayToParticipate")
                        .HasColumnType("float");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("BusinessId");

                    b.HasIndex("EventTypeId");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressId = 3,
                            ApplicationUserId = "3958266f-67b7-4bd7-9dd1-f5e0a6efa8ca",
                            BusinessId = 1,
                            Description = "Fun fun Zumba de Jordan perte de poids assurer 100% garantie.",
                            EndDate = new DateTime(2020, 4, 25, 18, 30, 0, 0, DateTimeKind.Unspecified),
                            EventTypeId = 1,
                            PriceToPayToParticipate = 50.0,
                            StartDate = new DateTime(2020, 4, 25, 13, 30, 0, 0, DateTimeKind.Unspecified),
                            Title = "Zumba de Jordan"
                        },
                        new
                        {
                            Id = 2,
                            AddressId = 2,
                            ApplicationUserId = "015dd6e3-065d-4846-b268-a6217e7f6b29",
                            BusinessId = 2,
                            Description = "Venez reprendre le poids Perdu a La Zumba de jordan!",
                            EndDate = new DateTime(2020, 4, 25, 18, 30, 0, 0, DateTimeKind.Unspecified),
                            EventTypeId = 1,
                            PriceToPayToParticipate = 50.0,
                            StartDate = new DateTime(2020, 4, 25, 13, 30, 0, 0, DateTimeKind.Unspecified),
                            Title = "Souper spaghetti de dufour (Lever de fond)"
                        },
                        new
                        {
                            Id = 3,
                            AddressId = 2,
                            ApplicationUserId = "015dd6e3-065d-4846-b268-a6217e7f6b29",
                            BusinessId = 2,
                            Description = "Je suis du passer!",
                            EndDate = new DateTime(2020, 2, 25, 18, 30, 0, 0, DateTimeKind.Unspecified),
                            EventTypeId = 1,
                            PriceToPayToParticipate = 50.0,
                            StartDate = new DateTime(2020, 2, 25, 13, 30, 0, 0, DateTimeKind.Unspecified),
                            Title = "Evenement Dans le Passer"
                        },
                        new
                        {
                            Id = 4,
                            AddressId = 2,
                            ApplicationUserId = "015dd6e3-065d-4846-b268-a6217e7f6b29",
                            BusinessId = 2,
                            Description = "Je suis du passer!",
                            EndDate = new DateTime(2020, 1, 25, 18, 30, 0, 0, DateTimeKind.Unspecified),
                            EventTypeId = 1,
                            PriceToPayToParticipate = 50.0,
                            StartDate = new DateTime(2020, 1, 25, 13, 30, 0, 0, DateTimeKind.Unspecified),
                            Title = "Evenement De Tennis"
                        });
                });

            modelBuilder.Entity("Models.EventApplicationUser", b =>
                {
                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.HasKey("ApplicationUserId", "EventId");

                    b.HasIndex("EventId");

                    b.ToTable("EventApplicationUsers");

                    b.HasData(
                        new
                        {
                            ApplicationUserId = "3958266f-67b7-4bd7-9dd1-f5e0a6efa8ca",
                            EventId = 1
                        },
                        new
                        {
                            ApplicationUserId = "015dd6e3-065d-4846-b268-a6217e7f6b29",
                            EventId = 1
                        },
                        new
                        {
                            ApplicationUserId = "3958266f-67b7-4bd7-9dd1-f5e0a6efa8ca",
                            EventId = 2
                        },
                        new
                        {
                            ApplicationUserId = "015dd6e3-065d-4846-b268-a6217e7f6b29",
                            EventId = 2
                        },
                        new
                        {
                            ApplicationUserId = "015dd6e3-065d-4846-b268-a6217e7f6b29",
                            EventId = 3
                        },
                        new
                        {
                            ApplicationUserId = "27c72385-07ff-4852-9a67-dd9a253cbc68",
                            EventId = 3
                        },
                        new
                        {
                            ApplicationUserId = "27c72385-07ff-4852-9a67-dd9a253cbc68",
                            EventId = 4
                        },
                        new
                        {
                            ApplicationUserId = "015dd6e3-065d-4846-b268-a6217e7f6b29",
                            EventId = 4
                        },
                        new
                        {
                            ApplicationUserId = "cd18dc91-554c-4b75-9171-455c4be6cd7e",
                            EventId = 2
                        },
                        new
                        {
                            ApplicationUserId = "27c72385-07ff-4852-9a67-dd9a253cbc68",
                            EventId = 2
                        });
                });

            modelBuilder.Entity("Models.EventType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EventTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "Entrainement"
                        },
                        new
                        {
                            Id = 2,
                            Title = "Lever de fond"
                        });
                });

            modelBuilder.Entity("Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MessageConversationId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("MessageConversationId");

                    b.HasIndex("UserId");

                    b.ToTable("Messages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Est-tu pret big ?",
                            MessageConversationId = 1,
                            UserId = "3958266f-67b7-4bd7-9dd1-f5e0a6efa8ca"
                        },
                        new
                        {
                            Id = 2,
                            Content = "Je sais pas toi ?",
                            MessageConversationId = 1,
                            UserId = "015dd6e3-065d-4846-b268-a6217e7f6b29"
                        },
                        new
                        {
                            Id = 3,
                            Content = "Je sais pas non plus.",
                            MessageConversationId = 1,
                            UserId = "3958266f-67b7-4bd7-9dd1-f5e0a6efa8ca"
                        },
                        new
                        {
                            Id = 4,
                            Content = "Mtseee",
                            MessageConversationId = 1,
                            UserId = "015dd6e3-065d-4846-b268-a6217e7f6b29"
                        });
                });

            modelBuilder.Entity("Models.MessageConversation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ReceiverId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SenderId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("SenderId");

                    b.ToTable("MessageConversations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ReceiverId = "015dd6e3-065d-4846-b268-a6217e7f6b29",
                            SenderId = "3958266f-67b7-4bd7-9dd1-f5e0a6efa8ca",
                            Subject = "tournois de cs pas d'awp"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Models.Business", b =>
                {
                    b.HasOne("Models.Address", "Address")
                        .WithMany("Businesses")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Models.Commentaire", b =>
                {
                    b.HasOne("Models.Event", "Event")
                        .WithMany("Commentaires")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Models.Event", b =>
                {
                    b.HasOne("Models.Address", "Address")
                        .WithMany("Events")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Models.ApplicationUser", "ApplicationUser")
                        .WithMany("Events")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Models.Business", "Business")
                        .WithMany("Events")
                        .HasForeignKey("BusinessId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Models.EventType", "EventType")
                        .WithMany("Events")
                        .HasForeignKey("EventTypeId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Models.EventApplicationUser", b =>
                {
                    b.HasOne("Models.ApplicationUser", "ApplicationUser")
                        .WithMany("EventsParticipation")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Models.Event", "Event")
                        .WithMany()
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Models.Message", b =>
                {
                    b.HasOne("Models.MessageConversation", "MessageConversation")
                        .WithMany("Messages")
                        .HasForeignKey("MessageConversationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Models.ApplicationUser", "User")
                        .WithMany("Messages")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Models.MessageConversation", b =>
                {
                    b.HasOne("Models.ApplicationUser", "Receiver")
                        .WithMany("MessageConversationsReceiver")
                        .HasForeignKey("ReceiverId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Models.ApplicationUser", "Sender")
                        .WithMany("MessageConversationsSender")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
