﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using POS.Data;


namespace POS.Migrations
{

    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0-rc.1.20451.13");

            modelBuilder.Entity("AppUserGamesGroup", b =>
            {
                b.Property<int>("AppUsersId")
                    .HasColumnType("int");

                b.Property<int>("GamesGroupsId")
                    .HasColumnType("int");

                b.HasKey("AppUsersId", "GamesGroupsId");

                b.HasIndex("GamesGroupsId");

                b.ToTable("AppUserGamesGroup");
            });

            modelBuilder.Entity("CMSPageImage", b =>
            {
                b.Property<int>("CmsPagesId")
                    .HasColumnType("int");

                b.Property<int>("ImagesId")
                    .HasColumnType("int");

                b.HasKey("CmsPagesId", "ImagesId");

                b.HasIndex("ImagesId");

                b.ToTable("CMSPageImage");
            });

            modelBuilder.Entity("GalleryImage", b =>
            {
                b.Property<int>("GalleriesId")
                    .HasColumnType("int");

                b.Property<int>("ImagesId")
                    .HasColumnType("int");

                b.HasKey("GalleriesId", "ImagesId");

                b.HasIndex("ImagesId");

                b.ToTable("GalleryImage");
            });

            modelBuilder.Entity("GamesGroupNews", b =>
            {
                b.Property<int>("GamesGroupsId")
                    .HasColumnType("int");

                b.Property<int>("NewsesId")
                    .HasColumnType("int");

                b.HasKey("GamesGroupsId", "NewsesId");

                b.HasIndex("NewsesId");

                b.ToTable("GamesGroupNews");
            });

            modelBuilder.Entity("ImageNews", b =>
            {
                b.Property<int>("BlogPostsId")
                    .HasColumnType("int");

                b.Property<int>("ImagesId")
                    .HasColumnType("int");

                b.HasKey("BlogPostsId", "ImagesId");

                b.HasIndex("ImagesId");

                b.ToTable("ImageNews");
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
            {
                b.Property<string>("Id")
                    .HasColumnType("nvarchar(450)");

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
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .UseIdentityColumn();

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
            {
                b.Property<string>("Id")
                    .HasColumnType("nvarchar(450)");

                b.Property<int>("AccessFailedCount")
                    .HasColumnType("int");

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
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .UseIdentityColumn();

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
                    .HasMaxLength(128)
                    .HasColumnType("nvarchar(128)");

                b.Property<string>("ProviderKey")
                    .HasMaxLength(128)
                    .HasColumnType("nvarchar(128)");

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
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
            {
                b.Property<string>("UserId")
                    .HasColumnType("nvarchar(450)");

                b.Property<string>("LoginProvider")
                    .HasMaxLength(128)
                    .HasColumnType("nvarchar(128)");

                b.Property<string>("Name")
                    .HasMaxLength(128)
                    .HasColumnType("nvarchar(128)");

                b.Property<string>("Value")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("UserId", "LoginProvider", "Name");

                b.ToTable("AspNetUserTokens");
            });

            modelBuilder.Entity("POS.Models.Address", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .UseIdentityColumn();

                b.Property<int>("AppUserId")
                    .HasColumnType("int");

                b.Property<string>("City")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Class")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Code")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Comments")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Country")
                    .HasColumnType("nvarchar(max)");

                b.Property<bool>("IsActive")
                    .HasColumnType("bit");

                b.Property<bool>("IsVisible")
                    .HasColumnType("bit");

                b.Property<string>("Line1")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Line2")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.HasIndex("AppUserId");

                b.ToTable("Addresses");
            });

            modelBuilder.Entity("POS.Models.AppUser", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .UseIdentityColumn();

                b.Property<int?>("AvatarId")
                    .HasColumnType("int");

                b.Property<int>("BloodId")
                    .HasColumnType("int");

                b.Property<string>("Class")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("FirstName")
                    .HasColumnType("nvarchar(max)");

                b.Property<bool>("IsActive")
                    .HasColumnType("bit");

                b.Property<bool>("IsVisible")
                    .HasColumnType("bit");

                b.Property<string>("LastName")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("NickName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("RankId")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.HasIndex("AvatarId");

                b.HasIndex("BloodId");

                b.HasIndex("RankId");

                b.ToTable("AppUsers");
            });

