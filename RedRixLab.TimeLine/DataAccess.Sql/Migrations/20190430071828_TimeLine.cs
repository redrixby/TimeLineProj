using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Sql.Migrations
{
    public partial class TimeLine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AcademicDegrees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicDegrees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AcademicTitles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicTitles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Benefits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Benefits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Citizenships",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citizenships", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InstitutionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstitutionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocallityTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocallityTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaritalStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaritalStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MillitaryRegistrationStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MillitaryRegistrationStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlaceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Qualifications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qualifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reasons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reasons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RelativeTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelativeTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScientificSpecialities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScientificSpecialities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScientificTitleIPDs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScientificTitleIPDs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StreetTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StreetTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudyForms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyForms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudyTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subdivisions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subdivisions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaskTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PasportDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    PasportSeries = table.Column<string>(nullable: true),
                    PasportNumber = table.Column<string>(nullable: true),
                    IssuedBy = table.Column<string>(nullable: true),
                    PersonalNumber = table.Column<string>(nullable: true),
                    FinishDate = table.Column<DateTime>(nullable: false),
                    TLid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PasportDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PasportDetails_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Workers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateChanged = table.Column<DateTime>(nullable: false),
                    DateDeleted = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Workers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Regions_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Specialities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FacultyId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Specialities_Faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InstitutionNames",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true),
                    InstitutionTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstitutionNames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InstitutionNames_InstitutionTypes_InstitutionTypeId",
                        column: x => x.InstitutionTypeId,
                        principalTable: "InstitutionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BasicInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    GenderId = table.Column<int>(nullable: false),
                    Birthday = table.Column<DateTime>(nullable: false),
                    CitizenshipId = table.Column<int>(nullable: false),
                    MaritalStatusId = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasicInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasicInfos_Citizenships_CitizenshipId",
                        column: x => x.CitizenshipId,
                        principalTable: "Citizenships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BasicInfos_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BasicInfos_MaritalStatuses_MaritalStatusId",
                        column: x => x.MaritalStatusId,
                        principalTable: "MaritalStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BasicInfos_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MillitaryRegistrations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    MillitaryRegistrationStatusId = table.Column<int>(nullable: false),
                    RecruitmentOffice = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MillitaryRegistrations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MillitaryRegistrations_MillitaryRegistrationStatuses_MillitaryRegistrationStatusId",
                        column: x => x.MillitaryRegistrationStatusId,
                        principalTable: "MillitaryRegistrationStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MillitaryRegistrations_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RelativesAboutInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    RelativeTypeId = table.Column<int>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelativesAboutInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RelativesAboutInfos_RelativeTypes_RelativeTypeId",
                        column: x => x.RelativeTypeId,
                        principalTable: "RelativeTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RelativesAboutInfos_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubjectInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SubjectId = table.Column<int>(nullable: false),
                    AllottedStudyTime = table.Column<double>(nullable: false),
                    CourseOfStudy = table.Column<int>(nullable: false),
                    Semmester = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubjectInfos_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubjectTasks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SubjectId = table.Column<int>(nullable: false),
                    TaskTypeId = table.Column<int>(nullable: false),
                    CourseOfStudy = table.Column<int>(nullable: false),
                    Semmester = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubjectTasks_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SubjectTasks_TaskTypes_TaskTypeId",
                        column: x => x.TaskTypeId,
                        principalTable: "TaskTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Statements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TeacherId = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateDelevery = table.Column<DateTime>(nullable: false),
                    DateFinish = table.Column<DateTime>(nullable: false),
                    SubjectId = table.Column<int>(nullable: false),
                    StatementName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Statements_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Statements_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubjectDebtInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentId = table.Column<int>(nullable: false),
                    SubjectId = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    Mark = table.Column<int>(nullable: false),
                    TeacherId = table.Column<int>(nullable: false),
                    CourseOfStudy = table.Column<int>(nullable: false),
                    Semmester = table.Column<int>(nullable: false),
                    DateDebtCancelled = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectDebtInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubjectDebtInfos_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SubjectDebtInfos_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SubjectDebtInfos_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubjectMarkInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentId = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    Mark = table.Column<int>(nullable: false),
                    TeacherId = table.Column<int>(nullable: false),
                    CourseOfStudy = table.Column<int>(nullable: false),
                    Semmester = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectMarkInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubjectMarkInfos_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SubjectMarkInfos_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkersInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    WorkersId = table.Column<int>(nullable: false),
                    DateOrderNumber = table.Column<DateTime>(nullable: false),
                    OrderNumber = table.Column<string>(nullable: true),
                    DateStart = table.Column<DateTime>(nullable: false),
                    DateEnd = table.Column<DateTime>(nullable: false),
                    DateRegistration = table.Column<DateTime>(nullable: false),
                    ReasonId = table.Column<int>(nullable: false),
                    WorkExperience = table.Column<double>(nullable: false),
                    DateTransfer = table.Column<DateTime>(nullable: false),
                    OrderNumberForTransfer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkersInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkersInfos_Reasons_ReasonId",
                        column: x => x.ReasonId,
                        principalTable: "Reasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkersInfos_Workers_WorkersId",
                        column: x => x.WorkersId,
                        principalTable: "Workers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RegionId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Districts_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Enrolles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateChanged = table.Column<DateTime>(nullable: false),
                    DateDeleted = table.Column<DateTime>(nullable: false),
                    StudyFormId = table.Column<int>(nullable: false),
                    SpecialityId = table.Column<int>(nullable: false),
                    AverageGradeCertificate = table.Column<double>(nullable: false),
                    BenefitsId = table.Column<int>(nullable: false),
                    DucementDelivery = table.Column<bool>(nullable: false),
                    DocumentPickUp = table.Column<bool>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    AmountBall = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrolles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enrolles_Benefits_BenefitsId",
                        column: x => x.BenefitsId,
                        principalTable: "Benefits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Enrolles_Specialities_SpecialityId",
                        column: x => x.SpecialityId,
                        principalTable: "Specialities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Enrolles_StudyForms_StudyFormId",
                        column: x => x.StudyFormId,
                        principalTable: "StudyForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Enrolles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateStart = table.Column<DateTime>(nullable: false),
                    DateFinish = table.Column<DateTime>(nullable: false),
                    SpecialityId = table.Column<int>(nullable: false),
                    GroupName = table.Column<string>(nullable: true),
                    CourseOfStudy = table.Column<int>(nullable: false),
                    Semmester = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_Specialities_SpecialityId",
                        column: x => x.SpecialityId,
                        principalTable: "Specialities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SpecialityInfoForEnrolles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SpecialityId = table.Column<int>(nullable: false),
                    StudyFormId = table.Column<int>(nullable: false),
                    TotalAmountRecruitmant = table.Column<int>(nullable: false),
                    AmountRecruitmentPaid = table.Column<int>(nullable: false),
                    AmountRecruitmentFree = table.Column<int>(nullable: false),
                    PassingBall = table.Column<double>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateChanged = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialityInfoForEnrolles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpecialityInfoForEnrolles_Specialities_SpecialityId",
                        column: x => x.SpecialityId,
                        principalTable: "Specialities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SpecialityInfoForEnrolles_StudyForms_StudyFormId",
                        column: x => x.StudyFormId,
                        principalTable: "StudyForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Specializations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SpecialityId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specializations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Specializations_Specialities_SpecialityId",
                        column: x => x.SpecialityId,
                        principalTable: "Specialities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Trainings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    WorkersId = table.Column<int>(nullable: false),
                    DateTraining = table.Column<DateTime>(nullable: false),
                    InstitutionNameId = table.Column<int>(nullable: false),
                    DateEndTraining = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trainings_InstitutionNames_InstitutionNameId",
                        column: x => x.InstitutionNameId,
                        principalTable: "InstitutionNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Trainings_Workers_WorkersId",
                        column: x => x.WorkersId,
                        principalTable: "Workers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubjectTaskInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentId = table.Column<int>(nullable: false),
                    SubjectId = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    Mark = table.Column<int>(nullable: false),
                    TaskTypeId = table.Column<int>(nullable: false),
                    TeacherId = table.Column<int>(nullable: false),
                    CourseOfStudy = table.Column<int>(nullable: false),
                    Semmester = table.Column<int>(nullable: false),
                    StatementId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectTaskInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubjectTaskInfos_Statements_StatementId",
                        column: x => x.StatementId,
                        principalTable: "Statements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SubjectTaskInfos_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SubjectTaskInfos_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SubjectTaskInfos_TaskTypes_TaskTypeId",
                        column: x => x.TaskTypeId,
                        principalTable: "TaskTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SubjectTaskInfos_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DistrictId = table.Column<int>(nullable: false),
                    LocallityTypeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cities_LocallityTypes_LocallityTypeId",
                        column: x => x.LocallityTypeId,
                        principalTable: "LocallityTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CentralizedTestings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EnrolleId = table.Column<int>(nullable: false),
                    SubjectId = table.Column<int>(nullable: false),
                    Mark = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CentralizedTestings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CentralizedTestings_Enrolles_EnrolleId",
                        column: x => x.EnrolleId,
                        principalTable: "Enrolles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CentralizedTestings_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EntranceExams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EnrolleId = table.Column<int>(nullable: false),
                    SubjectId = table.Column<int>(nullable: false),
                    Mark = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntranceExams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntranceExams_Enrolles_EnrolleId",
                        column: x => x.EnrolleId,
                        principalTable: "Enrolles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntranceExams_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GroupSubjectLists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GroupId = table.Column<int>(nullable: false),
                    SubjectId = table.Column<int>(nullable: false),
                    CourseOfStudy = table.Column<int>(nullable: false),
                    Semmester = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupSubjectLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupSubjectLists_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GroupSubjectLists_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StatementLines",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StatementId = table.Column<int>(nullable: false),
                    GroupId = table.Column<int>(nullable: false),
                    StudentId = table.Column<int>(nullable: false),
                    Mark = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatementLines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StatementLines_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StatementLines_Statements_StatementId",
                        column: x => x.StatementId,
                        principalTable: "Statements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StatementLines_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentsInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentId = table.Column<int>(nullable: false),
                    StudyFormId = table.Column<int>(nullable: false),
                    StudyTypeId = table.Column<int>(nullable: false),
                    FacultyId = table.Column<int>(nullable: false),
                    SpecialityId = table.Column<int>(nullable: false),
                    SpecializationId = table.Column<int>(nullable: false),
                    GroupId = table.Column<int>(nullable: false),
                    CourseOfStudy = table.Column<int>(nullable: false),
                    Semmester = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentsInfos_Faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentsInfos_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentsInfos_Specialities_SpecialityId",
                        column: x => x.SpecialityId,
                        principalTable: "Specialities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentsInfos_Specializations_SpecializationId",
                        column: x => x.SpecializationId,
                        principalTable: "Specializations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentsInfos_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentsInfos_StudyForms_StudyFormId",
                        column: x => x.StudyFormId,
                        principalTable: "StudyForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentsInfos_StudyTypes_StudyTypeId",
                        column: x => x.StudyTypeId,
                        principalTable: "StudyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudyInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    EducationTypeId = table.Column<int>(nullable: false),
                    InstitutionNameId = table.Column<int>(nullable: false),
                    SpecializationId = table.Column<int>(nullable: false),
                    QualificationId = table.Column<int>(nullable: false),
                    AcademicTitleId = table.Column<int>(nullable: false),
                    AcademicDegreeId = table.Column<int>(nullable: false),
                    ScientificSpecialityId = table.Column<int>(nullable: false),
                    ScientificTitleIPDId = table.Column<int>(nullable: false),
                    DateStart = table.Column<DateTime>(nullable: false),
                    DateFinish = table.Column<DateTime>(nullable: false),
                    DateEnrollment = table.Column<DateTime>(nullable: false),
                    DateReEnrollment = table.Column<DateTime>(nullable: false),
                    LanguageForeign = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudyInfos_AcademicDegrees_AcademicDegreeId",
                        column: x => x.AcademicDegreeId,
                        principalTable: "AcademicDegrees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudyInfos_AcademicTitles_AcademicTitleId",
                        column: x => x.AcademicTitleId,
                        principalTable: "AcademicTitles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudyInfos_EducationTypes_EducationTypeId",
                        column: x => x.EducationTypeId,
                        principalTable: "EducationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudyInfos_InstitutionNames_InstitutionNameId",
                        column: x => x.InstitutionNameId,
                        principalTable: "InstitutionNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudyInfos_Qualifications_QualificationId",
                        column: x => x.QualificationId,
                        principalTable: "Qualifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudyInfos_ScientificSpecialities_ScientificSpecialityId",
                        column: x => x.ScientificSpecialityId,
                        principalTable: "ScientificSpecialities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudyInfos_ScientificTitleIPDs_ScientificTitleIPDId",
                        column: x => x.ScientificTitleIPDId,
                        principalTable: "ScientificTitleIPDs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudyInfos_Specializations_SpecializationId",
                        column: x => x.SpecializationId,
                        principalTable: "Specializations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudyInfos_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Streets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CityId = table.Column<int>(nullable: false),
                    StreetTypeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Streets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Streets_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Streets_StreetTypes_StreetTypeId",
                        column: x => x.StreetTypeId,
                        principalTable: "StreetTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountryId = table.Column<int>(nullable: false),
                    RegionId = table.Column<int>(nullable: false),
                    CityId = table.Column<int>(nullable: false),
                    DistrictId = table.Column<int>(nullable: false),
                    StreetId = table.Column<int>(nullable: false),
                    HouseNumber = table.Column<int>(nullable: false),
                    Corps = table.Column<string>(nullable: true),
                    RoomNumber = table.Column<string>(nullable: true),
                    Index = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Addresses_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Addresses_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Addresses_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Addresses_Streets_StreetId",
                        column: x => x.StreetId,
                        principalTable: "Streets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JobsInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    WorkPlace = table.Column<string>(nullable: true),
                    AddressId = table.Column<int>(nullable: false),
                    SubdivisionId = table.Column<int>(nullable: false),
                    PositionId = table.Column<int>(nullable: false),
                    FullTimeEmployee = table.Column<bool>(nullable: false),
                    Teacher = table.Column<bool>(nullable: false),
                    Retiree = table.Column<bool>(nullable: false),
                    PartTimeJob = table.Column<bool>(nullable: false),
                    PositionPartTimeJob = table.Column<bool>(nullable: false),
                    NumberOfBets = table.Column<double>(nullable: false),
                    UnionMember = table.Column<bool>(nullable: false),
                    TempReplacementOfMainEmployee = table.Column<bool>(nullable: false),
                    DateOfCompetition = table.Column<DateTime>(nullable: false),
                    ChildChildcareLeave = table.Column<bool>(nullable: false),
                    DateCLStart = table.Column<DateTime>(nullable: false),
                    DateCLEnd = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobsInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobsInfos_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JobsInfos_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JobsInfos_Subdivisions_SubdivisionId",
                        column: x => x.SubdivisionId,
                        principalTable: "Subdivisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JobsInfos_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Places",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    PlaceTypeId = table.Column<int>(nullable: false),
                    AddressId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Places", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Places_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Places_PlaceTypes_PlaceTypeId",
                        column: x => x.PlaceTypeId,
                        principalTable: "PlaceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Places_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RelativesAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RelativesAboutInfoId = table.Column<int>(nullable: false),
                    AddressId = table.Column<int>(nullable: false),
                    AddressType = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelativesAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RelativesAddresses_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RelativesAddresses_RelativesAboutInfos_RelativesAboutInfoId",
                        column: x => x.RelativesAboutInfoId,
                        principalTable: "RelativesAboutInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "AcademicDegreeUnique",
                table: "AcademicDegrees",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "cademicTitleUnique",
                table: "AcademicTitles",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CityId",
                table: "Addresses",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_DistrictId",
                table: "Addresses",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_RegionId",
                table: "Addresses",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_StreetId",
                table: "Addresses",
                column: "StreetId");

            migrationBuilder.CreateIndex(
                name: "AddressUnique",
                table: "Addresses",
                columns: new[] { "CountryId", "RegionId", "CityId", "DistrictId", "StreetId", "HouseNumber", "Corps", "RoomNumber" },
                unique: true,
                filter: "[Corps] IS NOT NULL AND [RoomNumber] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BasicInfos_CitizenshipId",
                table: "BasicInfos",
                column: "CitizenshipId");

            migrationBuilder.CreateIndex(
                name: "IX_BasicInfos_GenderId",
                table: "BasicInfos",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "BasicInfoUnique",
                table: "BasicInfos",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BasicInfos_MaritalStatusId",
                table: "BasicInfos",
                column: "MaritalStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_BasicInfos_UserId",
                table: "BasicInfos",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "BenefitsUnique",
                table: "Benefits",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CentralizedTestings_SubjectId",
                table: "CentralizedTestings",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "CentralizedTestingUnique",
                table: "CentralizedTestings",
                columns: new[] { "EnrolleId", "SubjectId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cities_LocallityTypeId",
                table: "Cities",
                column: "LocallityTypeId");

            migrationBuilder.CreateIndex(
                name: "CityUnique",
                table: "Cities",
                columns: new[] { "DistrictId", "LocallityTypeId", "Name" },
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "CitizenshipDegreeUnique",
                table: "Citizenships",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "CountryUnique",
                table: "Countries",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "DistrictUnique",
                table: "Districts",
                columns: new[] { "RegionId", "Name" },
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "EducationTypeUnique",
                table: "EducationTypes",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Enrolles_BenefitsId",
                table: "Enrolles",
                column: "BenefitsId");

            migrationBuilder.CreateIndex(
                name: "EnrolleUnique",
                table: "Enrolles",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Enrolles_SpecialityId",
                table: "Enrolles",
                column: "SpecialityId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrolles_StudyFormId",
                table: "Enrolles",
                column: "StudyFormId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrolles_UserId",
                table: "Enrolles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EntranceExams_SubjectId",
                table: "EntranceExams",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "EntranceExamUnique",
                table: "EntranceExams",
                columns: new[] { "EnrolleId", "SubjectId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "FacultyUnique",
                table: "Faculties",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "GenderUnique",
                table: "Genders",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "GroupUnique",
                table: "Groups",
                columns: new[] { "SpecialityId", "GroupName" },
                unique: true,
                filter: "[GroupName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_GroupSubjectLists_GroupId",
                table: "GroupSubjectLists",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "GroupSubjectListUnique",
                table: "GroupSubjectLists",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GroupSubjectLists_SubjectId",
                table: "GroupSubjectLists",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitutionNames_InstitutionTypeId",
                table: "InstitutionNames",
                column: "InstitutionTypeId");

            migrationBuilder.CreateIndex(
                name: "InstitutionNameUnique",
                table: "InstitutionNames",
                columns: new[] { "Name", "InstitutionTypeId" },
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "InstitutionTypeUnique",
                table: "InstitutionTypes",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_JobsInfos_AddressId",
                table: "JobsInfos",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_JobsInfos_PositionId",
                table: "JobsInfos",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_JobsInfos_SubdivisionId",
                table: "JobsInfos",
                column: "SubdivisionId");

            migrationBuilder.CreateIndex(
                name: "JobsInfoUnique",
                table: "JobsInfos",
                columns: new[] { "UserId", "WorkPlace", "SubdivisionId", "PositionId" },
                unique: true,
                filter: "[WorkPlace] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "LocallityTypeUnique",
                table: "LocallityTypes",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "MaritalStatusUnique",
                table: "MaritalStatuses",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "MillitaryRegistrationUnique",
                table: "MillitaryRegistrations",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MillitaryRegistrations_MillitaryRegistrationStatusId",
                table: "MillitaryRegistrations",
                column: "MillitaryRegistrationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_MillitaryRegistrations_UserId",
                table: "MillitaryRegistrations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "MillitaryRegistrationStatusUnique",
                table: "MillitaryRegistrationStatuses",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "PasportDetailsUnique",
                table: "PasportDetails",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PasportDetails_UserId",
                table: "PasportDetails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Places_AddressId",
                table: "Places",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Places_PlaceTypeId",
                table: "Places",
                column: "PlaceTypeId");

            migrationBuilder.CreateIndex(
                name: "PlaceUnique",
                table: "Places",
                columns: new[] { "UserId", "PlaceTypeId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "PlaceTypeUnique",
                table: "PlaceTypes",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "PositionUnique",
                table: "Positions",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "QualificationUnique",
                table: "Qualifications",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "ReasonUnique",
                table: "Reasons",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "RegionUnique",
                table: "Regions",
                columns: new[] { "CountryId", "Name" },
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_RelativesAboutInfos_RelativeTypeId",
                table: "RelativesAboutInfos",
                column: "RelativeTypeId");

            migrationBuilder.CreateIndex(
                name: "RelativesAboutInfoUnique",
                table: "RelativesAboutInfos",
                columns: new[] { "UserId", "RelativeTypeId", "FirstName", "LastName", "MiddleName" },
                unique: true,
                filter: "[FirstName] IS NOT NULL AND [LastName] IS NOT NULL AND [MiddleName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_RelativesAddresses_AddressId",
                table: "RelativesAddresses",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "RelativesAddressUnique",
                table: "RelativesAddresses",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RelativesAddresses_RelativesAboutInfoId",
                table: "RelativesAddresses",
                column: "RelativesAboutInfoId");

            migrationBuilder.CreateIndex(
                name: "RelativeTypeUnique",
                table: "RelativeTypes",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "ScientificSpecialityUnique",
                table: "ScientificSpecialities",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "ScientificTitleIPDUnique",
                table: "ScientificTitleIPDs",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "SpecialityUnique",
                table: "Specialities",
                columns: new[] { "FacultyId", "Name" },
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SpecialityInfoForEnrolles_StudyFormId",
                table: "SpecialityInfoForEnrolles",
                column: "StudyFormId");

            migrationBuilder.CreateIndex(
                name: "SpecialityInfoForEnrolleUnique",
                table: "SpecialityInfoForEnrolles",
                columns: new[] { "SpecialityId", "StudyFormId", "DateCreated" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "SpecializationUnique",
                table: "Specializations",
                columns: new[] { "SpecialityId", "Name" },
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_StatementLines_GroupId",
                table: "StatementLines",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_StatementLines_StudentId",
                table: "StatementLines",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "StatementLineUnique",
                table: "StatementLines",
                columns: new[] { "StatementId", "GroupId", "StudentId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Statements_SubjectId",
                table: "Statements",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Statements_TeacherId",
                table: "Statements",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "StatementUnique",
                table: "Statements",
                columns: new[] { "DateCreated", "SubjectId", "StatementName" },
                unique: true,
                filter: "[StatementName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Streets_StreetTypeId",
                table: "Streets",
                column: "StreetTypeId");

            migrationBuilder.CreateIndex(
                name: "StreetUnique",
                table: "Streets",
                columns: new[] { "CityId", "StreetTypeId", "Name" },
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "StreetTypeUnique",
                table: "StreetTypes",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "StudentUnique",
                table: "Students",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_UserId",
                table: "Students",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsInfos_FacultyId",
                table: "StudentsInfos",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsInfos_GroupId",
                table: "StudentsInfos",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsInfos_SpecialityId",
                table: "StudentsInfos",
                column: "SpecialityId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsInfos_SpecializationId",
                table: "StudentsInfos",
                column: "SpecializationId");

            migrationBuilder.CreateIndex(
                name: "StudentsInfoUnique",
                table: "StudentsInfos",
                column: "StudentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentsInfos_StudyFormId",
                table: "StudentsInfos",
                column: "StudyFormId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsInfos_StudyTypeId",
                table: "StudentsInfos",
                column: "StudyTypeId");

            migrationBuilder.CreateIndex(
                name: "StudyFormUnique",
                table: "StudyForms",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_StudyInfos_AcademicDegreeId",
                table: "StudyInfos",
                column: "AcademicDegreeId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyInfos_AcademicTitleId",
                table: "StudyInfos",
                column: "AcademicTitleId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyInfos_EducationTypeId",
                table: "StudyInfos",
                column: "EducationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyInfos_InstitutionNameId",
                table: "StudyInfos",
                column: "InstitutionNameId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyInfos_QualificationId",
                table: "StudyInfos",
                column: "QualificationId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyInfos_ScientificSpecialityId",
                table: "StudyInfos",
                column: "ScientificSpecialityId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyInfos_ScientificTitleIPDId",
                table: "StudyInfos",
                column: "ScientificTitleIPDId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyInfos_SpecializationId",
                table: "StudyInfos",
                column: "SpecializationId");

            migrationBuilder.CreateIndex(
                name: "StudyInfoUnique",
                table: "StudyInfos",
                columns: new[] { "UserId", "EducationTypeId", "InstitutionNameId", "SpecializationId", "QualificationId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "StudyTypeUnique",
                table: "StudyTypes",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "SubdivisionUnique",
                table: "Subdivisions",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "SubjectDebtInfoUnique",
                table: "SubjectDebtInfos",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubjectDebtInfos_StudentId",
                table: "SubjectDebtInfos",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectDebtInfos_SubjectId",
                table: "SubjectDebtInfos",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectDebtInfos_TeacherId",
                table: "SubjectDebtInfos",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "SubjectInfoUnique",
                table: "SubjectInfos",
                columns: new[] { "SubjectId", "AllottedStudyTime", "CourseOfStudy", "Semmester" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "SubjectMarkInfoUnique",
                table: "SubjectMarkInfos",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubjectMarkInfos_StudentId",
                table: "SubjectMarkInfos",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectMarkInfos_TeacherId",
                table: "SubjectMarkInfos",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "SubjectUnique",
                table: "Subjects",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "SubjectTaskInfoUnique",
                table: "SubjectTaskInfos",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubjectTaskInfos_StatementId",
                table: "SubjectTaskInfos",
                column: "StatementId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectTaskInfos_StudentId",
                table: "SubjectTaskInfos",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectTaskInfos_SubjectId",
                table: "SubjectTaskInfos",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectTaskInfos_TaskTypeId",
                table: "SubjectTaskInfos",
                column: "TaskTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectTaskInfos_TeacherId",
                table: "SubjectTaskInfos",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectTasks_TaskTypeId",
                table: "SubjectTasks",
                column: "TaskTypeId");

            migrationBuilder.CreateIndex(
                name: "SubjectTaskUnique",
                table: "SubjectTasks",
                columns: new[] { "SubjectId", "TaskTypeId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "TaskTypeUnique",
                table: "TaskTypes",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "TeacherUnique",
                table: "Teachers",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_UserId",
                table: "Teachers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_InstitutionNameId",
                table: "Trainings",
                column: "InstitutionNameId");

            migrationBuilder.CreateIndex(
                name: "TrainingUnique",
                table: "Trainings",
                columns: new[] { "WorkersId", "DateTraining", "InstitutionNameId", "DateEndTraining" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "WorkersUnique",
                table: "Workers",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Workers_UserId",
                table: "Workers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkersInfos_ReasonId",
                table: "WorkersInfos",
                column: "ReasonId");

            migrationBuilder.CreateIndex(
                name: "WorkersInfoUnique",
                table: "WorkersInfos",
                column: "WorkersId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BasicInfos");

            migrationBuilder.DropTable(
                name: "CentralizedTestings");

            migrationBuilder.DropTable(
                name: "EntranceExams");

            migrationBuilder.DropTable(
                name: "GroupSubjectLists");

            migrationBuilder.DropTable(
                name: "JobsInfos");

            migrationBuilder.DropTable(
                name: "MillitaryRegistrations");

            migrationBuilder.DropTable(
                name: "PasportDetails");

            migrationBuilder.DropTable(
                name: "Places");

            migrationBuilder.DropTable(
                name: "RelativesAddresses");

            migrationBuilder.DropTable(
                name: "SpecialityInfoForEnrolles");

            migrationBuilder.DropTable(
                name: "StatementLines");

            migrationBuilder.DropTable(
                name: "StudentsInfos");

            migrationBuilder.DropTable(
                name: "StudyInfos");

            migrationBuilder.DropTable(
                name: "SubjectDebtInfos");

            migrationBuilder.DropTable(
                name: "SubjectInfos");

            migrationBuilder.DropTable(
                name: "SubjectMarkInfos");

            migrationBuilder.DropTable(
                name: "SubjectTaskInfos");

            migrationBuilder.DropTable(
                name: "SubjectTasks");

            migrationBuilder.DropTable(
                name: "Trainings");

            migrationBuilder.DropTable(
                name: "WorkersInfos");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Citizenships");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "MaritalStatuses");

            migrationBuilder.DropTable(
                name: "Enrolles");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Subdivisions");

            migrationBuilder.DropTable(
                name: "MillitaryRegistrationStatuses");

            migrationBuilder.DropTable(
                name: "PlaceTypes");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "RelativesAboutInfos");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "StudyTypes");

            migrationBuilder.DropTable(
                name: "AcademicDegrees");

            migrationBuilder.DropTable(
                name: "AcademicTitles");

            migrationBuilder.DropTable(
                name: "EducationTypes");

            migrationBuilder.DropTable(
                name: "Qualifications");

            migrationBuilder.DropTable(
                name: "ScientificSpecialities");

            migrationBuilder.DropTable(
                name: "ScientificTitleIPDs");

            migrationBuilder.DropTable(
                name: "Specializations");

            migrationBuilder.DropTable(
                name: "Statements");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "TaskTypes");

            migrationBuilder.DropTable(
                name: "InstitutionNames");

            migrationBuilder.DropTable(
                name: "Reasons");

            migrationBuilder.DropTable(
                name: "Workers");

            migrationBuilder.DropTable(
                name: "Benefits");

            migrationBuilder.DropTable(
                name: "StudyForms");

            migrationBuilder.DropTable(
                name: "Streets");

            migrationBuilder.DropTable(
                name: "RelativeTypes");

            migrationBuilder.DropTable(
                name: "Specialities");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "InstitutionTypes");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "StreetTypes");

            migrationBuilder.DropTable(
                name: "Faculties");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "LocallityTypes");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
