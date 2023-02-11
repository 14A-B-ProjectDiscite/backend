﻿// <auto-generated />
using System;
using Discite.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Discite.Data.Migrations
{
    [DbContext(typeof(DisciteDbContext))]
    [Migration("20230211135804_ManyToMany")]
    partial class ManyToMany
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Discite.Data.Models.ArtifactModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("MaxLevel")
                        .HasColumnType("int")
                        .HasColumnName("upgrade_level");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("artifact");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MaxLevel = 3,
                            Name = "Flammable blood"
                        },
                        new
                        {
                            Id = 2,
                            MaxLevel = 3,
                            Name = "Poisonous blood"
                        },
                        new
                        {
                            Id = 3,
                            MaxLevel = 3,
                            Name = "Exploding corpses"
                        },
                        new
                        {
                            Id = 4,
                            MaxLevel = 3,
                            Name = "Revenge damage"
                        });
                });

            modelBuilder.Entity("Discite.Data.Models.ClassArtifactModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ArtifactId")
                        .HasColumnType("int");

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArtifactId");

                    b.HasIndex("ClassId");

                    b.ToTable("class_artifact");
                });

            modelBuilder.Entity("Discite.Data.Models.ClassModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("Damage")
                        .HasColumnType("float");

                    b.Property<float>("Energy")
                        .HasColumnType("float");

                    b.Property<float>("MaxHp")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<float>("Speed")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("class");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Damage = 5f,
                            Energy = 160f,
                            MaxHp = 70f,
                            Name = "Artificier",
                            Speed = 1f
                        },
                        new
                        {
                            Id = 2,
                            Damage = 4f,
                            Energy = 100f,
                            MaxHp = 120f,
                            Name = "Weapon Master",
                            Speed = 1f
                        },
                        new
                        {
                            Id = 3,
                            Damage = 4f,
                            Energy = 130f,
                            MaxHp = 90f,
                            Name = "Cyber Ninja",
                            Speed = 2f
                        });
                });

            modelBuilder.Entity("Discite.Data.Models.EnemyModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("Damage")
                        .HasColumnType("float");

                    b.Property<float>("Energy")
                        .HasColumnType("float");

                    b.Property<float>("MaxHp")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<float>("Speed")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("enemy");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Damage = 10f,
                            Energy = 0f,
                            MaxHp = 20f,
                            Name = "Ghoul",
                            Speed = 0.7f
                        },
                        new
                        {
                            Id = 2,
                            Damage = 25f,
                            Energy = 0f,
                            MaxHp = 5f,
                            Name = "Exploder",
                            Speed = 1f
                        },
                        new
                        {
                            Id = 3,
                            Damage = 20f,
                            Energy = 0f,
                            MaxHp = 35f,
                            Name = "Cyber Ghoul",
                            Speed = 1.5f
                        },
                        new
                        {
                            Id = 4,
                            Damage = 10f,
                            Energy = 0f,
                            MaxHp = 60f,
                            Name = "Multi-tank",
                            Speed = 0.5f
                        },
                        new
                        {
                            Id = 5,
                            Damage = 15f,
                            Energy = 0f,
                            MaxHp = 20f,
                            Name = "Agent",
                            Speed = 0.7f
                        },
                        new
                        {
                            Id = 6,
                            Damage = 15f,
                            Energy = 0f,
                            MaxHp = 200f,
                            Name = "Chimera",
                            Speed = 1.2f
                        });
                });

            modelBuilder.Entity("Discite.Data.Models.RoomModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("eventroom");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Entry room"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Exit room"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Encounter room"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Shop room"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Boss room"
                        });
                });

            modelBuilder.Entity("Discite.Data.Models.RunArtifactModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ArtifactId")
                        .HasColumnType("int");

                    b.Property<int>("Picked")
                        .HasColumnType("int");

                    b.Property<int>("RunId")
                        .HasColumnType("int");

                    b.Property<int>("Seen")
                        .HasColumnType("int");

                    b.Property<int>("Used")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArtifactId");

                    b.HasIndex("RunId");

                    b.ToTable("run_artifact");
                });

            modelBuilder.Entity("Discite.Data.Models.RunEnemyModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Damage")
                        .HasColumnType("int");

                    b.Property<int>("Deaths")
                        .HasColumnType("int");

                    b.Property<int>("EnemyId")
                        .HasColumnType("int");

                    b.Property<int>("RunId")
                        .HasColumnType("int");

                    b.Property<int>("Seen")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EnemyId");

                    b.HasIndex("RunId");

                    b.ToTable("run_enemy");
                });

            modelBuilder.Entity("Discite.Data.Models.RunModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ClassId")
                        .HasColumnType("int");

                    b.Property<float>("CurrentHp")
                        .HasColumnType("float");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("GameVersion")
                        .HasColumnType("longtext")
                        .HasColumnName("version");

                    b.Property<int>("Gold")
                        .HasColumnType("int");

                    b.Property<string>("Path")
                        .HasColumnType("longtext");

                    b.Property<int>("Runtime")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("UserId");

                    b.ToTable("run");
                });

            modelBuilder.Entity("Discite.Data.Models.RunRoomModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<int>("RunId")
                        .HasColumnType("int");

                    b.Property<int>("Seen")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.HasIndex("RunId");

                    b.ToTable("run_room");
                });

            modelBuilder.Entity("Discite.Data.Models.RunWeaponModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Picked")
                        .HasColumnType("int");

                    b.Property<int>("RunId")
                        .HasColumnType("int");

                    b.Property<int>("Seen")
                        .HasColumnType("int");

                    b.Property<int>("WeaponId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RunId");

                    b.HasIndex("WeaponId");

                    b.ToTable("run_weapon");
                });

            modelBuilder.Entity("Discite.Data.Models.UserClassModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("UserId");

                    b.ToTable("user_class");
                });

            modelBuilder.Entity("Discite.Data.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<byte[]>("Hash")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<DateTime>("LastActive")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("register_date");

                    b.Property<byte[]>("Salt")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("user");
                });

            modelBuilder.Entity("Discite.Data.Models.WeaponModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("AttackSpeed")
                        .HasColumnType("float");

                    b.Property<float>("Damage")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("weapon");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AttackSpeed = 1.5f,
                            Damage = 3f,
                            Name = "Katana"
                        },
                        new
                        {
                            Id = 2,
                            AttackSpeed = 1f,
                            Damage = 4f,
                            Name = "Spear"
                        },
                        new
                        {
                            Id = 3,
                            AttackSpeed = 0.7f,
                            Damage = 6f,
                            Name = "Deagle"
                        },
                        new
                        {
                            Id = 4,
                            AttackSpeed = 3f,
                            Damage = 1f,
                            Name = "Laser SMG"
                        },
                        new
                        {
                            Id = 5,
                            AttackSpeed = 0.5f,
                            Damage = 1f,
                            Name = "Shotgun"
                        });
                });

            modelBuilder.Entity("Discite.Data.Models.ClassArtifactModel", b =>
                {
                    b.HasOne("Discite.Data.Models.ArtifactModel", "Artifact")
                        .WithMany("Classes")
                        .HasForeignKey("ArtifactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Discite.Data.Models.ClassModel", "Class")
                        .WithMany("Artifacts")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artifact");

                    b.Navigation("Class");
                });

            modelBuilder.Entity("Discite.Data.Models.RunArtifactModel", b =>
                {
                    b.HasOne("Discite.Data.Models.ArtifactModel", "Artifact")
                        .WithMany("Runs")
                        .HasForeignKey("ArtifactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Discite.Data.Models.RunModel", "Run")
                        .WithMany("Artifacts")
                        .HasForeignKey("RunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artifact");

                    b.Navigation("Run");
                });

            modelBuilder.Entity("Discite.Data.Models.RunEnemyModel", b =>
                {
                    b.HasOne("Discite.Data.Models.EnemyModel", "Enemy")
                        .WithMany("Runs")
                        .HasForeignKey("EnemyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Discite.Data.Models.RunModel", "Run")
                        .WithMany("Enemies")
                        .HasForeignKey("RunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Enemy");

                    b.Navigation("Run");
                });

            modelBuilder.Entity("Discite.Data.Models.RunModel", b =>
                {
                    b.HasOne("Discite.Data.Models.ClassModel", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId");

                    b.HasOne("Discite.Data.Models.UserModel", "User")
                        .WithMany("Runs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Discite.Data.Models.RunRoomModel", b =>
                {
                    b.HasOne("Discite.Data.Models.RoomModel", "Room")
                        .WithMany("Runs")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Discite.Data.Models.RunModel", "Run")
                        .WithMany("Rooms")
                        .HasForeignKey("RunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");

                    b.Navigation("Run");
                });

            modelBuilder.Entity("Discite.Data.Models.RunWeaponModel", b =>
                {
                    b.HasOne("Discite.Data.Models.RunModel", "Run")
                        .WithMany("Weapons")
                        .HasForeignKey("RunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Discite.Data.Models.WeaponModel", "Weapon")
                        .WithMany("Runs")
                        .HasForeignKey("WeaponId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Run");

                    b.Navigation("Weapon");
                });

            modelBuilder.Entity("Discite.Data.Models.UserClassModel", b =>
                {
                    b.HasOne("Discite.Data.Models.ClassModel", "Class")
                        .WithMany("Users")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Discite.Data.Models.UserModel", "User")
                        .WithMany("Classes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Discite.Data.Models.ArtifactModel", b =>
                {
                    b.Navigation("Classes");

                    b.Navigation("Runs");
                });

            modelBuilder.Entity("Discite.Data.Models.ClassModel", b =>
                {
                    b.Navigation("Artifacts");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Discite.Data.Models.EnemyModel", b =>
                {
                    b.Navigation("Runs");
                });

            modelBuilder.Entity("Discite.Data.Models.RoomModel", b =>
                {
                    b.Navigation("Runs");
                });

            modelBuilder.Entity("Discite.Data.Models.RunModel", b =>
                {
                    b.Navigation("Artifacts");

                    b.Navigation("Enemies");

                    b.Navigation("Rooms");

                    b.Navigation("Weapons");
                });

            modelBuilder.Entity("Discite.Data.Models.UserModel", b =>
                {
                    b.Navigation("Classes");

                    b.Navigation("Runs");
                });

            modelBuilder.Entity("Discite.Data.Models.WeaponModel", b =>
                {
                    b.Navigation("Runs");
                });
#pragma warning restore 612, 618
        }
    }
}