            modelBuilder.Entity("POS.Models.Blood", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .UseIdentityColumn();

                b.Property<string>("Class")
                    .HasColumnType("nvarchar(max)");

                b.Property<bool>("IsActive")
                    .HasColumnType("bit");

                b.Property<bool>("IsVisible")
                    .HasColumnType("bit");

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Bloods");
            });

            modelBuilder.Entity("POS.Models.CMSPage", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .UseIdentityColumn();

                b.Property<int>("AppUserId")
                    .HasColumnType("int");

                b.Property<string>("Class")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Content")
                    .HasColumnType("nvarchar(max)");

                b.Property<bool>("IsActive")
                    .HasColumnType("bit");

                b.Property<bool>("IsVisible")
                    .HasColumnType("bit");

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Title")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.HasIndex("AppUserId");

                b.ToTable("CmsPages");
            });

            modelBuilder.Entity("POS.Models.Contact", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .UseIdentityColumn();

                b.Property<int>("AppUserId")
                    .HasColumnType("int");

                b.Property<string>("Class")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("ContactInformation")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("ContactTypeId")
                    .HasColumnType("int");

                b.Property<bool>("IsActive")
                    .HasColumnType("bit");

                b.Property<bool>("IsVisible")
                    .HasColumnType("bit");

                b.HasKey("Id");

                b.HasIndex("AppUserId");

                b.HasIndex("ContactTypeId");

                b.ToTable("Contacts");
            });

            modelBuilder.Entity("POS.Models.ContactType", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .UseIdentityColumn();

                b.Property<string>("Class")
                    .HasColumnType("nvarchar(max)");

                b.Property<bool>("IsActive")
                    .HasColumnType("bit");

                b.Property<bool>("IsVisible")
                    .HasColumnType("bit");

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("ContactTypes");
            });

            modelBuilder.Entity("POS.Models.Gallery", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .UseIdentityColumn();

                b.Property<string>("Class")
                    .HasColumnType("nvarchar(max)");

                b.Property<bool>("IsActive")
                    .HasColumnType("bit");

                b.Property<bool>("IsVisible")
                    .HasColumnType("bit");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Galleries");
            });

            modelBuilder.Entity("POS.Models.GamesGroup", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .UseIdentityColumn();

                b.Property<string>("Class")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Description")
                    .HasColumnType("nvarchar(max)");

                b.Property<bool>("IsActive")
                    .HasColumnType("bit");

                b.Property<bool>("IsVisible")
                    .HasColumnType("bit");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("GamesGroups");
            });

            modelBuilder.Entity("POS.Models.Image", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .UseIdentityColumn();

                b.Property<string>("Class")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("DateTime")
                    .HasColumnType("datetime2");

                b.Property<string>("Description")
                    .HasColumnType("nvarchar(max)");

                b.Property<byte[]>("ImageDb")
                    .HasColumnType("varbinary(max)");

                b.Property<bool>("IsActive")
                    .HasColumnType("bit");

                b.Property<bool>("IsVisible")
                    .HasColumnType("bit");

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Path")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Images");
            });

            modelBuilder.Entity("POS.Models.News", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .UseIdentityColumn();

                b.Property<int>("AppUserID")
                    .HasColumnType("int");

                b.Property<string>("Class")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Content")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("Date")
                    .HasColumnType("datetime2");

                b.Property<bool>("IsActive")
                    .HasColumnType("bit");

                b.Property<bool>("IsVisible")
                    .HasColumnType("bit");

                b.Property<string>("Title")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(100)");

                b.HasKey("Id");

                b.HasIndex("AppUserID");

                b.ToTable("Newses");
            });

            modelBuilder.Entity("POS.Models.Rank", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .UseIdentityColumn();

                b.Property<string>("Class")
                    .HasColumnType("nvarchar(max)");

                b.Property<bool>("IsActive")
                    .HasColumnType("bit");

                b.Property<bool>("IsVisible")
                    .HasColumnType("bit");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Ranks");
            });

            modelBuilder.Entity("AppUserGamesGroup", b =>
            {
                b.HasOne("POS.Models.AppUser", null)
                    .WithMany()
                    .HasForeignKey("AppUsersId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("POS.Models.GamesGroup", null)
                    .WithMany()
                    .HasForeignKey("GamesGroupsId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("CMSPageImage", b =>
            {
                b.HasOne("POS.Models.CMSPage", null)
                    .WithMany()
                    .HasForeignKey("CmsPagesId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("POS.Models.Image", null)
                    .WithMany()
                    .HasForeignKey("ImagesId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("GalleryImage", b =>
            {
                b.HasOne("POS.Models.Gallery", null)
                    .WithMany()
                    .HasForeignKey("GalleriesId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("POS.Models.Image", null)
                    .WithMany()
                    .HasForeignKey("ImagesId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("GamesGroupNews", b =>
            {
                b.HasOne("POS.Models.GamesGroup", null)
                    .WithMany()
                    .HasForeignKey("GamesGroupsId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("POS.Models.News", null)
                    .WithMany()
                    .HasForeignKey("NewsesId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("ImageNews", b =>
            {
                b.HasOne("POS.Models.News", null)
                    .WithMany()
                    .HasForeignKey("BlogPostsId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("POS.Models.Image", null)
                    .WithMany()
                    .HasForeignKey("ImagesId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
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
                b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
            {
                b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
            {
                b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("POS.Models.Address", b =>
            {
                b.HasOne("POS.Models.AppUser", "AppUser")
                    .WithMany("Addresses")
                    .HasForeignKey("AppUserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("AppUser");
            });

            modelBuilder.Entity("POS.Models.AppUser", b =>
            {
                b.HasOne("POS.Models.Image", "Avatar")
                    .WithMany()
                    .HasForeignKey("AvatarId");

                b.HasOne("POS.Models.Blood", "Blood")
                    .WithMany("Bloods")
                    .HasForeignKey("BloodId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("POS.Models.Rank", "Rank")
                    .WithMany("AppUsers")
                    .HasForeignKey("RankId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Avatar");

                b.Navigation("Blood");

                b.Navigation("Rank");
            });

            modelBuilder.Entity("POS.Models.CMSPage", b =>
            {
                b.HasOne("POS.Models.AppUser", "AppUser")
                    .WithMany("CmsPages")
                    .HasForeignKey("AppUserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("AppUser");
            });

            modelBuilder.Entity("POS.Models.Contact", b =>
            {
                b.HasOne("POS.Models.AppUser", "AppUser")
                    .WithMany("Contacts")
                    .HasForeignKey("AppUserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("POS.Models.ContactType", "ContactType")
                    .WithMany()
                    .HasForeignKey("ContactTypeId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("AppUser");

                b.Navigation("ContactType");
            });

            modelBuilder.Entity("POS.Models.News", b =>
            {
                b.HasOne("POS.Models.AppUser", "AppUser")
                    .WithMany("Newses")
                    .HasForeignKey("AppUserID")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("AppUser");
            });

            modelBuilder.Entity("POS.Models.AppUser", b =>
            {
                b.Navigation("Addresses");

                b.Navigation("CmsPages");

                b.Navigation("Contacts");

                b.Navigation("Newses");
            });

            modelBuilder.Entity("POS.Models.Blood", b => { b.Navigation("Bloods"); });

            modelBuilder.Entity("POS.Models.Rank", b => { b.Navigation("AppUsers"); });
#pragma warning restore 612, 618
        }
    }

}