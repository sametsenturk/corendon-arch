﻿// <auto-generated />
using System;
using Corendon.Entity.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Corendon.Entity.Migrations
{
    [DbContext(typeof(CorendonDbContext))]
    [Migration("20231007122818_initial-fix")]
    partial class initialfix
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Corendon.Data.Entity.Concrate.Announcement.AnnouncementEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AnnouncementType")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedUserId")
                        .HasColumnType("int");

                    b.Property<string>("PicturePath")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("Announcements");
                });

            modelBuilder.Entity("Corendon.Data.Entity.Concrate.Company.CompanyDepartmentEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("Id");

                    b.ToTable("CompanyDepartments");
                });

            modelBuilder.Entity("Corendon.Data.Entity.Concrate.Company.CompanyEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Corendon.Data.Entity.Concrate.User.UserAnnouncementCommentEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AnnouncementId")
                        .HasColumnType("int");

                    b.Property<int?>("CommentId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AnnouncementId");

                    b.HasIndex("CommentId");

                    b.HasIndex("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserAnnouncementComments");
                });

            modelBuilder.Entity("Corendon.Data.Entity.Concrate.User.UserAnnouncementVoteEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AnnouncementId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("VoteType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AnnouncementId");

                    b.HasIndex("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserAnnouncementVotes");
                });

            modelBuilder.Entity("Corendon.Data.Entity.Concrate.User.UserEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<bool>("IsLocked")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PicturePath")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("Email");

                    b.HasIndex("Id");

                    b.HasIndex("Username");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Corendon.Data.Entity.Concrate.User.UserNotificationEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AnnouncementId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AnnouncementId");

                    b.HasIndex("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserNotifications");
                });

            modelBuilder.Entity("Corendon.Data.Entity.Concrate.Company.CompanyDepartmentEntity", b =>
                {
                    b.HasOne("Corendon.Data.Entity.Concrate.Company.CompanyEntity", "Company")
                        .WithMany("CompanyDepartments")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Corendon.Data.Entity.Concrate.User.UserAnnouncementCommentEntity", b =>
                {
                    b.HasOne("Corendon.Data.Entity.Concrate.Announcement.AnnouncementEntity", "Announcement")
                        .WithMany("UserAnnouncementComments")
                        .HasForeignKey("AnnouncementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Corendon.Data.Entity.Concrate.User.UserAnnouncementCommentEntity", "Comment")
                        .WithMany()
                        .HasForeignKey("CommentId");

                    b.HasOne("Corendon.Data.Entity.Concrate.User.UserEntity", "User")
                        .WithMany("UserAnnouncementComments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Announcement");

                    b.Navigation("Comment");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Corendon.Data.Entity.Concrate.User.UserAnnouncementVoteEntity", b =>
                {
                    b.HasOne("Corendon.Data.Entity.Concrate.Announcement.AnnouncementEntity", "Announcement")
                        .WithMany("UserAnnouncementVotes")
                        .HasForeignKey("AnnouncementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Corendon.Data.Entity.Concrate.User.UserEntity", "User")
                        .WithMany("UserAnnouncementVotes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Announcement");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Corendon.Data.Entity.Concrate.User.UserEntity", b =>
                {
                    b.HasOne("Corendon.Data.Entity.Concrate.Company.CompanyDepartmentEntity", "CompanyDepartment")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CompanyDepartment");
                });

            modelBuilder.Entity("Corendon.Data.Entity.Concrate.User.UserNotificationEntity", b =>
                {
                    b.HasOne("Corendon.Data.Entity.Concrate.Announcement.AnnouncementEntity", "Announcement")
                        .WithMany("UserNotifications")
                        .HasForeignKey("AnnouncementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Corendon.Data.Entity.Concrate.User.UserEntity", "User")
                        .WithMany("UserNotifications")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Announcement");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Corendon.Data.Entity.Concrate.Announcement.AnnouncementEntity", b =>
                {
                    b.Navigation("UserAnnouncementComments");

                    b.Navigation("UserAnnouncementVotes");

                    b.Navigation("UserNotifications");
                });

            modelBuilder.Entity("Corendon.Data.Entity.Concrate.Company.CompanyEntity", b =>
                {
                    b.Navigation("CompanyDepartments");
                });

            modelBuilder.Entity("Corendon.Data.Entity.Concrate.User.UserEntity", b =>
                {
                    b.Navigation("UserAnnouncementComments");

                    b.Navigation("UserAnnouncementVotes");

                    b.Navigation("UserNotifications");
                });
#pragma warning restore 612, 618
        }
    }
}
