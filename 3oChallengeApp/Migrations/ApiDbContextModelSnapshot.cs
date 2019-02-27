﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using _3oChallenge;

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

            modelBuilder.Entity("_3oChallengeApp.Models.Challenge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<bool>("IsEnabled");

                    b.Property<string>("Title");

                    b.Property<DateTimeOffset>("UpdatedAt");

                    b.Property<int?>("UserId");

                    b.Property<DateTimeOffset>("ValidFrom");

                    b.Property<DateTimeOffset>("ValidTill");

                    b.Property<string>("WinnerCondition");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Challenges");
                });

            modelBuilder.Entity("_3oChallengeApp.Models.Entities.ChallengeUser", b =>
                {
                    b.Property<int>("ChallengeId");

                    b.Property<int>("UserId");

                    b.HasKey("ChallengeId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("ChallengeUser");
                });

            modelBuilder.Entity("_3oChallengeApp.Models.Entities.InputChallenge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ChallengeId");

                    b.Property<DateTimeOffset>("CreatedAt");

                    b.Property<DateTimeOffset>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("ChallengeId");

                    b.ToTable("InputChallenges");
                });

            modelBuilder.Entity("_3oChallengeApp.Models.Entities.InputChallengeAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedAt");

                    b.Property<int?>("InputChallengeId");

                    b.Property<DateTimeOffset>("UpdatedAt");

                    b.Property<int?>("UserId");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("InputChallengeId");

                    b.HasIndex("UserId");

                    b.ToTable("InputChallengeAnswers");
                });

            modelBuilder.Entity("_3oChallengeApp.Models.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedAt");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsActive");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<string>("Photo");

                    b.Property<DateTimeOffset>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("_3oChallengeApp.Models.Entities.VoteChallenge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ChallengeId");

                    b.Property<DateTimeOffset>("CreatedAt");

                    b.Property<DateTimeOffset>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("ChallengeId");

                    b.ToTable("VoteChallenges");
                });

            modelBuilder.Entity("_3oChallengeApp.Models.Entities.VoteChallengeAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedAt");

                    b.Property<DateTimeOffset>("UpdatedAt");

                    b.Property<int?>("UserId");

                    b.Property<string>("Value");

                    b.Property<int?>("VoteChallengeItemId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("VoteChallengeItemId");

                    b.ToTable("VoteChallengeAnswers");
                });

            modelBuilder.Entity("_3oChallengeApp.Models.Entities.VoteChallengeItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedAt");

                    b.Property<DateTimeOffset>("UpdatedAt");

                    b.Property<int?>("UserId");

                    b.Property<string>("Value");

                    b.Property<int?>("VoteChallengeId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("VoteChallengeId");

                    b.ToTable("VoteChallengeItems");
                });

            modelBuilder.Entity("_3oChallengeApp.Models.Challenge", b =>
                {
                    b.HasOne("_3oChallengeApp.Models.Entities.User")
                        .WithMany("Challenges")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("_3oChallengeApp.Models.Entities.ChallengeUser", b =>
                {
                    b.HasOne("_3oChallengeApp.Models.Challenge", "Challenge")
                        .WithMany("ChallengeUsers")
                        .HasForeignKey("ChallengeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("_3oChallengeApp.Models.Entities.User", "User")
                        .WithMany("ChallengeUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("_3oChallengeApp.Models.Entities.InputChallenge", b =>
                {
                    b.HasOne("_3oChallengeApp.Models.Challenge", "Challenge")
                        .WithMany()
                        .HasForeignKey("ChallengeId");
                });

            modelBuilder.Entity("_3oChallengeApp.Models.Entities.InputChallengeAnswer", b =>
                {
                    b.HasOne("_3oChallengeApp.Models.Entities.InputChallenge")
                        .WithMany("Answers")
                        .HasForeignKey("InputChallengeId");

                    b.HasOne("_3oChallengeApp.Models.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("_3oChallengeApp.Models.Entities.VoteChallenge", b =>
                {
                    b.HasOne("_3oChallengeApp.Models.Challenge", "Challenge")
                        .WithMany()
                        .HasForeignKey("ChallengeId");
                });

            modelBuilder.Entity("_3oChallengeApp.Models.Entities.VoteChallengeAnswer", b =>
                {
                    b.HasOne("_3oChallengeApp.Models.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.HasOne("_3oChallengeApp.Models.Entities.VoteChallengeItem")
                        .WithMany("Answers")
                        .HasForeignKey("VoteChallengeItemId");
                });

            modelBuilder.Entity("_3oChallengeApp.Models.Entities.VoteChallengeItem", b =>
                {
                    b.HasOne("_3oChallengeApp.Models.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.HasOne("_3oChallengeApp.Models.Entities.VoteChallenge")
                        .WithMany("Items")
                        .HasForeignKey("VoteChallengeId");
                });
#pragma warning restore 612, 618
        }
    }
}
