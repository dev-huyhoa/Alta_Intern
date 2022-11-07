﻿// <auto-generated />
using System;
using CourseSignupSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CourseSignupSystem.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CourseSignupSystem.Models.ClassModel", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClassCode")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("ClassCourse")
                        .HasColumnType("int");

                    b.Property<string>("ClassCourseName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ClassDescription")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ClassName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("ClassQuantity")
                        .HasColumnType("int");

                    b.Property<int>("ClassQuantityPresent")
                        .HasColumnType("int");

                    b.Property<string>("ClassSchoolYear")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("ClassStatus")
                        .HasColumnType("bit");

                    b.Property<double>("ClassTuition")
                        .HasColumnType("float");

                    b.HasKey("ClassId");

                    b.HasIndex("ClassCourse");

                    b.ToTable("Class");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.CourseModel", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseCode")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("CourseEndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("CourseName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("CourseStartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("CourseId");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.DepartmentModel", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmentName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.ReceiptsModel", b =>
                {
                    b.Property<int>("ReceiptsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ReceiptsClassName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("ReceiptsDiscount")
                        .HasColumnType("int");

                    b.Property<double>("ReceiptsFee")
                        .HasColumnType("float");

                    b.Property<string>("ReceiptsNote")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("ReceiptsPayableFee")
                        .HasColumnType("float");

                    b.Property<double>("ReceiptsRateFee")
                        .HasColumnType("float");

                    b.Property<int>("ReceiptsStatus")
                        .HasColumnType("int");

                    b.Property<int>("ReceiptsStudentId")
                        .HasColumnType("int");

                    b.Property<double>("ReceiptsSurcharge")
                        .HasColumnType("float");

                    b.Property<string>("ReceiptsTraining")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ReceiptsTypeFee")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ReceiptsId");

                    b.HasIndex("ReceiptsStudentId");

                    b.ToTable("Receipts");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.RegisterClass", b =>
                {
                    b.Property<int>("RegisterClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("RegistClassDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RegisterClassCourse")
                        .HasColumnType("int");

                    b.Property<string>("RegisterClassCourseName")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("RegisterClassDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegisterClassStudentCode")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("RegisterClassStudentName")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<double>("RegisterClassTuition")
                        .HasColumnType("float");

                    b.Property<int>("RegisterUser")
                        .HasColumnType("int");

                    b.HasKey("RegisterClassId");

                    b.HasIndex("RegisterUser");

                    b.ToTable("RegisterClass");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.RoleModel", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.ScheduleHoliday", b =>
                {
                    b.Property<int>("ScheduleHolidayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ScheduleHolidayEndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ScheduleHolidayName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ScheduleHolidayReason")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ScheduleHolidayStartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ScheduleHolidayId");

                    b.ToTable("ScheduleHoliday");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.ScheduleModel", b =>
                {
                    b.Property<int>("ScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Schedule")
                        .HasColumnType("datetime2");

                    b.Property<int>("ScheduleClassId")
                        .HasColumnType("int");

                    b.Property<string>("ScheduleClassName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ScheduleEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ScheduleOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("ScheduleRoom")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ScheduleStartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ScheduleSubject")
                        .HasColumnType("int");

                    b.Property<string>("ScheduleSubjectName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ScheduleTeacherCode")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ScheduleTeacherName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ScheduleTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("ScheduleUser")
                        .HasColumnType("int");

                    b.Property<int?>("subjectModelSubjectId")
                        .HasColumnType("int");

                    b.HasKey("ScheduleId");

                    b.HasIndex("ScheduleUser");

                    b.HasIndex("subjectModelSubjectId");

                    b.ToTable("ScheduleTeacher");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.ScheduleStudent", b =>
                {
                    b.Property<int>("ScheduleStudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ScheduleClassId")
                        .HasColumnType("int");

                    b.Property<string>("ScheduleClassName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ScheduleEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ScheduleOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("ScheduleRoom")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ScheduleStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ScheduleStudentCode")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ScheduleStudentName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ScheduleSubject")
                        .HasColumnType("int");

                    b.Property<string>("ScheduleSubjectName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ScheduleUser")
                        .HasColumnType("int");

                    b.HasKey("ScheduleStudentId");

                    b.HasIndex("ScheduleUser");

                    b.ToTable("ScheduleStudent");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.ScoreDetail", b =>
                {
                    b.Property<int>("ScoreDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ScoreClassId")
                        .HasColumnType("int");

                    b.Property<float>("ScoreDetailMediumScore")
                        .HasColumnType("real");

                    b.Property<int>("ScoreDetailOral")
                        .HasColumnType("int");

                    b.Property<string>("ScoreStudentName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ScoreSubjectName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ScoreDetailId");

                    b.HasIndex("ScoreClassId");

                    b.HasIndex("ScoreDetailOral");

                    b.ToTable("ScoreDetails");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.ScoreModel", b =>
                {
                    b.Property<int>("ScoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ScoreCourse")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("ScoreQuantity")
                        .HasColumnType("int");

                    b.Property<int>("ScoreQuantityRequired")
                        .HasColumnType("int");

                    b.Property<int>("ScoreSubjectId")
                        .HasColumnType("int");

                    b.Property<string>("ScoreSubjectName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("ScoreType")
                        .HasColumnType("int");

                    b.Property<string>("ScoreTypeName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ScoreId");

                    b.HasIndex("ScoreSubjectId");

                    b.HasIndex("ScoreType");

                    b.ToTable("Score");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.ScoreOralTest", b =>
                {
                    b.Property<int>("ScoreOralTestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("ScoreFinalFisrt")
                        .HasColumnType("real");

                    b.Property<float>("ScoreFinalSecond")
                        .HasColumnType("real");

                    b.Property<float>("ScoreOralTestFifth")
                        .HasColumnType("real");

                    b.Property<float>("ScoreOralTestFisrt")
                        .HasColumnType("real");

                    b.Property<float>("ScoreOralTestFourth")
                        .HasColumnType("real");

                    b.Property<float>("ScoreOralTestSecond")
                        .HasColumnType("real");

                    b.Property<float>("ScoreOralTestThird")
                        .HasColumnType("real");

                    b.HasKey("ScoreOralTestId");

                    b.ToTable("ScoreOralTests");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.ScoreTypeModel", b =>
                {
                    b.Property<int>("ScoreTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ScoreTypeCoefficient")
                        .HasColumnType("int");

                    b.Property<string>("ScoreTypeName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ScoreTypeId");

                    b.ToTable("ScoreType");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.SubjectModel", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SubjectCode")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("SubjectCourse")
                        .HasColumnType("int");

                    b.Property<int>("SubjectDepartment")
                        .HasColumnType("int");

                    b.Property<string>("SubjectName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("SubjectId");

                    b.HasIndex("SubjectCourse");

                    b.HasIndex("SubjectDepartment");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.TurnoverModel", b =>
                {
                    b.Property<int>("TurnoverId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("TurnoverEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TurnoverStartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TurnoverStudent")
                        .HasColumnType("int");

                    b.Property<string>("TurnoverStudentClass")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TurnoverStudentCode")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TurnoverStudentName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TurnoverStudyDate")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TurnoverTeacher")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("TurnoverTotalTuition")
                        .HasColumnType("float");

                    b.Property<double>("TurnoverTuition")
                        .HasColumnType("float");

                    b.HasKey("TurnoverId");

                    b.ToTable("Turnover");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.UserModel", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("UserAddress")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("UserBirthday")
                        .HasColumnType("datetime2");

                    b.Property<bool>("UserBlock")
                        .HasColumnType("bit");

                    b.Property<int>("UserClass")
                        .HasColumnType("int");

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserFisrtName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("UserGender")
                        .HasColumnType("int");

                    b.Property<string>("UserImg")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("UserMainSubject")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("UserParentName")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("UserParttimeSubject")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("UserPassword")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("UserPhone")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<int>("UserRole")
                        .HasColumnType("int");

                    b.Property<string>("UserRoleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("UserStatus")
                        .HasColumnType("bit");

                    b.Property<string>("UserStudentCode")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("UserSurname")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("UserTaxCode")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("UserTeacherCode")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("classModelClassId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("UserRole");

                    b.HasIndex("classModelClassId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.ClassModel", b =>
                {
                    b.HasOne("CourseSignupSystem.Models.CourseModel", "courseModel")
                        .WithMany()
                        .HasForeignKey("ClassCourse")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("courseModel");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.ReceiptsModel", b =>
                {
                    b.HasOne("CourseSignupSystem.Models.UserModel", "userModel")
                        .WithMany()
                        .HasForeignKey("ReceiptsStudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("userModel");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.RegisterClass", b =>
                {
                    b.HasOne("CourseSignupSystem.Models.UserModel", "userModel")
                        .WithMany()
                        .HasForeignKey("RegisterUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("userModel");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.ScheduleModel", b =>
                {
                    b.HasOne("CourseSignupSystem.Models.UserModel", "userModel")
                        .WithMany()
                        .HasForeignKey("ScheduleUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CourseSignupSystem.Models.SubjectModel", "subjectModel")
                        .WithMany()
                        .HasForeignKey("subjectModelSubjectId");

                    b.Navigation("subjectModel");

                    b.Navigation("userModel");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.ScheduleStudent", b =>
                {
                    b.HasOne("CourseSignupSystem.Models.UserModel", "userModel")
                        .WithMany()
                        .HasForeignKey("ScheduleUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("userModel");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.ScoreDetail", b =>
                {
                    b.HasOne("CourseSignupSystem.Models.ClassModel", "classModel")
                        .WithMany()
                        .HasForeignKey("ScoreClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CourseSignupSystem.Models.ScoreOralTest", "scoreOralTest")
                        .WithMany()
                        .HasForeignKey("ScoreDetailOral")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("classModel");

                    b.Navigation("scoreOralTest");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.ScoreModel", b =>
                {
                    b.HasOne("CourseSignupSystem.Models.SubjectModel", "subjectModel")
                        .WithMany()
                        .HasForeignKey("ScoreSubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CourseSignupSystem.Models.ScoreTypeModel", "scoreTypeModel")
                        .WithMany()
                        .HasForeignKey("ScoreType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("scoreTypeModel");

                    b.Navigation("subjectModel");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.SubjectModel", b =>
                {
                    b.HasOne("CourseSignupSystem.Models.CourseModel", "courseModel")
                        .WithMany()
                        .HasForeignKey("SubjectCourse")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CourseSignupSystem.Models.DepartmentModel", "departmentModel")
                        .WithMany()
                        .HasForeignKey("SubjectDepartment")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("courseModel");

                    b.Navigation("departmentModel");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.UserModel", b =>
                {
                    b.HasOne("CourseSignupSystem.Models.RoleModel", "roleModel")
                        .WithMany()
                        .HasForeignKey("UserRole")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CourseSignupSystem.Models.ClassModel", "classModel")
                        .WithMany("userModel")
                        .HasForeignKey("classModelClassId");

                    b.Navigation("classModel");

                    b.Navigation("roleModel");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.ClassModel", b =>
                {
                    b.Navigation("userModel");
                });
#pragma warning restore 612, 618
        }
    }
}