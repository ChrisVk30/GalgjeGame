﻿// <auto-generated />
using System;
using GalgjeGame.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

#nullable disable

namespace GalgjeGame.Migrations
{
    [DbContext(typeof(GalgjeContext))]
    partial class GalgjeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GalgjeGame.Core.UserGameScore", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"), 1L, 1);

                    b.Property<int>("IncorrectGuesses")
                        .HasColumnType("int");

                    b.Property<TimeSpan?>("TimeElapsed")
                        .HasColumnType("time");

                    b.Property<DateTime?>("TimeFinished")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("TimeStarted")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.HasIndex("UserName");

                    b.ToTable("UserGameScores");
                });

            modelBuilder.Entity("GalgjeGame.Core.UserOverallScore", b =>
                {
                    b.Property<long>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("PlayerId"), 1L, 1);

                    b.Property<int>("WordsGuessed")
                        .HasColumnType("int");

                    b.HasKey("PlayerId");

                    b.ToTable("UserOverallScores");
                });

            modelBuilder.Entity("GalgjeGame.Core.Word", b =>
                {
                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Value");

                    b.ToTable("WordsToBeGuessed", (string)null);
                });

            modelBuilder.Entity("GalgjeGame.Core.UserGameScore", b =>
                {
                    b.HasOne("GalgjeGame.Core.UserOverallScore", "userOverallScore")
                        .WithMany("userGameScores")
                        .HasForeignKey("UserName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("userOverallScore");
                });

            modelBuilder.Entity("GalgjeGame.Core.UserOverallScore", b =>
                {
                    b.Navigation("userGameScores");
                });
#pragma warning restore 612, 618
        }
    }
}
