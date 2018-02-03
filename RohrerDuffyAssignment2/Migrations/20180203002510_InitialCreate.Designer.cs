﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using RohrerDuffyAssignment2.Models;
using System;

namespace RohrerDuffyAssignment2.Migrations
{
    [DbContext(typeof(RohrerDuffyAssignment2Context))]
    [Migration("20180203002510_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RohrerDuffyAssignment2.Models.Project", b =>
                {
                    b.Property<int>("ProjectID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Activities");

                    b.Property<string>("Description");

                    b.Property<string>("Title");

                    b.HasKey("ProjectID");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("RohrerDuffyAssignment2.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Phone");

                    b.Property<string>("Project");

                    b.HasKey("ID");

                    b.ToTable("User");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("RohrerDuffyAssignment2.Models.Admin", b =>
                {
                    b.HasBaseType("RohrerDuffyAssignment2.Models.User");

                    b.Property<string>("AcademicStanding");

                    b.Property<string>("ClubTitle");

                    b.ToTable("Admin");

                    b.HasDiscriminator().HasValue("Admin");
                });

            modelBuilder.Entity("RohrerDuffyAssignment2.Models.Client", b =>
                {
                    b.HasBaseType("RohrerDuffyAssignment2.Models.User");

                    b.Property<string>("AltContact");

                    b.Property<string>("BusinessName");

                    b.Property<string>("Title");

                    b.ToTable("Client");

                    b.HasDiscriminator().HasValue("Client");
                });

            modelBuilder.Entity("RohrerDuffyAssignment2.Models.Member", b =>
                {
                    b.HasBaseType("RohrerDuffyAssignment2.Models.User");

                    b.Property<string>("AcademicStanding")
                        .HasColumnName("Member_AcademicStanding");

                    b.Property<int>("BuffID");

                    b.ToTable("Member");

                    b.HasDiscriminator().HasValue("Member");
                });
#pragma warning restore 612, 618
        }
    }
}
