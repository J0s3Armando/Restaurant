using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Restaurant.Entity;

namespace Restaurant.DAL;

public partial class RestaurantContext : DbContext
{
    public RestaurantContext()
    {
    }

    public RestaurantContext(DbContextOptions<RestaurantContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<CategoryIngredient> CategoryIngredients { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Image> Images { get; set; }

    public virtual DbSet<Ingredient> Ingredients { get; set; }

    public virtual DbSet<MethodPayment> MethodPayments { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderProduct> OrderProducts { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<Setting> Settings { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<TableBranch> TableBranches { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Via> Via { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Branch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Branch__3214EC27D098EEBE");

            entity.ToTable("Branch");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Address)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Idcompany).HasColumnName("IDCompany");
            entity.Property(e => e.Idcountry).HasColumnName("IDCountry");
            entity.Property(e => e.Idstate).HasColumnName("IDState");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PostalCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RemoveDate).HasColumnType("datetime");
            entity.Property(e => e.Telephone)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.IdcompanyNavigation).WithMany(p => p.Branches)
                .HasForeignKey(d => d.Idcompany)
                .HasConstraintName("FK__Branch__IDCompan__3D5E1FD2");

            entity.HasOne(d => d.IdcountryNavigation).WithMany(p => p.Branches)
                .HasForeignKey(d => d.Idcountry)
                .HasConstraintName("FK__Branch__IDCountr__3E52440B");

            entity.HasOne(d => d.IdstateNavigation).WithMany(p => p.Branches)
                .HasForeignKey(d => d.Idstate)
                .HasConstraintName("FK__Branch__IDState__3F466844");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Category__3214EC2751CDFFB8");

            entity.ToTable("Category");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RemoveDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CategoryIngredient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Category__3214EC27C264312E");

            entity.ToTable("CategoryIngredient");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idcategory).HasColumnName("IDCategory");
            entity.Property(e => e.Idingredient).HasColumnName("IDIngredient");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastUpDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RemoveDate).HasColumnType("datetime");

            entity.HasOne(d => d.IdcategoryNavigation).WithMany(p => p.CategoryIngredients)
                .HasForeignKey(d => d.Idcategory)
                .HasConstraintName("FK__CategoryI__IDCat__5629CD9C");

            entity.HasOne(d => d.IdingredientNavigation).WithMany(p => p.CategoryIngredients)
                .HasForeignKey(d => d.Idingredient)
                .HasConstraintName("FK__CategoryI__IDIng__571DF1D5");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Company__3214EC2744760EE4");

            entity.ToTable("Company");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastUpDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Logo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RemoveDate).HasColumnType("datetime");
            entity.Property(e => e.Urllogo)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("URLLogo");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Country__3214EC27EE4AD713");

