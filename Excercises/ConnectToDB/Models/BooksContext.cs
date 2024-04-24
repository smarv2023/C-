using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ConnectToDB.Models;

public partial class BooksContext : DbContext
{
    public BooksContext()
    {
    }

    public BooksContext(DbContextOptions<BooksContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<AddressBook> AddressBooks { get; set; }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<AuthorIsbn> AuthorIsbns { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Title> Titles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=Books;Integrated Security=True;Trusted_Connection=True;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.AddressId).HasName("PK__Addresse__091C2A1B611773EC");

            entity.Property(e => e.AddressId).HasColumnName("AddressID");
            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AddressBook>(entity =>
        {
            entity.HasKey(e => e.AddressId);

            entity.Property(e => e.AddressId).HasColumnName("AddressID");
            entity.Property(e => e.City)
                .HasMaxLength(30)
                .IsFixedLength();
            entity.Property(e => e.FirstName)
                .HasMaxLength(30)
                .IsFixedLength();
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .IsFixedLength();
            entity.Property(e => e.State)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.Street)
                .HasMaxLength(150)
                .IsFixedLength();
            entity.Property(e => e.Zip)
                .HasMaxLength(5)
                .IsFixedLength();
        });

        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.AuthorId).HasName("PK__authors__8E2731D9FE1EFCD6");

            entity.ToTable("authors");

            entity.Property(e => e.AuthorId).HasColumnName("authorID");
            entity.Property(e => e.FirstName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("firstName");
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("lastName");
        });

        modelBuilder.Entity<AuthorIsbn>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("authorISBN");

            entity.Property(e => e.AuthorId).HasColumnName("authorID");
            entity.Property(e => e.Isbn)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("isbn");

            entity.HasOne(d => d.Author).WithMany()
                .HasForeignKey(d => d.AuthorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__authorISB__autho__3A81B327");

            entity.HasOne(d => d.IsbnNavigation).WithMany()
                .HasForeignKey(d => d.Isbn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__authorISBN__isbn__3B75D760");
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.ToTable("books");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Author)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("author");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.PublicationYear).HasColumnName("publication_year");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("title");
        });

        modelBuilder.Entity<Title>(entity =>
        {
            entity.HasKey(e => e.Isbn).HasName("PK__titles__99F9D0A5BF052840");

            entity.ToTable("titles");

            entity.Property(e => e.Isbn)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("isbn");
            entity.Property(e => e.Copyright)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("copyright");
            entity.Property(e => e.EditionNumber).HasColumnName("editionNumber");
            entity.Property(e => e.Title1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("title");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
