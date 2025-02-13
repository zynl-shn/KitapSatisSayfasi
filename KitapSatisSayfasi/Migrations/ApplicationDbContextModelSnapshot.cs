﻿// <auto-generated />
using System;
using KitapSatisSayfasi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KitapSatisSayfasi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KitapSatisSayfasi.Models.Kategori", b =>
                {
                    b.Property<int>("KategoriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KategoriAdi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KategoriID");

                    b.ToTable("Kategoriler");

                    b.HasData(
                        new
                        {
                            KategoriID = 1,
                            KategoriAdi = "Macera"
                        },
                        new
                        {
                            KategoriID = 2,
                            KategoriAdi = "Tarih"
                        },
                        new
                        {
                            KategoriID = 3,
                            KategoriAdi = "Polisiye"
                        },
                        new
                        {
                            KategoriID = 4,
                            KategoriAdi = "Spor"
                        });
                });

            modelBuilder.Entity("KitapSatisSayfasi.Models.Kitap", b =>
                {
                    b.Property<int>("KitapID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BasimTarihi")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("KapakResmi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KitapAdi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Ozet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StokAdeti")
                        .HasColumnType("int");

                    b.Property<int>("TavsiyeSayisi")
                        .HasColumnType("int");

                    b.Property<int>("YayinEviID")
                        .HasColumnType("int");

                    b.Property<int>("YazarID")
                        .HasColumnType("int");

                    b.HasKey("KitapID");

                    b.HasIndex("YayinEviID");

                    b.HasIndex("YazarID");

                    b.ToTable("Kitaplar");

                    b.HasData(
                        new
                        {
                            KitapID = 1,
                            BasimTarihi = new DateTime(2012, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fiyat = 45m,
                            KapakResmi = "Beyoğlunun En Güzel Abisi",
                            KitapAdi = "Beyoğlunun En Güzel Abisi",
                            Ozet = "....",
                            StokAdeti = 10,
                            TavsiyeSayisi = 0,
                            YayinEviID = 1,
                            YazarID = 1
                        },
                        new
                        {
                            KitapID = 2,
                            BasimTarihi = new DateTime(2015, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fiyat = 55m,
                            KapakResmi = "Savaş Ve BARIŞ",
                            KitapAdi = "Savaş ve Barış",
                            Ozet = "....",
                            StokAdeti = 10,
                            TavsiyeSayisi = 0,
                            YayinEviID = 1,
                            YazarID = 2
                        });
                });

            modelBuilder.Entity("KitapSatisSayfasi.Models.KitapKategori", b =>
                {
                    b.Property<int>("KitapKategoriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KategoriID")
                        .HasColumnType("int");

                    b.Property<int>("KitapID")
                        .HasColumnType("int");

                    b.HasKey("KitapKategoriID");

                    b.HasIndex("KategoriID");

                    b.HasIndex("KitapID");

                    b.ToTable("KitapKategoriler");

                    b.HasData(
                        new
                        {
                            KitapKategoriID = 1,
                            KategoriID = 3,
                            KitapID = 1
                        },
                        new
                        {
                            KitapKategoriID = 2,
                            KategoriID = 2,
                            KitapID = 2
                        });
                });

            modelBuilder.Entity("KitapSatisSayfasi.Models.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "45896c50-e5e4-46f2-846c-845e64463619",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "f5c4f669-d1ab-4cc5-ba75-6a9f82828e4c",
                            Name = "Uye",
                            NormalizedName = "UYE"
                        });
                });

            modelBuilder.Entity("KitapSatisSayfasi.Models.Satis", b =>
                {
                    b.Property<int>("SatisID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("SatisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("ToplamTutar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UyeID")
                        .HasColumnType("int");

                    b.HasKey("SatisID");

                    b.HasIndex("UyeID");

                    b.ToTable("Satislar");
                });

            modelBuilder.Entity("KitapSatisSayfasi.Models.SatisDetay", b =>
                {
                    b.Property<int>("SatisDetayID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Adet")
                        .HasColumnType("int");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("KitapID")
                        .HasColumnType("int");

                    b.Property<int>("SatisID")
                        .HasColumnType("int");

                    b.HasKey("SatisDetayID");

                    b.HasIndex("KitapID");

                    b.HasIndex("SatisID");

                    b.ToTable("SatisDetaylar");
                });

            modelBuilder.Entity("KitapSatisSayfasi.Models.Sepet", b =>
                {
                    b.Property<int>("SepetID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Adet")
                        .HasColumnType("int");

                    b.Property<int>("KitapID")
                        .HasColumnType("int");

                    b.Property<int>("UyeID")
                        .HasColumnType("int");

                    b.HasKey("SepetID");

                    b.HasIndex("KitapID");

                    b.HasIndex("UyeID");

                    b.ToTable("Sepetler");
                });

            modelBuilder.Entity("KitapSatisSayfasi.Models.Uye", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            Adres = "Ümraniye",
                            ConcurrencyStamp = "94b0515e-9b44-4d38-946a-ea003fa705b6",
                            Email = "zeynelsahin@zeynelsahin.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "zeynelsahin@zeynelsahin.com",
                            NormalizedUserName = "Zeynel",
                            PasswordHash = "AQAAAAEAACcQAAAAEBey7bjaSpCkvHeL9cz2Ln8gKjpJPI3xxCQAxedYkHjJGqApqeUJtoEoxzcRcJV0ZA==",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "Zeynel"
                        });
                });

            modelBuilder.Entity("KitapSatisSayfasi.Models.YayinEvi", b =>
                {
                    b.Property<int>("YayinEviID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YayinEviAdi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("YayinEviID");

                    b.ToTable("YayinEvleri");

                    b.HasData(
                        new
                        {
                            YayinEviID = 1,
                            Adres = "Avcılar",
                            YayinEviAdi = "ABC"
                        },
                        new
                        {
                            YayinEviID = 2,
                            Adres = "Beylikdüzü",
                            YayinEviAdi = "CBA"
                        });
                });

            modelBuilder.Entity("KitapSatisSayfasi.Models.Yazar", b =>
                {
                    b.Property<int>("YazarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Biyografi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YazarAdi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("YazarID");

                    b.ToTable("Yazarlar");

                    b.HasData(
                        new
                        {
                            YazarID = 1,
                            Biyografi = "",
                            YazarAdi = "Ahmet Ümit"
                        },
                        new
                        {
                            YazarID = 2,
                            Biyografi = "",
                            YazarAdi = "Tolstoy"
                        },
                        new
                        {
                            YazarID = 3,
                            Biyografi = "",
                            YazarAdi = "Dostoyevski"
                        },
                        new
                        {
                            YazarID = 4,
                            Biyografi = "",
                            YazarAdi = "Cengiz Aymetov"
                        },
                        new
                        {
                            YazarID = 5,
                            Biyografi = "",
                            YazarAdi = "İskender Pala"
                        },
                        new
                        {
                            YazarID = 6,
                            Biyografi = "",
                            YazarAdi = "Jack London"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("KitapSatisSayfasi.Models.Kitap", b =>
                {
                    b.HasOne("KitapSatisSayfasi.Models.YayinEvi", "YayinEvi")
                        .WithMany("Kitaplar")
                        .HasForeignKey("YayinEviID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KitapSatisSayfasi.Models.Yazar", "Yazar")
                        .WithMany("Kitaplar")
                        .HasForeignKey("YazarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("YayinEvi");

                    b.Navigation("Yazar");
                });

            modelBuilder.Entity("KitapSatisSayfasi.Models.KitapKategori", b =>
                {
                    b.HasOne("KitapSatisSayfasi.Models.Kategori", "Kategori")
                        .WithMany("KitapKategoriler")
                        .HasForeignKey("KategoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KitapSatisSayfasi.Models.Kitap", "Kitap")
                        .WithMany("KitapKategoriler")
                        .HasForeignKey("KitapID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");

                    b.Navigation("Kitap");
                });

            modelBuilder.Entity("KitapSatisSayfasi.Models.Satis", b =>
                {
                    b.HasOne("KitapSatisSayfasi.Models.Uye", "Uye")
                        .WithMany("Satislar")
                        .HasForeignKey("UyeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Uye");
                });

            modelBuilder.Entity("KitapSatisSayfasi.Models.SatisDetay", b =>
                {
                    b.HasOne("KitapSatisSayfasi.Models.Kitap", "Kitap")
                        .WithMany("SatisDetaylar")
                        .HasForeignKey("KitapID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KitapSatisSayfasi.Models.Satis", "Satis")
                        .WithMany("SatisDetaylar")
                        .HasForeignKey("SatisID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kitap");

                    b.Navigation("Satis");
                });

            modelBuilder.Entity("KitapSatisSayfasi.Models.Sepet", b =>
                {
                    b.HasOne("KitapSatisSayfasi.Models.Kitap", "Kitap")
                        .WithMany("Sepetler")
                        .HasForeignKey("KitapID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KitapSatisSayfasi.Models.Uye", "Uye")
                        .WithMany("Sepetler")
                        .HasForeignKey("UyeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kitap");

                    b.Navigation("Uye");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("KitapSatisSayfasi.Models.Rol", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("KitapSatisSayfasi.Models.Uye", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("KitapSatisSayfasi.Models.Uye", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("KitapSatisSayfasi.Models.Rol", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KitapSatisSayfasi.Models.Uye", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("KitapSatisSayfasi.Models.Uye", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KitapSatisSayfasi.Models.Kategori", b =>
                {
                    b.Navigation("KitapKategoriler");
                });

            modelBuilder.Entity("KitapSatisSayfasi.Models.Kitap", b =>
                {
                    b.Navigation("KitapKategoriler");

                    b.Navigation("SatisDetaylar");

                    b.Navigation("Sepetler");
                });

            modelBuilder.Entity("KitapSatisSayfasi.Models.Satis", b =>
                {
                    b.Navigation("SatisDetaylar");
                });

            modelBuilder.Entity("KitapSatisSayfasi.Models.Uye", b =>
                {
                    b.Navigation("Satislar");

                    b.Navigation("Sepetler");
                });

            modelBuilder.Entity("KitapSatisSayfasi.Models.YayinEvi", b =>
                {
                    b.Navigation("Kitaplar");
                });

            modelBuilder.Entity("KitapSatisSayfasi.Models.Yazar", b =>
                {
                    b.Navigation("Kitaplar");
                });
#pragma warning restore 612, 618
        }
    }
}