            entity.ToTable("Country");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Abbreviation)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RemoveDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Image>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Image__3214EC27980BFD98");

            entity.ToTable("Image");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idproduct).HasColumnName("IDProduct");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RemoveDate).HasColumnType("datetime");
            entity.Property(e => e.Url)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("URL");

            entity.HasOne(d => d.IdproductNavigation).WithMany(p => p.Images)
                .HasForeignKey(d => d.Idproduct)
                .HasConstraintName("FK__Image__IDProduct__619B8048");
        });

        modelBuilder.Entity<Ingredient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ingredie__3214EC27705E4136");

            entity.ToTable("Ingredient");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastUpDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.RemoveDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<MethodPayment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MethodPa__3214EC278D550278");

            entity.ToTable("MethodPayment");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastUpDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.RemoveDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Orders__3214EC272396E2BD");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CancelDate).HasColumnType("datetime");
            entity.Property(e => e.IdmethodPayment).HasColumnName("IDMethodPayment");
            entity.Property(e => e.Idstatus).HasColumnName("IDStatus");
            entity.Property(e => e.IdtableBranch).HasColumnName("IDTableBranch");
            entity.Property(e => e.Iduser).HasColumnName("IDUser");
            entity.Property(e => e.Idvia).HasColumnName("IDVia");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastUpDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.IdmethodPaymentNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdmethodPayment)
                .HasConstraintName("FK__Orders__IDMethod__6A30C649");

            entity.HasOne(d => d.IdstatusNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.Idstatus)
                .HasConstraintName("FK__Orders__IDStatus__6D0D32F4");

            entity.HasOne(d => d.IdtableBranchNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdtableBranch)
                .HasConstraintName("FK__Orders__IDTableB__6B24EA82");

            entity.HasOne(d => d.IduserNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.Iduser)
                .HasConstraintName("FK__Orders__IDUser__6E01572D");

            entity.HasOne(d => d.IdviaNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.Idvia)
                .HasConstraintName("FK__Orders__IDVia__6C190EBB");
        });

        modelBuilder.Entity<OrderProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OrderPro__3214EC2724670913");

            entity.ToTable("OrderProduct");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CancelDate).HasColumnType("datetime");
            entity.Property(e => e.Idcategory).HasColumnName("IDCategory");
            entity.Property(e => e.Idorder).HasColumnName("IDOrder");
            entity.Property(e => e.Idproduct).HasColumnName("IDProduct");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastUpDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Quantity).HasDefaultValueSql("((1))");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.IdcategoryNavigation).WithMany(p => p.OrderProducts)
                .HasForeignKey(d => d.Idcategory)
                .HasConstraintName("FK__OrderProd__IDCat__74AE54BC");

            entity.HasOne(d => d.IdorderNavigation).WithMany(p => p.OrderProducts)
                .HasForeignKey(d => d.Idorder)
                .HasConstraintName("FK__OrderProd__IDOrd__72C60C4A");

            entity.HasOne(d => d.IdproductNavigation).WithMany(p => p.OrderProducts)
                .HasForeignKey(d => d.Idproduct)
                .HasConstraintName("FK__OrderProd__IDPro__75A278F5");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Product__3214EC275EE6AD61");

            entity.ToTable("Product");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BasePrice).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.HightPrice).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Idcategory).HasColumnName("IDCategory");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastUpDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RemoveDate).HasColumnType("datetime");
            entity.Property(e => e.SalePrice).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.IdcategoryNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.Idcategory)
                .HasConstraintName("FK__Product__IDCateg__5BE2A6F2");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Rol__3214EC2714DC2E70");

            entity.ToTable("Rol");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Setting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Setting__3214EC27E8324C13");

            entity.ToTable("Setting");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Property)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Resource)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Value)
                .HasMaxLength(300)
                .IsUnicode(false);
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__State__3214EC27559D07B6");

            entity.ToTable("State");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Abbreviation)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Idcountry).HasColumnName("IDCountry");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RemoveDate).HasColumnType("datetime");

            entity.HasOne(d => d.IdcountryNavigation).WithMany(p => p.States)
                .HasForeignKey(d => d.Idcountry)
                .HasConstraintName("FK__State__IDCountry__38996AB5");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Status__3214EC2732E4AD8E");

            entity.ToTable("Status");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TableBranch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TableBra__3214EC27EA421733");

            entity.ToTable("TableBranch");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idbranch).HasColumnName("IDBranch");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RemoveDate).HasColumnType("datetime");

            entity.HasOne(d => d.IdbranchNavigation).WithMany(p => p.TableBranches)
                .HasForeignKey(d => d.Idbranch)
                .HasConstraintName("FK__TableBran__IDBra__440B1D61");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC2753090771");

            entity.HasIndex(e => e.Name, "UQ__Users__737584F607BABCE0").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__Users__A9D10534EAF09A59").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Address)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.BirthDate).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Idcountry).HasColumnName("IDCountry");
            entity.Property(e => e.Idrol).HasColumnName("IDRol");
            entity.Property(e => e.Idstate).HasColumnName("IDState");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Photo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PostalCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Telephone)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Urlphoto)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("URLPhoto");

            entity.HasOne(d => d.IdcountryNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.Idcountry)
                .HasConstraintName("FK__Users__IDCountry__4BAC3F29");

            entity.HasOne(d => d.IdrolNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.Idrol)
                .HasConstraintName("FK__Users__IDRol__4AB81AF0");

            entity.HasOne(d => d.IdstateNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.Idstate)
                .HasConstraintName("FK__Users__IDState__4CA06362");
        });

        modelBuilder.Entity<Via>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Via__3214EC278C2532BF");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
