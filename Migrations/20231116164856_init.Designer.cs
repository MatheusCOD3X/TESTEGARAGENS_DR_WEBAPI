﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TESTEGARAGENS_DR_WEBAPI.Data;

namespace TESTEGARAGENS_DR_WEBAPI.Migrations
{
    [DbContext(typeof(DAL))]
    [Migration("20231116164856_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("TESTEGARAGENS_DR_WEBAPI.Models.FormaPagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Codigo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FormasPagamento");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Codigo = "DIN",
                            Descricao = "Dinheiro"
                        },
                        new
                        {
                            Id = 2,
                            Codigo = "MEN",
                            Descricao = "Mensalista"
                        },
                        new
                        {
                            Id = 3,
                            Codigo = "PIX",
                            Descricao = "Pix"
                        },
                        new
                        {
                            Id = 4,
                            Codigo = "TAG",
                            Descricao = "Tag"
                        },
                        new
                        {
                            Id = 5,
                            Codigo = "CDE",
                            Descricao = "Cartão de Débito"
                        },
                        new
                        {
                            Id = 6,
                            Codigo = "CCR",
                            Descricao = "Cartão de Crédito"
                        });
                });

            modelBuilder.Entity("TESTEGARAGENS_DR_WEBAPI.Models.Garagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Codigo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Preco_1aHora")
                        .HasColumnType("TEXT");

                    b.Property<string>("Preco_HorasExtra")
                        .HasColumnType("TEXT");

                    b.Property<string>("Preco_Mensalista")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Garagens");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Codigo = "EVO01",
                            Nome = "Estamplaza Vila Olimpia",
                            Preco_1aHora = "40",
                            Preco_HorasExtra = "10",
                            Preco_Mensalista = "550"
                        },
                        new
                        {
                            Id = 2,
                            Codigo = "PLJK01",
                            Nome = "Plaza JK",
                            Preco_1aHora = "35",
                            Preco_HorasExtra = "12",
                            Preco_Mensalista = "380"
                        },
                        new
                        {
                            Id = 3,
                            Codigo = "SZJK01",
                            Nome = "Spazio JK",
                            Preco_1aHora = "30",
                            Preco_HorasExtra = "15",
                            Preco_Mensalista = "350"
                        },
                        new
                        {
                            Id = 4,
                            Codigo = "CSLU01",
                            Nome = "Condominio São Luiz",
                            Preco_1aHora = "50",
                            Preco_HorasExtra = "12",
                            Preco_Mensalista = "550"
                        },
                        new
                        {
                            Id = 5,
                            Codigo = "COTO01",
                            Nome = "Corporate Tower Itaim",
                            Preco_1aHora = "30",
                            Preco_HorasExtra = "12",
                            Preco_Mensalista = "360"
                        });
                });

            modelBuilder.Entity("TESTEGARAGENS_DR_WEBAPI.Models.Passagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CarroMarca")
                        .HasColumnType("TEXT");

                    b.Property<string>("CarroModelo")
                        .HasColumnType("TEXT");

                    b.Property<string>("CarroPlaca")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataHoraEntrada")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataHoraSaida")
                        .HasColumnType("TEXT");

                    b.Property<string>("FormaPagamento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Garagem")
                        .HasColumnType("TEXT");

                    b.Property<string>("PrecoTotal")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Passagens");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CarroMarca = "Honda",
                            CarroModelo = "FIT",
                            CarroPlaca = "ABC-0O12",
                            DataHoraEntrada = new DateTime(2023, 9, 4, 13, 30, 0, 0, DateTimeKind.Unspecified),
                            DataHoraSaida = new DateTime(2023, 9, 4, 15, 15, 0, 0, DateTimeKind.Unspecified),
                            FormaPagamento = "PIX",
                            Garagem = "EVO01"
                        },
                        new
                        {
                            Id = 2,
                            CarroMarca = "Toyota",
                            CarroModelo = "Yaris",
                            CarroPlaca = "DKO-3927",
                            DataHoraEntrada = new DateTime(2023, 9, 5, 8, 40, 0, 0, DateTimeKind.Unspecified),
                            DataHoraSaida = new DateTime(2023, 9, 5, 9, 55, 0, 0, DateTimeKind.Unspecified),
                            FormaPagamento = "CCR",
                            Garagem = "EVO01"
                        },
                        new
                        {
                            Id = 3,
                            CarroMarca = "Fiat",
                            CarroModelo = "Argo",
                            CarroPlaca = "SPE-9F42",
                            DataHoraEntrada = new DateTime(2023, 9, 4, 10, 15, 0, 0, DateTimeKind.Unspecified),
                            DataHoraSaida = new DateTime(2023, 9, 4, 11, 20, 0, 0, DateTimeKind.Unspecified),
                            FormaPagamento = "TAG",
                            Garagem = "EVO01"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}