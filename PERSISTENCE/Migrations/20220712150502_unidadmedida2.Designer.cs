﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PERSISTENCE;

namespace PERSISTENCE.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220712150502_unidadmedida2")]
    partial class unidadmedida2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DATA.Models.AgrupacionesSindicales", b =>
                {
                    b.Property<long>("IdAgrupacionSindical")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Obs")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.HasKey("IdAgrupacionSindical");

                    b.HasIndex("Descripcion")
                        .IsUnique()
                        .HasName("det_descripcionAgrupacionSindicalUnica")
                        .HasFilter("[Descripcion] IS NOT NULL");

                    b.ToTable("AgrupacionesSindicales");
                });

            modelBuilder.Entity("DATA.Models.CentrodeCosto", b =>
                {
                    b.Property<long>("idCentrodeCosto")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idCentrodeCosto")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CentroDeCosto")
                        .HasColumnName("CentrodeCosto")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int>("CodigoBas")
                        .HasColumnName("codigobas")
                        .HasColumnType("int");

                    b.Property<string>("Obs")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.Property<long>("idEstadoUnidad")
                        .HasColumnType("bigint");

                    b.HasKey("idCentrodeCosto")
                        .HasName("PK_CentroCosto");

                    b.HasIndex("CentroDeCosto")
                        .IsUnique()
                        .HasName("det_centrodecostounico")
                        .HasFilter("[CentrodeCosto] IS NOT NULL");

                    b.HasIndex("idEstadoUnidad");

                    b.ToTable("CentrodeCostos");
                });

            modelBuilder.Entity("DATA.Models.Choferes", b =>
                {
                    b.Property<long>("IdChofer")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idChofer")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<string>("AgrupacionSindical")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("ApellidoyNombre")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<DateTime>("CarnetVence")
                        .HasColumnType("datetime");

                    b.Property<string>("Convenio")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("Empresa")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("Especialidad")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime");

                    b.Property<string>("Foto")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("Funcion")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("Legajo")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("NroDocumento")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("Obs")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<long>("idAgrupacionSindical")
                        .HasColumnType("bigint");

                    b.Property<long>("idConvenio")
                        .HasColumnType("bigint");

                    b.Property<long>("idEmpresa")
                        .HasColumnType("bigint");

                    b.Property<long>("idEspecialidad")
                        .HasColumnType("bigint");

                    b.Property<long>("idFuncion")
                        .HasColumnType("bigint");

                    b.Property<int>("idTitulo")
                        .HasColumnType("int");

                    b.HasKey("IdChofer");

                    b.HasIndex("idAgrupacionSindical");

                    b.HasIndex("idConvenio");

                    b.HasIndex("idEmpresa");

                    b.HasIndex("idEspecialidad");

                    b.HasIndex("idFuncion");

                    b.HasIndex("idTitulo");

                    b.ToTable("Choferes");
                });

            modelBuilder.Entity("DATA.Models.Convenios", b =>
                {
                    b.Property<long>("IdConvenio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Obs")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.HasKey("IdConvenio");

                    b.HasIndex("Descripcion")
                        .IsUnique()
                        .HasName("det_descripcionConvenioUnico")
                        .HasFilter("[Descripcion] IS NOT NULL");

                    b.ToTable("Convenios");
                });

            modelBuilder.Entity("DATA.Models.Empresas", b =>
                {
                    b.Property<long>("IdEmpresa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Obs")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.HasKey("IdEmpresa");

                    b.HasIndex("Descripcion")
                        .IsUnique()
                        .HasName("det_descripcionEmpresaUnica")
                        .HasFilter("[Descripcion] IS NOT NULL");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("DATA.Models.Especialidades", b =>
                {
                    b.Property<long>("IdEspecialidad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Obs")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.HasKey("IdEspecialidad");

                    b.HasIndex("Descripcion")
                        .IsUnique()
                        .HasName("det_descripcionEspecialidadUnica")
                        .HasFilter("[Descripcion] IS NOT NULL");

                    b.ToTable("Especialidades");
                });

            modelBuilder.Entity("DATA.Models.EstadosUnidades", b =>
                {
                    b.Property<long>("IdEstadoUnidad")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idEstadoUnidad")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Estado")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Obs")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.HasKey("IdEstadoUnidad");

                    b.HasIndex("Estado")
                        .IsUnique()
                        .HasName("det_estadounico")
                        .HasFilter("[Estado] IS NOT NULL");

                    b.ToTable("EstadosUnidades");
                });

            modelBuilder.Entity("DATA.Models.Funciones", b =>
                {
                    b.Property<long>("IdFuncion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Obs")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.HasKey("IdFuncion");

                    b.HasIndex("Descripcion")
                        .IsUnique()
                        .HasName("det_descripcionFuncionUnica")
                        .HasFilter("[Descripcion] IS NOT NULL");

                    b.ToTable("Funciones");
                });

            modelBuilder.Entity("DATA.Models.Grupos", b =>
                {
                    b.Property<long>("IdGrupo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Obs")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("RutaImagen")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.HasKey("IdGrupo");

                    b.HasIndex("Descripcion")
                        .IsUnique()
                        .HasName("det_descripciongrupounico");

                    b.ToTable("Grupos");
                });

            modelBuilder.Entity("DATA.Models.HistoricoPartesNeumaticos", b =>
                {
                    b.Property<long>("IdHistoricoParteNeumatico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<long>("IdNeumatico")
                        .HasColumnType("bigint");

                    b.Property<long?>("IdParte")
                        .HasColumnType("bigint");

                    b.Property<long?>("IdTraza")
                        .HasColumnType("bigint");

                    b.Property<long?>("IdTraza1")
                        .HasColumnType("bigint");

                    b.Property<long?>("IdUnidad")
                        .HasColumnType("bigint");

                    b.Property<int?>("KmAgregados")
                        .HasColumnType("int");

                    b.HasKey("IdHistoricoParteNeumatico");

                    b.HasIndex("IdTraza1");

                    b.ToTable("HistoricoPartesNeumaticos");
                });

            modelBuilder.Entity("DATA.Models.Localidades", b =>
                {
                    b.Property<long>("IdLocalidad")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idLocalidad")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodigoPostal")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("Localidad")
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<long>("idProvincia")
                        .HasColumnName("idProvincia")
                        .HasColumnType("bigint");

                    b.HasKey("IdLocalidad");

                    b.HasIndex("Localidad")
                        .IsUnique()
                        .HasName("det_localidadaunica")
                        .HasFilter("[Localidad] IS NOT NULL");

                    b.HasIndex("idProvincia");

                    b.ToTable("Localidades");
                });

            modelBuilder.Entity("DATA.Models.Marcas", b =>
                {
                    b.Property<long>("IdMarca")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idMarca")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Marca")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Obs")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.HasKey("IdMarca");

                    b.HasIndex("Marca")
                        .IsUnique()
                        .HasName("det_marcaunica")
                        .HasFilter("[Marca] IS NOT NULL");

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("DATA.Models.Modelos", b =>
                {
                    b.Property<long>("IdModelo")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idModelo")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("IdGrupo")
                        .HasColumnType("bigint");

                    b.Property<string>("Modelo")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Obs")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<long>("idMarca")
                        .HasColumnName("idMarca")
                        .HasColumnType("bigint");

                    b.HasKey("IdModelo");

                    b.HasIndex("IdGrupo");

                    b.HasIndex("idMarca");

                    b.HasIndex("IdModelo", "idMarca")
                        .HasName("IX_Modelos_IdModeloIdMarca");

                    b.HasIndex("Modelo", "idMarca")
                        .IsUnique()
                        .HasName("det_modelounico")
                        .HasFilter("[Modelo] IS NOT NULL");

                    b.ToTable("Modelos");
                });

            modelBuilder.Entity("DATA.Models.Provincias", b =>
                {
                    b.Property<long>("IdProvincia")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idProvincia")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Provincia")
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.HasKey("IdProvincia");

                    b.HasIndex("Provincia")
                        .IsUnique()
                        .HasName("det_provinciaunica")
                        .HasFilter("[Provincia] IS NOT NULL");

                    b.ToTable("Provincias");
                });

            modelBuilder.Entity("DATA.Models.SituacionesUnidades", b =>
                {
                    b.Property<long>("IdSituacionUnidad")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idSituacionUnidad")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Obs")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("Situacion")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("IdSituacionUnidad");

                    b.ToTable("SituacionesUnidades");
                });

            modelBuilder.Entity("DATA.Models.Titulos", b =>
                {
                    b.Property<int>("IdTitulo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Obs")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.HasKey("IdTitulo");

                    b.HasIndex("Descripcion")
                        .IsUnique()
                        .HasName("det_descripcionTituloUnico")
                        .HasFilter("[Descripcion] IS NOT NULL");

                    b.ToTable("Titulos");
                });

            modelBuilder.Entity("DATA.Models.Trazas", b =>
                {
                    b.Property<long>("IdTraza")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DistanciaKM")
                        .HasColumnName("DistanciaKM")
                        .HasColumnType("int");

                    b.Property<long?>("IdLocalidadDesde")
                        .HasColumnType("bigint");

                    b.Property<long?>("IdLocalidadHasta")
                        .HasColumnType("bigint");

                    b.Property<int?>("Litros")
                        .HasColumnType("int");

                    b.Property<string>("Obs")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.HasKey("IdTraza");

                    b.HasIndex("IdLocalidadDesde");

                    b.HasIndex("IdLocalidadHasta");

                    b.ToTable("Trazas");
                });

            modelBuilder.Entity("DATA.Models.Unidades", b =>
                {
                    b.Property<long>("IdUnidad")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idUnidad")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AcreedorPrendario")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<long?>("AñoModelo")
                        .HasColumnType("bigint");

                    b.Property<double?>("Capacidad")
                        .HasColumnType("float");

                    b.Property<string>("Chasis")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("CodigoLlave")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("CodigoRadio")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("Descripcion")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Dominio")
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<string>("Foto")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<bool?>("HabilitaOtraUnidadMedida")
                        .HasColumnType("bit");

                    b.Property<double?>("HsAceptadasDesfazadas")
                        .HasColumnType("float");

                    b.Property<double?>("HsKmsDiaTrabajo")
                        .HasColumnType("float");

                    b.Property<int?>("IdEsquema")
                        .HasColumnType("int");

                    b.Property<int?>("IdModeloChasis")
                        .HasColumnType("int");

                    b.Property<int?>("IdTipoCombustible")
                        .HasColumnType("int");

                    b.Property<int?>("IdTipoLlanta")
                        .HasColumnType("int");

                    b.Property<int?>("IdTraza")
                        .HasColumnType("int");

                    b.Property<long?>("IdUnidadDeMedida")
                        .HasColumnType("bigint");

                    b.Property<bool?>("IntExt")
                        .HasColumnType("bit");

                    b.Property<double?>("KmAceptadosDesfazados")
                        .HasColumnType("float");

                    b.Property<int?>("LitrosxTraza")
                        .HasColumnType("int");

                    b.Property<double?>("LtsDiaTrabajo")
                        .HasColumnType("float");

                    b.Property<string>("MarcaTacografo")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("Motor")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("NroUnidad")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Obs")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("Potencia")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<double?>("PromedioConsumo")
                        .HasColumnType("float");

                    b.Property<string>("Radicacion")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("Tacografo")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<bool?>("TieneConceptosSinRealizar")
                        .HasColumnType("bit");

                    b.Property<string>("Titular")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<int?>("UnidadMedTrabajo")
                        .HasColumnType("int")
                        .HasComment("1) Km - 2) Hs");

                    b.Property<string>("UnidadMedida")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<long>("idEstadoUnidad")
                        .HasColumnType("bigint");

                    b.Property<long>("idModelo")
                        .HasColumnType("bigint");

                    b.Property<long?>("idNombreEquipamiento")
                        .HasColumnName("idNombreEquipamiento")
                        .HasColumnType("bigint");

                    b.Property<long>("idSituacionUnidad")
                        .HasColumnType("bigint");

                    b.HasKey("IdUnidad");

                    b.HasIndex("idEstadoUnidad");

                    b.HasIndex("idModelo");

                    b.HasIndex("idSituacionUnidad");

                    b.HasIndex("IdUnidad", "NroUnidad")
                        .HasName("Unidades_IdUnidadNroUnidad");

                    b.HasIndex("IdUnidad", "UnidadMedTrabajo")
                        .HasName("Unidades_IdUnidadUnidadMedTrabajo");

                    b.HasIndex("IdUnidad", "NroUnidad", "UnidadMedTrabajo")
                        .HasName("Unidades_IdUnidadNroUnidadUnidadMedTrabajo");

                    b.ToTable("Unidades");
                });

            modelBuilder.Entity("DATA.Models.UnidadesMedida", b =>
                {
                    b.Property<int>("IdUnidadMedida")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UnidadDeMedida")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("IdUnidadMedida")
                        .HasName("PK_UnidadesMedida");

                    b.HasIndex("UnidadDeMedida")
                        .IsUnique()
                        .HasName("det_unidaddemedidaunica")
                        .HasFilter("[UnidadDeMedida] IS NOT NULL");

                    b.HasIndex("IdUnidadMedida", "UnidadDeMedida")
                        .HasName("IX_UnidadesDeMedida_IdUnidadDeMedidaUnidadDeMedida");

                    b.ToTable("UnidadesDeMedida");
                });

            modelBuilder.Entity("DATA.Models.VariablesUnidades", b =>
                {
                    b.Property<long>("IdVariableUnidad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("IdVariableUnidad");

                    b.ToTable("VariablesUnidades");
                });

            modelBuilder.Entity("DATA.Models.CentrodeCosto", b =>
                {
                    b.HasOne("DATA.Models.EstadosUnidades", "IdEstadoUnidad")
                        .WithMany("CentrodeCosto")
                        .HasForeignKey("idEstadoUnidad")
                        .HasConstraintName("FK_CentrodeCosto_EstadosUnidades")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DATA.Models.Choferes", b =>
                {
                    b.HasOne("DATA.Models.AgrupacionesSindicales", "IdAgrupacionSindical")
                        .WithMany("Choferes")
                        .HasForeignKey("idAgrupacionSindical")
                        .HasConstraintName("FK_Choferes_AgrupacionesSindicales")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DATA.Models.Convenios", "IdConvenio")
                        .WithMany("Choferes")
                        .HasForeignKey("idConvenio")
                        .HasConstraintName("FK_Choferes_Convenios")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DATA.Models.Empresas", "IdEmpresa")
                        .WithMany("Choferes")
                        .HasForeignKey("idEmpresa")
                        .HasConstraintName("FK_Choferes_Empresas")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DATA.Models.Especialidades", "IdEspecialidad")
                        .WithMany("Choferes")
                        .HasForeignKey("idEspecialidad")
                        .HasConstraintName("FK_Choferes_Especialidades")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DATA.Models.Funciones", "IdFuncion")
                        .WithMany("Choferes")
                        .HasForeignKey("idFuncion")
                        .HasConstraintName("FK_Choferes_Funciones")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DATA.Models.Titulos", "IdTitulo")
                        .WithMany("Choferes")
                        .HasForeignKey("idTitulo")
                        .HasConstraintName("FK_Choferes_Titulos")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DATA.Models.HistoricoPartesNeumaticos", b =>
                {
                    b.HasOne("DATA.Models.Trazas", "idTraza")
                        .WithMany("HistoricoPartes")
                        .HasForeignKey("IdTraza1");
                });

            modelBuilder.Entity("DATA.Models.Localidades", b =>
                {
                    b.HasOne("DATA.Models.Provincias", "IdProvincia")
                        .WithMany("Localidades")
                        .HasForeignKey("idProvincia")
                        .HasConstraintName("FK_Localidades_Provincias")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DATA.Models.Modelos", b =>
                {
                    b.HasOne("DATA.Models.Grupos", "idGrupo")
                        .WithMany("Modelos")
                        .HasForeignKey("IdGrupo")
                        .HasConstraintName("FK_Modelos_Grupos")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DATA.Models.Marcas", "IdMarca")
                        .WithMany("Modelos")
                        .HasForeignKey("idMarca")
                        .HasConstraintName("FK_Modelos_Marcas")
                        .IsRequired();
                });

            modelBuilder.Entity("DATA.Models.Trazas", b =>
                {
                    b.HasOne("DATA.Models.Localidades", "idLocalidadDesde")
                        .WithMany("LocalidadDesde")
                        .HasForeignKey("IdLocalidadDesde")
                        .HasConstraintName("FK_TrazaDesde_Localidades")
                        .OnDelete(DeleteBehavior.ClientCascade);

                    b.HasOne("DATA.Models.Localidades", "idLocalidadHasta")
                        .WithMany("LocalidadHasta")
                        .HasForeignKey("IdLocalidadHasta")
                        .HasConstraintName("FK_TrazaHasta_Localidades")
                        .OnDelete(DeleteBehavior.ClientCascade);
                });

            modelBuilder.Entity("DATA.Models.Unidades", b =>
                {
                    b.HasOne("DATA.Models.EstadosUnidades", "IdEstadoUnidad")
                        .WithMany("Unidades")
                        .HasForeignKey("idEstadoUnidad")
                        .HasConstraintName("FK_Unidades_EstadosUnidads")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DATA.Models.Modelos", "IdModelo")
                        .WithMany("Unidades")
                        .HasForeignKey("idModelo")
                        .HasConstraintName("FK_Unidades_Modelos")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DATA.Models.SituacionesUnidades", "IdSituacionUnidad")
                        .WithMany("Unidades")
                        .HasForeignKey("idSituacionUnidad")
                        .HasConstraintName("FK_Unidades_SituacionesUnidades")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
