﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;
using SocialQuantum.Infra.Data.Context;

#nullable disable

namespace SocialQuantum.Infra.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240421122810_novaTable")]
    partial class novaTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SocialQuantum.Domain.Entities.StatusAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("STATUS_ID");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset?>("CreationDate")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP(7) WITH TIME ZONE")
                        .HasColumnName("STATUS_CREATING_DATE");

                    b.Property<bool>("IsActive")
                        .HasColumnType("NUMBER(1)")
                        .HasColumnName("IS_ACTIVE");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("NVARCHAR2(255)")
                        .HasColumnName("NAME");

                    b.HasKey("Id");

                    b.ToTable("STATUS_ACCOUNTS", (string)null);
                });

            modelBuilder.Entity("SocialQuantum.Domain.Entities.UserProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("USER_ID");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Biography")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("NVARCHAR2(255)")
                        .HasColumnName("BIOGRAPHY");

                    b.Property<DateTimeOffset?>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP(7) WITH TIME ZONE")
                        .HasColumnName("USER_CREATING_DATE");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("NVARCHAR2(255)")
                        .HasColumnName("EMAIL");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("NVARCHAR2(255)")
                        .HasColumnName("LOCATION");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("NVARCHAR2(255)")
                        .HasColumnName("NAME");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("NVARCHAR2(255)")
                        .HasColumnName("PASSWORD");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("USER_PHOTO");

                    b.Property<int>("StatusAccountId")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("STATUS_ACCOUNT_ID");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("NVARCHAR2(255)")
                        .HasColumnName("USERNAME");

                    b.HasKey("Id");

                    b.HasIndex("StatusAccountId");

                    b.ToTable("USERS", (string)null);
                });

            modelBuilder.Entity("SocialQuantum.Domain.Entities.UserProfile", b =>
                {
                    b.HasOne("SocialQuantum.Domain.Entities.StatusAccount", "StatusAccount")
                        .WithMany("UserProfiles")
                        .HasForeignKey("StatusAccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StatusAccount");
                });

            modelBuilder.Entity("SocialQuantum.Domain.Entities.StatusAccount", b =>
                {
                    b.Navigation("UserProfiles");
                });
#pragma warning restore 612, 618
        }
    }
}
