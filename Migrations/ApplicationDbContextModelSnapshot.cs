﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WeatherForecast.DB;

namespace WeatherForecast.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WeatherForecast.DB.WeatherForecast", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TemperatureC")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("WeatherForecasts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2023, 11, 14, 17, 10, 25, 91, DateTimeKind.Local).AddTicks(9206),
                            Summary = "Mild",
                            TemperatureC = 38
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2023, 11, 10, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6035),
                            Summary = "Freezing",
                            TemperatureC = 9
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2023, 11, 9, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6070),
                            Summary = "Balmy",
                            TemperatureC = 47
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2023, 11, 2, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6075),
                            Summary = "Cool",
                            TemperatureC = 27
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateTime(2023, 11, 13, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6077),
                            Summary = "Freezing",
                            TemperatureC = 31
                        },
                        new
                        {
                            Id = 6,
                            Date = new DateTime(2023, 12, 8, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6080),
                            Summary = "Bracing",
                            TemperatureC = -13
                        },
                        new
                        {
                            Id = 7,
                            Date = new DateTime(2023, 11, 16, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6192),
                            Summary = "Balmy",
                            TemperatureC = 39
                        },
                        new
                        {
                            Id = 8,
                            Date = new DateTime(2023, 11, 13, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6196),
                            Summary = "Hot",
                            TemperatureC = 26
                        },
                        new
                        {
                            Id = 9,
                            Date = new DateTime(2023, 12, 7, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6199),
                            Summary = "Mild",
                            TemperatureC = -10
                        },
                        new
                        {
                            Id = 10,
                            Date = new DateTime(2023, 11, 20, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6205),
                            Summary = "Sweltering",
                            TemperatureC = 16
                        },
                        new
                        {
                            Id = 11,
                            Date = new DateTime(2023, 11, 22, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6208),
                            Summary = "Hot",
                            TemperatureC = 9
                        },
                        new
                        {
                            Id = 12,
                            Date = new DateTime(2023, 11, 25, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6211),
                            Summary = "Chilly",
                            TemperatureC = 26
                        },
                        new
                        {
                            Id = 13,
                            Date = new DateTime(2023, 11, 15, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6214),
                            Summary = "Hot",
                            TemperatureC = 20
                        },
                        new
                        {
                            Id = 14,
                            Date = new DateTime(2023, 11, 8, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6217),
                            Summary = "Sweltering",
                            TemperatureC = -16
                        },
                        new
                        {
                            Id = 15,
                            Date = new DateTime(2023, 11, 13, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6219),
                            Summary = "Chilly",
                            TemperatureC = -13
                        },
                        new
                        {
                            Id = 16,
                            Date = new DateTime(2023, 11, 18, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6222),
                            Summary = "Hot",
                            TemperatureC = 51
                        },
                        new
                        {
                            Id = 17,
                            Date = new DateTime(2023, 11, 4, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6224),
                            Summary = "Hot",
                            TemperatureC = 2
                        },
                        new
                        {
                            Id = 18,
                            Date = new DateTime(2023, 11, 26, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6226),
                            Summary = "Cool",
                            TemperatureC = -20
                        },
                        new
                        {
                            Id = 19,
                            Date = new DateTime(2023, 11, 23, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6229),
                            Summary = "Bracing",
                            TemperatureC = -18
                        },
                        new
                        {
                            Id = 20,
                            Date = new DateTime(2023, 11, 28, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6231),
                            Summary = "Chilly",
                            TemperatureC = 4
                        },
                        new
                        {
                            Id = 21,
                            Date = new DateTime(2023, 11, 26, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6234),
                            Summary = "Mild",
                            TemperatureC = 35
                        },
                        new
                        {
                            Id = 22,
                            Date = new DateTime(2023, 12, 5, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6237),
                            Summary = "Chilly",
                            TemperatureC = 16
                        },
                        new
                        {
                            Id = 23,
                            Date = new DateTime(2023, 11, 26, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6239),
                            Summary = "Freezing",
                            TemperatureC = 32
                        },
                        new
                        {
                            Id = 24,
                            Date = new DateTime(2023, 12, 5, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6241),
                            Summary = "Warm",
                            TemperatureC = 24
                        },
                        new
                        {
                            Id = 25,
                            Date = new DateTime(2023, 11, 18, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6244),
                            Summary = "Hot",
                            TemperatureC = -6
                        },
                        new
                        {
                            Id = 26,
                            Date = new DateTime(2023, 12, 3, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6246),
                            Summary = "Warm",
                            TemperatureC = 54
                        },
                        new
                        {
                            Id = 27,
                            Date = new DateTime(2023, 11, 20, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6249),
                            Summary = "Bracing",
                            TemperatureC = 14
                        },
                        new
                        {
                            Id = 28,
                            Date = new DateTime(2023, 11, 30, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6251),
                            Summary = "Bracing",
                            TemperatureC = 10
                        },
                        new
                        {
                            Id = 29,
                            Date = new DateTime(2023, 11, 4, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6254),
                            Summary = "Cool",
                            TemperatureC = 48
                        },
                        new
                        {
                            Id = 30,
                            Date = new DateTime(2023, 11, 19, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6257),
                            Summary = "Warm",
                            TemperatureC = -17
                        },
                        new
                        {
                            Id = 31,
                            Date = new DateTime(2023, 11, 4, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6260),
                            Summary = "Chilly",
                            TemperatureC = 30
                        },
                        new
                        {
                            Id = 32,
                            Date = new DateTime(2023, 11, 23, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6262),
                            Summary = "Cool",
                            TemperatureC = 21
                        },
                        new
                        {
                            Id = 33,
                            Date = new DateTime(2023, 11, 18, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6265),
                            Summary = "Balmy",
                            TemperatureC = 14
                        },
                        new
                        {
                            Id = 34,
                            Date = new DateTime(2023, 11, 4, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6268),
                            Summary = "Chilly",
                            TemperatureC = 40
                        },
                        new
                        {
                            Id = 35,
                            Date = new DateTime(2023, 11, 28, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6270),
                            Summary = "Hot",
                            TemperatureC = -4
                        },
                        new
                        {
                            Id = 36,
                            Date = new DateTime(2023, 11, 9, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6272),
                            Summary = "Sweltering",
                            TemperatureC = -5
                        },
                        new
                        {
                            Id = 37,
                            Date = new DateTime(2023, 11, 25, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6274),
                            Summary = "Freezing",
                            TemperatureC = 36
                        },
                        new
                        {
                            Id = 38,
                            Date = new DateTime(2023, 11, 27, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6277),
                            Summary = "Sweltering",
                            TemperatureC = -6
                        },
                        new
                        {
                            Id = 39,
                            Date = new DateTime(2023, 11, 4, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6279),
                            Summary = "Cool",
                            TemperatureC = 47
                        },
                        new
                        {
                            Id = 40,
                            Date = new DateTime(2023, 11, 11, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6282),
                            Summary = "Warm",
                            TemperatureC = 37
                        },
                        new
                        {
                            Id = 41,
                            Date = new DateTime(2023, 12, 6, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6284),
                            Summary = "Balmy",
                            TemperatureC = -9
                        },
                        new
                        {
                            Id = 42,
                            Date = new DateTime(2023, 11, 20, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6286),
                            Summary = "Scorching",
                            TemperatureC = 37
                        },
                        new
                        {
                            Id = 43,
                            Date = new DateTime(2023, 11, 16, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6289),
                            Summary = "Balmy",
                            TemperatureC = 45
                        },
                        new
                        {
                            Id = 44,
                            Date = new DateTime(2023, 11, 18, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6291),
                            Summary = "Warm",
                            TemperatureC = 8
                        },
                        new
                        {
                            Id = 45,
                            Date = new DateTime(2023, 12, 8, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6294),
                            Summary = "Balmy",
                            TemperatureC = 11
                        },
                        new
                        {
                            Id = 46,
                            Date = new DateTime(2023, 12, 10, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6296),
                            Summary = "Bracing",
                            TemperatureC = -17
                        },
                        new
                        {
                            Id = 47,
                            Date = new DateTime(2023, 11, 20, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6308),
                            Summary = "Balmy",
                            TemperatureC = 45
                        },
                        new
                        {
                            Id = 48,
                            Date = new DateTime(2023, 11, 25, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6310),
                            Summary = "Chilly",
                            TemperatureC = 44
                        },
                        new
                        {
                            Id = 49,
                            Date = new DateTime(2023, 11, 23, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6313),
                            Summary = "Mild",
                            TemperatureC = 12
                        },
                        new
                        {
                            Id = 50,
                            Date = new DateTime(2023, 11, 16, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6316),
                            Summary = "Balmy",
                            TemperatureC = 15
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
