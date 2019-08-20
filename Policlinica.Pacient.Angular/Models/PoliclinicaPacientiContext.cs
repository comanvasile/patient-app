using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Policlinica.Pacient.Angular.Models
{
    public partial class PoliclinicaPacientiContext : DbContext
    {
        public PoliclinicaPacientiContext()
        {
        }

        public PoliclinicaPacientiContext(DbContextOptions<PoliclinicaPacientiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Adresa> Adresa { get; set; }
        public virtual DbSet<AsistentMedical> AsistentMedical { get; set; }
        public virtual DbSet<BonuriFiscale> BonuriFiscale { get; set; }
        public virtual DbSet<Departament> Departament { get; set; }
        public virtual DbSet<FunctiiDepartament> FunctiiDepartament { get; set; }
        public virtual DbSet<LoginPacient> LoginPacient { get; set; }
        public virtual DbSet<LoginUser> LoginUser { get; set; }
        public virtual DbSet<Medic> Medic { get; set; }
        public virtual DbSet<MedicSpecialitati> MedicSpecialitati { get; set; }
        public virtual DbSet<OrarUnitateMedicala> OrarUnitateMedicala { get; set; }
        public virtual DbSet<OrarUtilizatori> OrarUtilizatori { get; set; }
        public virtual DbSet<Pacient> Pacient { get; set; }
        public virtual DbSet<ProceduriMedic> ProceduriMedic { get; set; }
        public virtual DbSet<ProgramariServicii> ProgramariServicii { get; set; }
        public virtual DbSet<RaportMedical> RaportMedical { get; set; }
        public virtual DbSet<Roluri> Roluri { get; set; }
        public virtual DbSet<ServiciiMedicale> ServiciiMedicale { get; set; }
        public virtual DbSet<SpecialitateServicii> SpecialitateServicii { get; set; }
        public virtual DbSet<Specialitati> Specialitati { get; set; }
        public virtual DbSet<UnitateMedicala> UnitateMedicala { get; set; }
        public virtual DbSet<Utilizatori> Utilizatori { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=BOGDANROBITE\\SQLEXPRESS;Database=PoliclinicaPacienti;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adresa>(entity =>
            {
                entity.HasKey(e => e.FkUnitateMedicalaId)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkUnitateMedicalaId)
                    .HasName("UQ__Adresa__CAC93B30FE4CC903")
                    .IsUnique();

                entity.Property(e => e.FkUnitateMedicalaId)
                    .HasColumnName("Fk_UnitateMedicalaId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Adresa1)
                    .HasColumnName("Adresa")
                    .HasMaxLength(255);

                entity.Property(e => e.Judet)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Localitate)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Numar)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.FkUnitateMedicala)
                    .WithOne(p => p.Adresa)
                    .HasForeignKey<Adresa>(d => d.FkUnitateMedicalaId)
                    .HasConstraintName("FK__Adresa__Fk_Unita__1367E606");
            });

            modelBuilder.Entity<AsistentMedical>(entity =>
            {
                entity.HasKey(e => e.FkUtilizatorId)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkUtilizatorId)
                    .HasName("UQ__Asistent__7F5FC7757BEF99E9")
                    .IsUnique();

                entity.Property(e => e.FkUtilizatorId)
                    .HasColumnName("Fk_UtilizatorId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.FkUtilizator)
                    .WithOne(p => p.AsistentMedical)
                    .HasForeignKey<AsistentMedical>(d => d.FkUtilizatorId)
                    .HasConstraintName("FK__AsistentM__Fk_Ut__36B12243");
            });

            modelBuilder.Entity<BonuriFiscale>(entity =>
            {
                entity.HasKey(e => e.BonFiscalId);

                entity.Property(e => e.DataEmitere).HasColumnType("datetime");

                entity.Property(e => e.FkProgramareId).HasColumnName("Fk_ProgramareId");

                entity.HasOne(d => d.FkProgramare)
                    .WithMany(p => p.BonuriFiscale)
                    .HasForeignKey(d => d.FkProgramareId)
                    .HasConstraintName("FK__BonuriFis__Fk_Pr__403A8C7D");
            });

            modelBuilder.Entity<Departament>(entity =>
            {
                entity.Property(e => e.Nume).IsRequired();
            });

            modelBuilder.Entity<FunctiiDepartament>(entity =>
            {
                entity.HasKey(e => e.FunctieId);

                entity.Property(e => e.FkDepartamentId).HasColumnName("Fk_DepartamentId");

                entity.Property(e => e.Functie).HasMaxLength(255);

                entity.HasOne(d => d.FkDepartament)
                    .WithMany(p => p.FunctiiDepartament)
                    .HasForeignKey(d => d.FkDepartamentId)
                    .HasConstraintName("FK__FunctiiDe__Fk_De__1B0907CE");
            });

            modelBuilder.Entity<LoginPacient>(entity =>
            {
                entity.HasKey(e => e.FkPacientId);

                entity.Property(e => e.FkPacientId)
                    .HasColumnName("Fk_PacientID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DataInregistrare).HasColumnType("datetime");

                entity.Property(e => e.Parola)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.FkPacient)
                    .WithOne(p => p.LoginPacient)
                    .HasForeignKey<LoginPacient>(d => d.FkPacientId)
                    .HasConstraintName("FK_LoginPacient_Pacient");
            });

            modelBuilder.Entity<LoginUser>(entity =>
            {
                entity.HasKey(e => e.FkUtilizatorId)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkUtilizatorId)
                    .HasName("UQ__LoginUse__7F5FC7753F123C19")
                    .IsUnique();

                entity.Property(e => e.FkUtilizatorId)
                    .HasColumnName("Fk_UtilizatorId")
                    .ValueGeneratedNever();

                entity.Property(e => e.DataInregistrare)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Parola)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.FkUtilizator)
                    .WithOne(p => p.LoginUser)
                    .HasForeignKey<LoginUser>(d => d.FkUtilizatorId)
                    .HasConstraintName("FK__LoginUser__Fk_Ut__4E88ABD4");
            });

            modelBuilder.Entity<Medic>(entity =>
            {
                entity.HasKey(e => e.FkUtilizatorId)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkUtilizatorId)
                    .HasName("UQ__Medic__7F5FC77505DAEC06")
                    .IsUnique();

                entity.Property(e => e.FkUtilizatorId)
                    .HasColumnName("Fk_UtilizatorId")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodulDeParafa)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ProcentServicii)
                    .HasColumnType("decimal(5, 2)")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.FkUtilizator)
                    .WithOne(p => p.Medic)
                    .HasForeignKey<Medic>(d => d.FkUtilizatorId)
                    .HasConstraintName("FK__Medic__Fk_Utiliz__2A4B4B5E");
            });

            modelBuilder.Entity<MedicSpecialitati>(entity =>
            {
                entity.HasKey(e => e.PkMedicaSpecialitatiId);

                entity.Property(e => e.PkMedicaSpecialitatiId).HasColumnName("Pk_MedicaSpecialitatiId");

                entity.Property(e => e.FkMedicId).HasColumnName("Fk_MedicId");

                entity.Property(e => e.FkSpecialitateId).HasColumnName("Fk_SpecialitateId");

                entity.HasOne(d => d.FkMedic)
                    .WithMany(p => p.MedicSpecialitati)
                    .HasForeignKey(d => d.FkMedicId)
                    .HasConstraintName("FK__MedicSpec__Fk_Me__2F10007B");

                entity.HasOne(d => d.FkSpecialitate)
                    .WithMany(p => p.MedicSpecialitati)
                    .HasForeignKey(d => d.FkSpecialitateId)
                    .HasConstraintName("FK__MedicSpec__Fk_Sp__300424B4");
            });

            modelBuilder.Entity<OrarUnitateMedicala>(entity =>
            {
                entity.HasKey(e => e.OrarId);

                entity.Property(e => e.FkUnitateMedicalaId).HasColumnName("Fk_UnitateMedicalaId");

                entity.Property(e => e.OraDeschidere).HasColumnType("time(0)");

                entity.Property(e => e.OraInchidere).HasColumnType("time(0)");

                entity.HasOne(d => d.FkUnitateMedicala)
                    .WithMany(p => p.OrarUnitateMedicala)
                    .HasForeignKey(d => d.FkUnitateMedicalaId)
                    .HasConstraintName("FK__OrarUnita__Fk_Un__164452B1");
            });

            modelBuilder.Entity<OrarUtilizatori>(entity =>
            {
                entity.HasKey(e => e.OrarId);

                entity.Property(e => e.DataZiSpeciala).HasColumnType("datetime");

                entity.Property(e => e.FkUtilizatorId).HasColumnName("Fk_UtilizatorId");

                entity.Property(e => e.IncepereProgram).HasColumnType("time(0)");

                entity.Property(e => e.SfarsitProgram).HasColumnType("time(0)");

                entity.HasOne(d => d.FkUtilizator)
                    .WithMany(p => p.OrarUtilizatori)
                    .HasForeignKey(d => d.FkUtilizatorId)
                    .HasConstraintName("FK__OrarUtili__Fk_Ut__267ABA7A");
            });

            modelBuilder.Entity<Pacient>(entity =>
            {
                entity.Property(e => e.CardSanatate)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Cnp)
                    .IsRequired()
                    .HasColumnName("CNP")
                    .HasMaxLength(13);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Nume)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Ocupatie).HasMaxLength(255);

                entity.Property(e => e.Prenume)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ProceduriMedic>(entity =>
            {
                entity.HasKey(e => e.ProceduraMedicId);

                entity.Property(e => e.FkMedicId).HasColumnName("Fk_MedicId");

                entity.Property(e => e.Nume)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.FkMedic)
                    .WithMany(p => p.ProceduriMedic)
                    .HasForeignKey(d => d.FkMedicId)
                    .HasConstraintName("FK__Proceduri__Fk_Me__32E0915F");
            });

            modelBuilder.Entity<ProgramariServicii>(entity =>
            {
                entity.HasKey(e => e.ProgramareId);

                entity.Property(e => e.DataProgramare).HasColumnType("datetime");

                entity.Property(e => e.FkPacientId).HasColumnName("Fk_PacientId");

                entity.Property(e => e.FkReceptionerId).HasColumnName("Fk_ReceptionerId");

                entity.Property(e => e.Realizata).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.FkPacient)
                    .WithMany(p => p.ProgramariServicii)
                    .HasForeignKey(d => d.FkPacientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Programar__Fk_Pa__3B75D760");

                entity.HasOne(d => d.FkReceptioner)
                    .WithMany(p => p.ProgramariServicii)
                    .HasForeignKey(d => d.FkReceptionerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Programar__Fk_Re__3C69FB99");
            });

            modelBuilder.Entity<RaportMedical>(entity =>
            {
                entity.HasKey(e => e.FkServiciuMedicalId)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.FkServiciuMedicalId)
                    .HasColumnName("Fk_ServiciuMedicalId")
                    .ValueGeneratedNever();

                entity.Property(e => e.DataConsultatie).HasColumnType("datetime");

                entity.Property(e => e.NumePrenumeMedic).HasMaxLength(255);

                entity.Property(e => e.NumePrenumePacient).HasMaxLength(255);

                entity.HasOne(d => d.FkServiciuMedical)
                    .WithOne(p => p.RaportMedical)
                    .HasForeignKey<RaportMedical>(d => d.FkServiciuMedicalId)
                    .HasConstraintName("FK__RaportMed__Fk_Se__47DBAE45");
            });

            modelBuilder.Entity<Roluri>(entity =>
            {
                entity.HasKey(e => e.RolId);

                entity.Property(e => e.Nume)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ServiciiMedicale>(entity =>
            {
                entity.HasKey(e => e.ServiciuMedicalId);

                entity.Property(e => e.FkMedicId).HasColumnName("Fk_MedicId");

                entity.Property(e => e.FkProgramareId).HasColumnName("Fk_ProgramareId");

                entity.Property(e => e.FkUnitateMedicala).HasColumnName("Fk_UnitateMedicala");

                entity.Property(e => e.Pret).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.FkMedic)
                    .WithMany(p => p.ServiciiMedicale)
                    .HasForeignKey(d => d.FkMedicId)
                    .HasConstraintName("FK__ServiciiM__Fk_Me__440B1D61");

                entity.HasOne(d => d.FkProgramare)
                    .WithMany(p => p.ServiciiMedicale)
                    .HasForeignKey(d => d.FkProgramareId)
                    .HasConstraintName("FK__ServiciiM__Fk_Pr__44FF419A");

                entity.HasOne(d => d.FkUnitateMedicalaNavigation)
                    .WithMany(p => p.ServiciiMedicale)
                    .HasForeignKey(d => d.FkUnitateMedicala)
                    .HasConstraintName("FK__ServiciiM__Fk_Un__4316F928");
            });

            modelBuilder.Entity<SpecialitateServicii>(entity =>
            {
                entity.HasKey(e => e.PkSpecialitatiServiciiId);

                entity.Property(e => e.PkSpecialitatiServiciiId).HasColumnName("Pk_SpecialitatiServiciiId");

                entity.Property(e => e.FkServiciuMedicalId).HasColumnName("Fk_ServiciuMedicalId");

                entity.Property(e => e.FkSpecialitateId).HasColumnName("Fk_SpecialitateId");

                entity.HasOne(d => d.FkServiciuMedical)
                    .WithMany(p => p.SpecialitateServicii)
                    .HasForeignKey(d => d.FkServiciuMedicalId)
                    .HasConstraintName("FK__Specialit__Fk_Se__49C3F6B7");

                entity.HasOne(d => d.FkSpecialitate)
                    .WithMany(p => p.SpecialitateServicii)
                    .HasForeignKey(d => d.FkSpecialitateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Specialit__Fk_Sp__4AB81AF0");
            });

            modelBuilder.Entity<Specialitati>(entity =>
            {
                entity.HasKey(e => e.SpecialitateId);

                entity.Property(e => e.Descriere).HasMaxLength(255);

                entity.Property(e => e.Nume)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<UnitateMedicala>(entity =>
            {
                entity.Property(e => e.Denumire)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Utilizatori>(entity =>
            {
                entity.HasKey(e => e.UtilizatorId);

                entity.HasIndex(e => e.NumarContract)
                    .HasName("NumarContract");

                entity.Property(e => e.Adresa).HasMaxLength(255);

                entity.Property(e => e.Cnp)
                    .IsRequired()
                    .HasColumnName("CNP")
                    .HasMaxLength(13);

                entity.Property(e => e.DataAngajare)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.FkFunctieId).HasColumnName("Fk_FunctieId");

                entity.Property(e => e.FkRolId).HasColumnName("Fk_RolId");

                entity.Property(e => e.FkUnitateMedicalaId).HasColumnName("Fk_UnitateMedicalaId");

                entity.Property(e => e.Iban)
                    .IsRequired()
                    .HasColumnName("IBAN")
                    .HasMaxLength(255);

                entity.Property(e => e.Nume)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Prenume)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Salar).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasMaxLength(31);

                entity.HasOne(d => d.FkFunctie)
                    .WithMany(p => p.Utilizatori)
                    .HasForeignKey(d => d.FkFunctieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Utilizato__Fk_Fu__21B6055D");

                entity.HasOne(d => d.FkRol)
                    .WithMany(p => p.Utilizatori)
                    .HasForeignKey(d => d.FkRolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Utilizato__Fk_Ro__22AA2996");

                entity.HasOne(d => d.FkUnitateMedicala)
                    .WithMany(p => p.Utilizatori)
                    .HasForeignKey(d => d.FkUnitateMedicalaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Utilizato__Fk_Un__239E4DCF");
            });
        }
    }
}
