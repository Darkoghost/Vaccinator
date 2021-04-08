﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vaccinator.Models;

namespace Vaccinator.Migrations
{
    [DbContext(typeof(ContexteBDD))]
    [Migration("20210408140315_Ajout_Personne_et_Vaccin")]
    partial class Ajout_Personne_et_Vaccin
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("Vaccinator.Models.Personne", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateDeNaissance")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Sexe")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("TEXT");

                    b.Property<bool>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Personne");
                });

            modelBuilder.Entity("Vaccinator.Models.Vaccin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateRappel")
                        .HasColumnType("TEXT");

                    b.Property<string>("Marque")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("NumLot")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PersonneId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TypeVaccin")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("PersonneId");

                    b.ToTable("Vaccin");
                });

            modelBuilder.Entity("Vaccinator.Models.Vaccin", b =>
                {
                    b.HasOne("Vaccinator.Models.Personne", "Personne")
                        .WithMany("Vaccins")
                        .HasForeignKey("PersonneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personne");
                });

            modelBuilder.Entity("Vaccinator.Models.Personne", b =>
                {
                    b.Navigation("Vaccins");
                });
#pragma warning restore 612, 618
        }
    }
}