﻿// <auto-generated />
using System;
using Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Core.Migrations
{
    [DbContext(typeof(ImpressoDbContext))]
    partial class ImpressoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Core.Entities.Accomplishment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AppUserId")
                        .IsRequired();

                    b.Property<string>("Content")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Accomplishments");
                });

            modelBuilder.Entity("Core.Entities.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("AdditionalInformation");

                    b.Property<string>("CV");

                    b.Property<string>("CompanyPosition");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("EthereumAddress");

                    b.Property<int>("ExperienceId");

                    b.Property<string>("FirstName");

                    b.Property<int>("IndustryId");

                    b.Property<string>("Intro");

                    b.Property<int>("JobTypeId");

                    b.Property<string>("LastName");

                    b.Property<DateTime>("LastUpdate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Location");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("Passion");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PersonalityMatch");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("Photo");

                    b.Property<string>("Profession");

                    b.Property<decimal?>("Salary");

                    b.Property<string>("SecurityStamp");

                    b.Property<int>("StatusId");

                    b.Property<int>("Tokens")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Core.Entities.AppUserCertificate", b =>
                {
                    b.Property<string>("AppUserId");

                    b.Property<int>("CertificateId");

                    b.HasKey("AppUserId", "CertificateId");

                    b.HasIndex("CertificateId");

                    b.ToTable("AppUserCertificates");
                });

            modelBuilder.Entity("Core.Entities.AppUserEducation", b =>
                {
                    b.Property<string>("AppUserId");

                    b.Property<int>("EducationId");

                    b.HasKey("AppUserId", "EducationId");

                    b.HasIndex("EducationId");

                    b.ToTable("AppUserEducations");
                });

            modelBuilder.Entity("Core.Entities.AppUserJob", b =>
                {
                    b.Property<string>("AppUserId");

                    b.Property<int>("JobId");

                    b.Property<DateTime>("DateOfPost")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NOW()");

                    b.Property<bool>("IsConnected");

                    b.HasKey("AppUserId", "JobId");

                    b.HasIndex("JobId");

                    b.ToTable("AppUserJobs");
                });

            modelBuilder.Entity("Core.Entities.AppUserSkill", b =>
                {
                    b.Property<string>("AppUserId");

                    b.Property<int>("SkillId");

                    b.Property<bool>("IsTop");

                    b.HasKey("AppUserId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("AppUserSkills");
                });

            modelBuilder.Entity("Core.Entities.BlockedUser", b =>
                {
                    b.Property<string>("AppUserId");

                    b.Property<string>("BlockedAppUserId");

                    b.HasKey("AppUserId", "BlockedAppUserId");

                    b.HasIndex("BlockedAppUserId");

                    b.ToTable("BlockedUsers");
                });

            modelBuilder.Entity("Core.Entities.BookmarkedJob", b =>
                {
                    b.Property<string>("AppUserId");

                    b.Property<int>("JobId");

                    b.Property<DateTime>("BookmarkedData")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NOW()");

                    b.HasKey("AppUserId", "JobId");

                    b.HasIndex("JobId");

                    b.ToTable("BookmarkedJobs");
                });

            modelBuilder.Entity("Core.Entities.BookmarkedUser", b =>
                {
                    b.Property<string>("AppUserId");

                    b.Property<string>("BookmarkedAppUserId");

                    b.Property<DateTime>("BookmarkedData")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NOW()");

                    b.HasKey("AppUserId", "BookmarkedAppUserId");

                    b.HasIndex("BookmarkedAppUserId");

                    b.ToTable("BookmarkedUsers");
                });

            modelBuilder.Entity("Core.Entities.Certificate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Certificates");
                });

            modelBuilder.Entity("Core.Entities.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IndustryId");

                    b.Property<string>("Intro");

                    b.Property<DateTime>("LastUpdate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NOW()");

                    b.Property<string>("Location");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Photo");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Core.Entities.CompanyAppUser", b =>
                {
                    b.Property<int>("CompanyId");

                    b.Property<string>("AppUserId");

                    b.Property<bool>("IsWorkingNow")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.HasKey("CompanyId", "AppUserId");

                    b.HasIndex("AppUserId");

                    b.ToTable("CompanyAppUsers");
                });

            modelBuilder.Entity("Core.Entities.CompanyCertificate", b =>
                {
                    b.Property<int>("CompanyId");

                    b.Property<int>("CertificateId");

                    b.HasKey("CompanyId", "CertificateId");

                    b.HasIndex("CertificateId");

                    b.ToTable("CompanyCertificates");
                });

            modelBuilder.Entity("Core.Entities.ConnectedUser", b =>
                {
                    b.Property<string>("AppUserId");

                    b.Property<string>("ConnectedAppUserId");

                    b.Property<string>("Reason");

                    b.HasKey("AppUserId", "ConnectedAppUserId");

                    b.HasIndex("ConnectedAppUserId");

                    b.ToTable("ConnectedUsers");
                });

            modelBuilder.Entity("Core.Entities.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("Core.Entities.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<int>("CompanyId");

                    b.Property<string>("Country");

                    b.Property<string>("Description");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("PictureSource");

                    b.Property<int>("PrivacyTypeId");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Core.Entities.InterestedEvent", b =>
                {
                    b.Property<string>("AppUserId");

                    b.Property<int>("EventId");

                    b.Property<DateTime>("BookmarkedData")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NOW()");

                    b.HasKey("AppUserId", "EventId");

                    b.HasIndex("EventId");

                    b.ToTable("InterestedEvents");
                });

            modelBuilder.Entity("Core.Entities.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateOfPost")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NOW()");

                    b.Property<string>("Description");

                    b.Property<DateTime>("EndDate");

                    b.Property<int>("ExperienceId");

                    b.Property<int>("IndustryId");

                    b.Property<int>("JobTypeId");

                    b.Property<string>("Location");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("PersonalityMatch");

                    b.Property<string>("Photo");

                    b.Property<int>("ProjectId");

                    b.Property<string>("Responsibility");

                    b.Property<decimal?>("Salary");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("Title");

                    b.Property<int>("TypeOfWorkId");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("Core.Entities.JobCertificate", b =>
                {
                    b.Property<int>("JobId");

                    b.Property<int>("CertificateId");

                    b.HasKey("JobId", "CertificateId");

                    b.HasIndex("CertificateId");

                    b.ToTable("JobCertificates");
                });

            modelBuilder.Entity("Core.Entities.JobSkill", b =>
                {
                    b.Property<int>("JobId");

                    b.Property<int>("SkillId");

                    b.HasKey("JobId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("JobSkills");
                });

            modelBuilder.Entity("Core.Entities.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("ExceptionMessage");

                    b.Property<string>("InnerExceptionMessage");

                    b.Property<string>("Message");

                    b.Property<string>("StackTrace");

                    b.HasKey("Id");

                    b.ToTable("Loggs");
                });

            modelBuilder.Entity("Core.Entities.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AppUserId")
                        .IsRequired();

                    b.Property<DateTime>("DateOfPost")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NOW()");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<bool>("IsNewest")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("Core.Entities.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CompanyId");

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime>("StartDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NOW()");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Core.Entities.ProjectAppUser", b =>
                {
                    b.Property<int>("ProjectId");

                    b.Property<string>("AppUserId");

                    b.HasKey("ProjectId", "AppUserId");

                    b.HasIndex("AppUserId");

                    b.ToTable("ProjectAppUsers");
                });

            modelBuilder.Entity("Core.Entities.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("Core.Entities.Testimonial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<DateTime>("DateOfPost")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NOW()");

                    b.Property<string>("RecommendedUserId");

                    b.Property<string>("RecommenderId");

                    b.HasKey("Id");

                    b.HasIndex("RecommendedUserId");

                    b.HasIndex("RecommenderId");

                    b.ToTable("Testimonials");
                });

            modelBuilder.Entity("Core.Entities.TokenLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Count");

                    b.Property<DateTime>("DepartureDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NOW()");

                    b.Property<string>("Message");

                    b.Property<string>("ReceiverId")
                        .IsRequired();

                    b.Property<string>("SenderId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("SenderId");

                    b.ToTable("TokenLogs");
                });

            modelBuilder.Entity("Core.Entities.Verificator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AppUserId")
                        .IsRequired();

                    b.Property<int>("TestimonialId");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("TestimonialId");

                    b.ToTable("Verificators");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Core.Entities.Accomplishment", b =>
                {
                    b.HasOne("Core.Entities.AppUser", "AppUser")
                        .WithMany("Accomplishments")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core.Entities.AppUserCertificate", b =>
                {
                    b.HasOne("Core.Entities.AppUser", "AppUser")
                        .WithMany("AppUserCertificates")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Core.Entities.Certificate", "Certificate")
                        .WithMany("AppUserCertificates")
                        .HasForeignKey("CertificateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core.Entities.AppUserEducation", b =>
                {
                    b.HasOne("Core.Entities.AppUser", "AppUser")
                        .WithMany("AppUserEducations")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Core.Entities.Education", "Education")
                        .WithMany("AppUserEducations")
                        .HasForeignKey("EducationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core.Entities.AppUserJob", b =>
                {
                    b.HasOne("Core.Entities.AppUser", "AppUser")
                        .WithMany("AppUserJobs")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Core.Entities.Job", "Job")
                        .WithMany("AppUserJobs")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core.Entities.AppUserSkill", b =>
                {
                    b.HasOne("Core.Entities.AppUser", "AppUser")
                        .WithMany("AppUserSkills")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Core.Entities.Skill", "Skill")
                        .WithMany("AppUserSkills")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core.Entities.BlockedUser", b =>
                {
                    b.HasOne("Core.Entities.AppUser", "AppUser")
                        .WithMany("BlockedUsers")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Core.Entities.AppUser", "BlockedAppUser")
                        .WithMany("BlockedByUsers")
                        .HasForeignKey("BlockedAppUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core.Entities.BookmarkedJob", b =>
                {
                    b.HasOne("Core.Entities.AppUser", "AppUser")
                        .WithMany("BookmarkedJobs")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Core.Entities.Job", "Job")
                        .WithMany("BookmarkedJobs")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core.Entities.BookmarkedUser", b =>
                {
                    b.HasOne("Core.Entities.AppUser", "AppUser")
                        .WithMany("BookmarkedUsers")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Core.Entities.AppUser", "BookmarkedAppUser")
                        .WithMany("BookmarkedByUsers")
                        .HasForeignKey("BookmarkedAppUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core.Entities.CompanyAppUser", b =>
                {
                    b.HasOne("Core.Entities.AppUser", "AppUser")
                        .WithMany("CompanyAppUsers")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Core.Entities.Company", "Company")
                        .WithMany("CompanyAppUsers")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core.Entities.CompanyCertificate", b =>
                {
                    b.HasOne("Core.Entities.Certificate", "Certificate")
                        .WithMany("CompanyCertificates")
                        .HasForeignKey("CertificateId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Core.Entities.Company", "Company")
                        .WithMany("CompanyCertificates")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core.Entities.ConnectedUser", b =>
                {
                    b.HasOne("Core.Entities.AppUser", "AppUser")
                        .WithMany("ConnectedUsers")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Core.Entities.AppUser", "ConnectedAppUser")
                        .WithMany("ConnectedByUsers")
                        .HasForeignKey("ConnectedAppUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core.Entities.Event", b =>
                {
                    b.HasOne("Core.Entities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core.Entities.InterestedEvent", b =>
                {
                    b.HasOne("Core.Entities.AppUser", "AppUser")
                        .WithMany("InterestedEvents")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Core.Entities.Event", "Event")
                        .WithMany("InterestedEvents")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core.Entities.Job", b =>
                {
                    b.HasOne("Core.Entities.Project", "Project")
                        .WithMany("Jobs")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core.Entities.JobCertificate", b =>
                {
                    b.HasOne("Core.Entities.Certificate", "Certificate")
                        .WithMany("JobCertificates")
                        .HasForeignKey("CertificateId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Core.Entities.Job", "Job")
                        .WithMany("JobCertificates")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core.Entities.JobSkill", b =>
                {
                    b.HasOne("Core.Entities.Job", "Job")
                        .WithMany("JobSkills")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Core.Entities.Skill", "Skill")
                        .WithMany("JobSkills")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core.Entities.Notification", b =>
                {
                    b.HasOne("Core.Entities.AppUser", "AppUser")
                        .WithMany("Notifications")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core.Entities.Project", b =>
                {
                    b.HasOne("Core.Entities.Company", "Company")
                        .WithMany("Projects")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core.Entities.ProjectAppUser", b =>
                {
                    b.HasOne("Core.Entities.AppUser", "AppUser")
                        .WithMany("ProjectAppUsers")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Core.Entities.Project", "Project")
                        .WithMany("ProjectAppUsers")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core.Entities.Testimonial", b =>
                {
                    b.HasOne("Core.Entities.AppUser", "RecommendedUser")
                        .WithMany("ReceivedTestimonials")
                        .HasForeignKey("RecommendedUserId");

                    b.HasOne("Core.Entities.AppUser", "Recommender")
                        .WithMany("SentTestimonials")
                        .HasForeignKey("RecommenderId");
                });

            modelBuilder.Entity("Core.Entities.TokenLog", b =>
                {
                    b.HasOne("Core.Entities.AppUser", "Receiver")
                        .WithMany("ReceivedTokens")
                        .HasForeignKey("ReceiverId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Core.Entities.AppUser", "Sender")
                        .WithMany("SendedTokens")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core.Entities.Verificator", b =>
                {
                    b.HasOne("Core.Entities.AppUser", "AppUser")
                        .WithMany("VerificatedTestimonials")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Core.Entities.Testimonial", "Testimonial")
                        .WithMany("Verificators")
                        .HasForeignKey("TestimonialId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Core.Entities.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Core.Entities.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Core.Entities.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Core.Entities.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
