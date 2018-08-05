﻿// <auto-generated />
using System;
using ClippingKKModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClippingKKModel.Migrations
{
    [DbContext(typeof(ClippingContext))]
    partial class ClippingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846");

            modelBuilder.Entity("ClippingKKModel.ClippingItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<string>("Content");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Location");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.ToTable("Clippings");
                });
#pragma warning restore 612, 618
        }
    }
}
