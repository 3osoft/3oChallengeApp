﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using _3oChallengeDataAccess;

namespace _3oChallengeApp.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    partial class ApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("_3oChallengeDataAccess.ChallengeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedAt");

                    b.Property<string>("CreatorId")
                        .IsRequired();

                    b.Property<string>("Description");

                    b.Property<bool>("IsEnabled");

                    b.Property<string>("Title");

                    b.Property<DateTimeOffset>("UpdatedAt");

                    b.Property<DateTimeOffset>("ValidFrom");

                    b.Property<DateTimeOffset>("ValidTill");

                    b.Property<string>("WinnerCondition");

                    b.HasKey("Id");

                    b.ToTable("Challenge");
                });

            modelBuilder.Entity("_3oChallengeDataAccess.ChallengeUserModel", b =>
                {
                    b.Property<int>("ChallengeId");

                    b.Property<string>("UserId");

                    b.HasKey("ChallengeId", "UserId");

                    b.ToTable("ChallengeUser");
                });

            modelBuilder.Entity("_3oChallengeDataAccess.InputChallengeAnswerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedAt");

                    b.Property<int>("InputChallengeId");

                    b.Property<DateTimeOffset>("UpdatedAt");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.Property<string>("Value")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("InputChallengeId");

                    b.ToTable("InputChallengeAnswer");
                });

            modelBuilder.Entity("_3oChallengeDataAccess.InputChallengeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ChallengeId");

                    b.HasKey("Id");

                    b.HasIndex("ChallengeId");

                    b.ToTable("InputChallenge");
                });

            modelBuilder.Entity("_3oChallengeDataAccess.VoteChallengeAnswerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedAt");

                    b.Property<DateTimeOffset>("UpdatedAt");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.Property<string>("Value");

                    b.Property<int>("VoteChallengeItemId");

                    b.HasKey("Id");

                    b.HasIndex("VoteChallengeItemId");

                    b.ToTable("VoteChallengeAnswer");
                });

            modelBuilder.Entity("_3oChallengeDataAccess.VoteChallengeItemModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedAt");

                    b.Property<DateTimeOffset>("UpdatedAt");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.Property<string>("Value")
                        .IsRequired();

                    b.Property<int>("VoteChallengeId");

                    b.HasKey("Id");

                    b.HasIndex("VoteChallengeId");

                    b.ToTable("VoteChallengeItem");
                });

            modelBuilder.Entity("_3oChallengeDataAccess.VoteChallengeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ChallengeId");

                    b.Property<DateTimeOffset>("CreatedAt");

                    b.Property<DateTimeOffset>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("ChallengeId");

                    b.ToTable("VoteChallenge");
                });

            modelBuilder.Entity("_3oChallengeDataAccess.ChallengeUserModel", b =>
                {
                    b.HasOne("_3oChallengeDataAccess.ChallengeModel", "Challenge")
                        .WithMany("ChallengeUsers")
                        .HasForeignKey("ChallengeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("_3oChallengeDataAccess.InputChallengeAnswerModel", b =>
                {
                    b.HasOne("_3oChallengeDataAccess.InputChallengeModel", "InputChallenge")
                        .WithMany("Answers")
                        .HasForeignKey("InputChallengeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("_3oChallengeDataAccess.InputChallengeModel", b =>
                {
                    b.HasOne("_3oChallengeDataAccess.ChallengeModel", "Challenge")
                        .WithMany()
                        .HasForeignKey("ChallengeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("_3oChallengeDataAccess.VoteChallengeAnswerModel", b =>
                {
                    b.HasOne("_3oChallengeDataAccess.VoteChallengeItemModel", "VoteChallengeItem")
                        .WithMany("Answers")
                        .HasForeignKey("VoteChallengeItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("_3oChallengeDataAccess.VoteChallengeItemModel", b =>
                {
                    b.HasOne("_3oChallengeDataAccess.VoteChallengeModel", "VoteChallenge")
                        .WithMany("Items")
                        .HasForeignKey("VoteChallengeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("_3oChallengeDataAccess.VoteChallengeModel", b =>
                {
                    b.HasOne("_3oChallengeDataAccess.ChallengeModel", "Challenge")
                        .WithMany()
                        .HasForeignKey("ChallengeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
