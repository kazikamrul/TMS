using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SchoolManagement.Api.Models
{
    public partial class SchoolManagementdb1Context : DbContext
    {
        public SchoolManagementdb1Context()
        {
        }

        public SchoolManagementdb1Context(DbContextOptions<SchoolManagementdb1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountType> AccountTypes { get; set; }
        public virtual DbSet<AdminAuthority> AdminAuthorities { get; set; }
        public virtual DbSet<Allowance> Allowances { get; set; }
        public virtual DbSet<AllowanceCategory> AllowanceCategories { get; set; }
        public virtual DbSet<AllowancePercentage> AllowancePercentages { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual DbSet<Assessment> Assessments { get; set; }
        public virtual DbSet<AssignmentMarkEntry> AssignmentMarkEntries { get; set; }
        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<BaseName> BaseNames { get; set; }
        public virtual DbSet<BaseSchoolName> BaseSchoolNames { get; set; }
        public virtual DbSet<BloodGroup> BloodGroups { get; set; }
        public virtual DbSet<BnaAttendancePeriod> BnaAttendancePeriods { get; set; }
        public virtual DbSet<BnaAttendanceRemark> BnaAttendanceRemarks { get; set; }
        public virtual DbSet<BnaBatch> BnaBatches { get; set; }
        public virtual DbSet<BnaClassSchedule> BnaClassSchedules { get; set; }
        public virtual DbSet<BnaClassScheduleStatus> BnaClassScheduleStatuses { get; set; }
        public virtual DbSet<BnaClassSectionSelection> BnaClassSectionSelections { get; set; }
        public virtual DbSet<BnaClassTest> BnaClassTests { get; set; }
        public virtual DbSet<BnaClassTestType> BnaClassTestTypes { get; set; }
        public virtual DbSet<BnaCurriculumType> BnaCurriculumTypes { get; set; }
        public virtual DbSet<BnaCurriculumUpdate> BnaCurriculumUpdates { get; set; }
        public virtual DbSet<BnaExamAttendance> BnaExamAttendances { get; set; }
        public virtual DbSet<BnaExamInstructorAssign> BnaExamInstructorAssigns { get; set; }
        public virtual DbSet<BnaExamMark> BnaExamMarks { get; set; }
        public virtual DbSet<BnaExamRoutineLog> BnaExamRoutineLogs { get; set; }
        public virtual DbSet<BnaExamSchedule> BnaExamSchedules { get; set; }
        public virtual DbSet<BnaInstructorType> BnaInstructorTypes { get; set; }
        public virtual DbSet<BnaPromotionLog> BnaPromotionLogs { get; set; }
        public virtual DbSet<BnaPromotionStatus> BnaPromotionStatuses { get; set; }
        public virtual DbSet<BnaSemester> BnaSemesters { get; set; }
        public virtual DbSet<BnaSemesterDuration> BnaSemesterDurations { get; set; }
        public virtual DbSet<BnaServiceType> BnaServiceTypes { get; set; }
        public virtual DbSet<BnaSubjectCurriculum> BnaSubjectCurricula { get; set; }
        public virtual DbSet<BnaSubjectName> BnaSubjectNames { get; set; }
        public virtual DbSet<Board> Boards { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<BudgetAllocation> BudgetAllocations { get; set; }
        public virtual DbSet<BudgetCode> BudgetCodes { get; set; }
        public virtual DbSet<BudgetType> BudgetTypes { get; set; }
        public virtual DbSet<Bulletin> Bulletins { get; set; }
        public virtual DbSet<Caste> Castes { get; set; }
        public virtual DbSet<ClassInstructorAssign> ClassInstructorAssigns { get; set; }
        public virtual DbSet<ClassPeriod> ClassPeriods { get; set; }
        public virtual DbSet<ClassRoutine> ClassRoutines { get; set; }
        public virtual DbSet<ClassType> ClassTypes { get; set; }
        public virtual DbSet<CoCurricularActivity> CoCurricularActivities { get; set; }
        public virtual DbSet<CoCurricularActivityType> CoCurricularActivityTypes { get; set; }
        public virtual DbSet<CodeValue> CodeValues { get; set; }
        public virtual DbSet<CodeValueType> CodeValueTypes { get; set; }
        public virtual DbSet<ColorOfEye> ColorOfEyes { get; set; }
        public virtual DbSet<Complexion> Complexions { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<CountryGroup> CountryGroups { get; set; }
        public virtual DbSet<CourseBudgetAllocation> CourseBudgetAllocations { get; set; }
        public virtual DbSet<CourseDuration> CourseDurations { get; set; }
        public virtual DbSet<CourseGradingEntry> CourseGradingEntries { get; set; }
        public virtual DbSet<CourseInstructor> CourseInstructors { get; set; }
        public virtual DbSet<CourseModule> CourseModules { get; set; }
        public virtual DbSet<CourseName> CourseNames { get; set; }
        public virtual DbSet<CoursePlanCreate> CoursePlanCreates { get; set; }
        public virtual DbSet<CourseSection> CourseSections { get; set; }
        public virtual DbSet<CourseTask> CourseTasks { get; set; }
        public virtual DbSet<CourseType> CourseTypes { get; set; }
        public virtual DbSet<CourseWeek> CourseWeeks { get; set; }
        public virtual DbSet<CovidVaccine> CovidVaccines { get; set; }
        public virtual DbSet<CurrencyName> CurrencyNames { get; set; }
        public virtual DbSet<DefenseType> DefenseTypes { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Division> Divisions { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<DocumentType> DocumentTypes { get; set; }
        public virtual DbSet<DojBod> DojBods { get; set; }
        public virtual DbSet<DownloadRight> DownloadRights { get; set; }
        public virtual DbSet<EducationalInstitution> EducationalInstitutions { get; set; }
        public virtual DbSet<EducationalQualification> EducationalQualifications { get; set; }
        public virtual DbSet<Elected> Electeds { get; set; }
        public virtual DbSet<Election> Elections { get; set; }
        public virtual DbSet<EmploymentBeforeJoinBna> EmploymentBeforeJoinBnas { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<ExamAttemptType> ExamAttemptTypes { get; set; }
        public virtual DbSet<ExamCenter> ExamCenters { get; set; }
        public virtual DbSet<ExamCenterSelection> ExamCenterSelections { get; set; }
        public virtual DbSet<ExamMarkRemark> ExamMarkRemarks { get; set; }
        public virtual DbSet<ExamPeriodType> ExamPeriodTypes { get; set; }
        public virtual DbSet<ExamType> ExamTypes { get; set; }
        public virtual DbSet<FailureStatus> FailureStatuses { get; set; }
        public virtual DbSet<FamilyInfo> FamilyInfos { get; set; }
        public virtual DbSet<FamilyNomination> FamilyNominations { get; set; }
        public virtual DbSet<Favorite> Favorites { get; set; }
        public virtual DbSet<FavoritesType> FavoritesTypes { get; set; }
        public virtual DbSet<Feature> Features { get; set; }
        public virtual DbSet<FiscalYear> FiscalYears { get; set; }
        public virtual DbSet<ForceType> ForceTypes { get; set; }
        public virtual DbSet<ForeignCourseDocType> ForeignCourseDocTypes { get; set; }
        public virtual DbSet<ForeignCourseGoinfo> ForeignCourseGoinfos { get; set; }
        public virtual DbSet<ForeignCourseOtherDoc> ForeignCourseOtherDocs { get; set; }
        public virtual DbSet<ForeignCourseOthersDocument> ForeignCourseOthersDocuments { get; set; }
        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<GameSport> GameSports { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<GrandFather> GrandFathers { get; set; }
        public virtual DbSet<GrandFatherType> GrandFatherTypes { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<GuestSpeakerActionStatus> GuestSpeakerActionStatuses { get; set; }
        public virtual DbSet<GuestSpeakerGroupResult> GuestSpeakerGroupResults { get; set; }
        public virtual DbSet<GuestSpeakerQuationGroup> GuestSpeakerQuationGroups { get; set; }
        public virtual DbSet<GuestSpeakerQuestionName> GuestSpeakerQuestionNames { get; set; }
        public virtual DbSet<HairColor> HairColors { get; set; }
        public virtual DbSet<Height> Heights { get; set; }
        public virtual DbSet<IndividualBulletin> IndividualBulletins { get; set; }
        public virtual DbSet<IndividualNotice> IndividualNotices { get; set; }
        public virtual DbSet<InstallmentPaidDetail> InstallmentPaidDetails { get; set; }
        public virtual DbSet<InstructorAssignment> InstructorAssignments { get; set; }
        public virtual DbSet<InterServiceCourseDocType> InterServiceCourseDocTypes { get; set; }
        public virtual DbSet<InterServiceCourseReport> InterServiceCourseReports { get; set; }
        public virtual DbSet<InterServiceMark> InterServiceMarks { get; set; }
        public virtual DbSet<InterServiceOthersDoc> InterServiceOthersDocs { get; set; }
        public virtual DbSet<JoiningReason> JoiningReasons { get; set; }
        public virtual DbSet<KindOfSubject> KindOfSubjects { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<MaritalStatus> MaritalStatuses { get; set; }
        public virtual DbSet<MarkType> MarkTypes { get; set; }
        public virtual DbSet<MemberShipType> MemberShipTypes { get; set; }
        public virtual DbSet<MigrationDocument> MigrationDocuments { get; set; }
        public virtual DbSet<MilitaryTraining> MilitaryTrainings { get; set; }
        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<Nationality> Nationalities { get; set; }
        public virtual DbSet<NewAtempt> NewAtempts { get; set; }
        public virtual DbSet<NewEntryEvaluation> NewEntryEvaluations { get; set; }
        public virtual DbSet<Notice> Notices { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<Occupation> Occupations { get; set; }
        public virtual DbSet<OrganizationName> OrganizationNames { get; set; }
        public virtual DbSet<ParentRelative> ParentRelatives { get; set; }
        public virtual DbSet<PaymentDetail> PaymentDetails { get; set; }
        public virtual DbSet<PaymentType> PaymentTypes { get; set; }
        public virtual DbSet<PresentBillet> PresentBillets { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<QuestionType> QuestionTypes { get; set; }
        public virtual DbSet<Rank> Ranks { get; set; }
        public virtual DbSet<ReadingMaterial> ReadingMaterials { get; set; }
        public virtual DbSet<ReadingMaterialTitle> ReadingMaterialTitles { get; set; }
        public virtual DbSet<ReasonType> ReasonTypes { get; set; }
        public virtual DbSet<RecordOfService> RecordOfServices { get; set; }
        public virtual DbSet<RelationType> RelationTypes { get; set; }
        public virtual DbSet<Religion> Religions { get; set; }
        public virtual DbSet<ResultStatus> ResultStatuses { get; set; }
        public virtual DbSet<RoleFeature> RoleFeatures { get; set; }
        public virtual DbSet<RoutineNote> RoutineNotes { get; set; }
        public virtual DbSet<RoutineSoftCopyUpload> RoutineSoftCopyUploads { get; set; }
        public virtual DbSet<SaylorBranch> SaylorBranches { get; set; }
        public virtual DbSet<SaylorRank> SaylorRanks { get; set; }
        public virtual DbSet<SaylorSubBranch> SaylorSubBranches { get; set; }
        public virtual DbSet<SocialMediaType> SocialMediaTypes { get; set; }
        public virtual DbSet<SocialMedium> SocialMedia { get; set; }
        public virtual DbSet<StepRelation> StepRelations { get; set; }
        public virtual DbSet<SubjectCategory> SubjectCategories { get; set; }
        public virtual DbSet<SubjectClassification> SubjectClassifications { get; set; }
        public virtual DbSet<SubjectCurriculum> SubjectCurricula { get; set; }
        public virtual DbSet<SubjectMark> SubjectMarks { get; set; }
        public virtual DbSet<SubjectType> SubjectTypes { get; set; }
        public virtual DbSet<SwimmingDriving> SwimmingDrivings { get; set; }
        public virtual DbSet<SwimmingDrivingLevel> SwimmingDrivingLevels { get; set; }
        public virtual DbSet<TdecActionStatus> TdecActionStatuses { get; set; }
        public virtual DbSet<TdecGroupResult> TdecGroupResults { get; set; }
        public virtual DbSet<TdecQuationGroup> TdecQuationGroups { get; set; }
        public virtual DbSet<TdecQuestionName> TdecQuestionNames { get; set; }
        public virtual DbSet<Thana> Thanas { get; set; }
        public virtual DbSet<TraineeAssessmentCreate> TraineeAssessmentCreates { get; set; }
        public virtual DbSet<TraineeAssessmentMark> TraineeAssessmentMarks { get; set; }
        public virtual DbSet<TraineeAssignmentSubmit> TraineeAssignmentSubmits { get; set; }
        public virtual DbSet<TraineeAssissmentGroup> TraineeAssissmentGroups { get; set; }
        public virtual DbSet<TraineeBioDataGeneralInfo> TraineeBioDataGeneralInfos { get; set; }
        public virtual DbSet<TraineeBioDataOther> TraineeBioDataOthers { get; set; }
        public virtual DbSet<TraineeCourseStatus> TraineeCourseStatuses { get; set; }
        public virtual DbSet<TraineeLanguage> TraineeLanguages { get; set; }
        public virtual DbSet<TraineeMembership> TraineeMemberships { get; set; }
        public virtual DbSet<TraineeNomination> TraineeNominations { get; set; }
        public virtual DbSet<TraineePicture> TraineePictures { get; set; }
        public virtual DbSet<TraineeSectionSelection> TraineeSectionSelections { get; set; }
        public virtual DbSet<TraineeStatus> TraineeStatuses { get; set; }
        public virtual DbSet<TraineeVisitedAboard> TraineeVisitedAboards { get; set; }
        public virtual DbSet<TrainingObjective> TrainingObjectives { get; set; }
        public virtual DbSet<TrainingSyllabus> TrainingSyllabi { get; set; }
        public virtual DbSet<UserManual> UserManuals { get; set; }
        public virtual DbSet<UtofficerCategory> UtofficerCategories { get; set; }
        public virtual DbSet<UtofficerType> UtofficerTypes { get; set; }
        public virtual DbSet<WeekName> WeekNames { get; set; }
        public virtual DbSet<Weight> Weights { get; set; }
        public virtual DbSet<WithdrawnDoc> WithdrawnDocs { get; set; }
        public virtual DbSet<WithdrawnType> WithdrawnTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=114.134.95.235,1434;Database=SchoolManagementdb1;user id=sa;password=B@ngl@d3sh;Trusted_Connection=false;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountType>(entity =>
            {
                entity.ToTable("AccountType");

                entity.Property(e => e.AccoutType).HasMaxLength(450);

                entity.Property(e => e.CreatedBy).HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AdminAuthority>(entity =>
            {
                entity.ToTable("AdminAuthority");

                entity.Property(e => e.AdminAuthorityName)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Allowance>(entity =>
            {
                entity.ToTable("Allowance");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DurationFrom).HasColumnType("datetime");

                entity.Property(e => e.DurationTo).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProvideByAuthority).HasMaxLength(450);

                entity.Property(e => e.Vacancy).HasMaxLength(250);

                entity.HasOne(d => d.AllowanceCategory)
                    .WithMany(p => p.Allowances)
                    .HasForeignKey(d => d.AllowanceCategoryId)
                    .HasConstraintName("FK_Allowance_AllowanceCategory");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Allowances)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Allowance_Country");

                entity.HasOne(d => d.CourseName)
                    .WithMany(p => p.Allowances)
                    .HasForeignKey(d => d.CourseNameId)
                    .HasConstraintName("FK_Allowance_CourseName");

                entity.HasOne(d => d.FromRank)
                    .WithMany(p => p.AllowanceFromRanks)
                    .HasForeignKey(d => d.FromRankId)
                    .HasConstraintName("FK_Allowance_Rank");

                entity.HasOne(d => d.ToRank)
                    .WithMany(p => p.AllowanceToRanks)
                    .HasForeignKey(d => d.ToRankId)
                    .HasConstraintName("FK_Allowance_Rank1");
            });

            modelBuilder.Entity<AllowanceCategory>(entity =>
            {
                entity.ToTable("AllowanceCategory");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.AllowancePercentage)
                    .WithMany(p => p.AllowanceCategories)
                    .HasForeignKey(d => d.AllowancePercentageId)
                    .HasConstraintName("FK_AllowanceCategory_AllowancePercentage");

                entity.HasOne(d => d.CountryGroup)
                    .WithMany(p => p.AllowanceCategories)
                    .HasForeignKey(d => d.CountryGroupId)
                    .HasConstraintName("FK_AllowanceCategory_CountryGroup");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.AllowanceCategories)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_AllowanceCategory_Country");

                entity.HasOne(d => d.CurrencyName)
                    .WithMany(p => p.AllowanceCategories)
                    .HasForeignKey(d => d.CurrencyNameId)
                    .HasConstraintName("FK_AllowanceCategory_CurrencyName");

                entity.HasOne(d => d.FromRank)
                    .WithMany(p => p.AllowanceCategoryFromRanks)
                    .HasForeignKey(d => d.FromRankId)
                    .HasConstraintName("FK_AllowanceCategory_Rank");

                entity.HasOne(d => d.ToRank)
                    .WithMany(p => p.AllowanceCategoryToRanks)
                    .HasForeignKey(d => d.ToRankId)
                    .HasConstraintName("FK_AllowanceCategory_Rank1");
            });

            modelBuilder.Entity<AllowancePercentage>(entity =>
            {
                entity.ToTable("AllowancePercentage");

                entity.Property(e => e.AllowanceName).HasMaxLength(450);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Percentage).HasMaxLength(450);
            });

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRoleClaim>(entity =>
            {
                entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.BranchId).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.InActiveDate).HasColumnType("datetime");

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.Pno).HasColumnName("PNo");

                entity.Property(e => e.RoleName).HasMaxLength(100);

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.Users)
                    .UsingEntity<Dictionary<string, object>>(
                        "AspNetUserRole",
                        l => l.HasOne<AspNetRole>().WithMany().HasForeignKey("RoleId"),
                        r => r.HasOne<AspNetUser>().WithMany().HasForeignKey("UserId"),
                        j =>
                        {
                            j.HasKey("UserId", "RoleId");

                            j.ToTable("AspNetUserRoles");

                            j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");
                        });
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Assessment>(entity =>
            {
                entity.ToTable("Assessment");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(450);
            });

            modelBuilder.Entity<AssignmentMarkEntry>(entity =>
            {
                entity.ToTable("AssignmentMarkEntry");

                entity.Property(e => e.CreatedBy).HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.TraineeAssignmentSubmit)
                    .WithMany(p => p.AssignmentMarkEntries)
                    .HasForeignKey(d => d.TraineeAssignmentSubmitId)
                    .HasConstraintName("FK_AssignmentMarkEntry_TraineeAssignmentSubmit");
            });

            modelBuilder.Entity<Attendance>(entity =>
            {
                entity.ToTable("Attendance");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.ApprovedUser).HasMaxLength(450);

                entity.Property(e => e.AttendanceDate).HasColumnType("datetime");

                entity.Property(e => e.ClassLeaderName).HasMaxLength(450);

                entity.Property(e => e.CreatedBy).HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.ExamDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.BaseSchoolName)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.BaseSchoolNameId)
                    .HasConstraintName("FK_Attendance_BaseSchoolName");

                entity.HasOne(d => d.BnaAttendanceRemarks)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.BnaAttendanceRemarksId)
                    .HasConstraintName("FK_Attendance_BnaAttendanceRemarks");

                entity.HasOne(d => d.BnaExamSchedule)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.BnaExamScheduleId)
                    .HasConstraintName("FK_Attendance_BnaExamSchedule");

                entity.HasOne(d => d.BnaSemesterDuration)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.BnaSemesterDurationId)
                    .HasConstraintName("FK_Attendance_BnaSemesterDuration");

                entity.HasOne(d => d.BnaSemester)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.BnaSemesterId)
                    .HasConstraintName("FK_Attendance_BnaSemester");

                entity.HasOne(d => d.BnaSubjectName)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.BnaSubjectNameId)
                    .HasConstraintName("FK_Attendance_BnaSubjectName");

                entity.HasOne(d => d.ClassPeriod)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.ClassPeriodId)
                    .HasConstraintName("FK_Attendance_ClassPeriod");

                entity.HasOne(d => d.ClassRoutine)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.ClassRoutineId)
                    .HasConstraintName("FK_Attendance_ClassRoutine");

                entity.HasOne(d => d.CourseDuration)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.CourseDurationId)
                    .HasConstraintName("FK_Attendance_CourseDuration");

                entity.HasOne(d => d.CourseName)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.CourseNameId)
                    .HasConstraintName("FK_Attendance_CourseName");

                entity.HasOne(d => d.ExamType)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.ExamTypeId)
                    .HasConstraintName("FK_Attendance_ExamType");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_Attendance_TraineeBioDataGeneralInfo");
            });

            modelBuilder.Entity<BaseName>(entity =>
            {
                entity.ToTable("BaseName");

                entity.Property(e => e.BaseLogo).HasMaxLength(450);

                entity.Property(e => e.BaseNames)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ShortName).HasMaxLength(450);

                entity.HasOne(d => d.AdminAuthority)
                    .WithMany(p => p.BaseNames)
                    .HasForeignKey(d => d.AdminAuthorityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BaseName_AdminAuthority");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.BaseNames)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_BaseName_District");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.BaseNames)
                    .HasForeignKey(d => d.DivisionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BaseName_Division");

                entity.HasOne(d => d.ForceType)
                    .WithMany(p => p.BaseNames)
                    .HasForeignKey(d => d.ForceTypeId)
                    .HasConstraintName("FK_BaseName_ForceType");
            });

            modelBuilder.Entity<BaseSchoolName>(entity =>
            {
                entity.ToTable("BaseSchoolName");

                entity.Property(e => e.Address)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Cellphone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SchoolHistory)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.SchoolLogo).HasMaxLength(450);

                entity.Property(e => e.SchoolName).HasMaxLength(450);

                entity.Property(e => e.ServerName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName).HasMaxLength(450);

                entity.Property(e => e.Telephone)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BloodGroup>(entity =>
            {
                entity.ToTable("BloodGroup");

                entity.Property(e => e.BloodGroupName)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<BnaAttendancePeriod>(entity =>
            {
                entity.ToTable("BnaAttendancePeriod");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PeriodName).HasMaxLength(450);
            });

            modelBuilder.Entity<BnaAttendanceRemark>(entity =>
            {
                entity.HasKey(e => e.BnaAttendanceRemarksId)
                    .HasName("PK_BNAAttendanceRemarks");

                entity.Property(e => e.AttendanceRemarksCause).HasMaxLength(450);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<BnaBatch>(entity =>
            {
                entity.ToTable("BnaBatch");

                entity.Property(e => e.BatchName)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<BnaClassSchedule>(entity =>
            {
                entity.ToTable("BnaClassSchedule");

                entity.Property(e => e.ClassLocation).HasMaxLength(250);

                entity.Property(e => e.CreatedBy).HasMaxLength(450);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DurationForm).HasMaxLength(50);

                entity.Property(e => e.DurationTo).HasMaxLength(50);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.BnaClassScheduleStatus)
                    .WithMany(p => p.BnaClassSchedules)
                    .HasForeignKey(d => d.BnaClassScheduleStatusId)
                    .HasConstraintName("FK_BnaClassSchedule_BnaClassScheduleStatus");

                entity.HasOne(d => d.BnaClassSectionSelection)
                    .WithMany(p => p.BnaClassSchedules)
                    .HasForeignKey(d => d.BnaClassSectionSelectionId)
                    .HasConstraintName("FK_BnaClassSchedule_BnaClassSectionSelection");

                entity.HasOne(d => d.BnaSemesterDuration)
                    .WithMany(p => p.BnaClassSchedules)
                    .HasForeignKey(d => d.BnaSemesterDurationId)
                    .HasConstraintName("FK_BnaClassSchedule_BnaSemesterDuration");

                entity.HasOne(d => d.BnaSemester)
                    .WithMany(p => p.BnaClassSchedules)
                    .HasForeignKey(d => d.BnaSemesterId)
                    .HasConstraintName("FK_BnaClassSchedule_BnaSemester");

                entity.HasOne(d => d.BnaSubjectName)
                    .WithMany(p => p.BnaClassSchedules)
                    .HasForeignKey(d => d.BnaSubjectNameId)
                    .HasConstraintName("FK_BnaClassSchedule_BnaSubjectName");

                entity.HasOne(d => d.ClassPeriod)
                    .WithMany(p => p.BnaClassSchedules)
                    .HasForeignKey(d => d.ClassPeriodId)
                    .HasConstraintName("FK_BnaClassSchedule_ClassPeriod");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.BnaClassSchedules)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_BnaClassSchedule_TraineeBioDataGeneralInfo");
            });

            modelBuilder.Entity<BnaClassScheduleStatus>(entity =>
            {
                entity.ToTable("BnaClassScheduleStatus");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(450);
            });

            modelBuilder.Entity<BnaClassSectionSelection>(entity =>
            {
                entity.ToTable("BnaClassSectionSelection");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SectionName)
                    .IsRequired()
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<BnaClassTest>(entity =>
            {
                entity.ToTable("BnaClassTest");

                entity.Property(e => e.ApprovedBy).HasMaxLength(450);

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ObtainedMark1).HasMaxLength(450);

                entity.Property(e => e.ObtainedMark2).HasMaxLength(450);

                entity.Property(e => e.ObtainedMark3).HasMaxLength(450);

                entity.Property(e => e.ObtainedMark4).HasMaxLength(450);

                entity.Property(e => e.ObtainedMark5).HasMaxLength(450);

                entity.Property(e => e.Percentage).HasMaxLength(50);

                entity.HasOne(d => d.BnaClassTestType)
                    .WithMany(p => p.BnaClassTests)
                    .HasForeignKey(d => d.BnaClassTestTypeId)
                    .HasConstraintName("FK_BnaClassTest_BnaClassTestType");

                entity.HasOne(d => d.BnaSemesterDuration)
                    .WithMany(p => p.BnaClassTests)
                    .HasForeignKey(d => d.BnaSemesterDurationId)
                    .HasConstraintName("FK_BnaClassTest_BnaSemesterDuration");

                entity.HasOne(d => d.BnaSemester)
                    .WithMany(p => p.BnaClassTests)
                    .HasForeignKey(d => d.BnaSemesterId)
                    .HasConstraintName("FK_BnaClassTest_BnaSemester");

                entity.HasOne(d => d.BnaSubjectCurriculum)
                    .WithMany(p => p.BnaClassTests)
                    .HasForeignKey(d => d.BnaSubjectCurriculumId)
                    .HasConstraintName("FK_BnaClassTest_BnaSubjectCurriculum");

                entity.HasOne(d => d.BnaSubjectName)
                    .WithMany(p => p.BnaClassTests)
                    .HasForeignKey(d => d.BnaSubjectNameId)
                    .HasConstraintName("FK_BnaClassTest_BnaSubjectName");

                entity.HasOne(d => d.SubjectCategory)
                    .WithMany(p => p.BnaClassTests)
                    .HasForeignKey(d => d.SubjectCategoryId)
                    .HasConstraintName("FK_BnaClassTest_SubjectCategory");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.BnaClassTests)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_BnaClassTest_TraineeBioDataGeneralInfo");
            });

            modelBuilder.Entity<BnaClassTestType>(entity =>
            {
                entity.ToTable("BnaClassTestType");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(450);
            });

            modelBuilder.Entity<BnaCurriculumType>(entity =>
            {
                entity.ToTable("BnaCurriculumType");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.CurriculumType)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<BnaCurriculumUpdate>(entity =>
            {
                entity.ToTable("BnaCurriculumUpdate");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.BnaCurriculumType)
                    .WithMany(p => p.BnaCurriculumUpdates)
                    .HasForeignKey(d => d.BnaCurriculumTypeId)
                    .HasConstraintName("FK_BnaCurriculumUpdate_BnaCurriculumType");

                entity.HasOne(d => d.BnaSemesterDuration)
                    .WithMany(p => p.BnaCurriculumUpdates)
                    .HasForeignKey(d => d.BnaSemesterDurationId)
                    .HasConstraintName("FK_BnaCurriculumUpdate_BnaSemesterDuration");

                entity.HasOne(d => d.BnaSemester)
                    .WithMany(p => p.BnaCurriculumUpdates)
                    .HasForeignKey(d => d.BnaSemesterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BnaCurriculumUpdate_BnaSemester");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.BnaCurriculumUpdates)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_BnaCurriculumUpdate_TraineeBioDataGeneralInfo");
            });

            modelBuilder.Entity<BnaExamAttendance>(entity =>
            {
                entity.ToTable("BnaExamAttendance");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.ApprovedUser).HasMaxLength(450);

                entity.Property(e => e.AttendanceDate).HasColumnType("datetime");

                entity.Property(e => e.ClassLeaderName).HasMaxLength(450);

                entity.Property(e => e.CreatedBy).HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.ExamDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.BaseSchoolName)
                    .WithMany(p => p.BnaExamAttendances)
                    .HasForeignKey(d => d.BaseSchoolNameId)
                    .HasConstraintName("FK_BnaExamAttendance_BaseSchoolName");

                entity.HasOne(d => d.BnaAttendanceRemarks)
                    .WithMany(p => p.BnaExamAttendances)
                    .HasForeignKey(d => d.BnaAttendanceRemarksId)
                    .HasConstraintName("FK_BnaExamAttendance_BnaAttendanceRemarks");

                entity.HasOne(d => d.BnaExamSchedule)
                    .WithMany(p => p.BnaExamAttendances)
                    .HasForeignKey(d => d.BnaExamScheduleId)
                    .HasConstraintName("FK_BnaExamAttendance_BnaExamSchedule");

                entity.HasOne(d => d.BnaSemesterDuration)
                    .WithMany(p => p.BnaExamAttendances)
                    .HasForeignKey(d => d.BnaSemesterDurationId)
                    .HasConstraintName("FK_BnaExamAttendance_BnaSemesterDuration");

                entity.HasOne(d => d.BnaSemester)
                    .WithMany(p => p.BnaExamAttendances)
                    .HasForeignKey(d => d.BnaSemesterId)
                    .HasConstraintName("FK_BnaExamAttendance_BnaSemester");

                entity.HasOne(d => d.BnaSubjectName)
                    .WithMany(p => p.BnaExamAttendances)
                    .HasForeignKey(d => d.BnaSubjectNameId)
                    .HasConstraintName("FK_BnaExamAttendance_BnaSubjectName");

                entity.HasOne(d => d.ClassPeriod)
                    .WithMany(p => p.BnaExamAttendances)
                    .HasForeignKey(d => d.ClassPeriodId)
                    .HasConstraintName("FK_BnaExamAttendance_ClassPeriod");

                entity.HasOne(d => d.ClassRoutine)
                    .WithMany(p => p.BnaExamAttendances)
                    .HasForeignKey(d => d.ClassRoutineId)
                    .HasConstraintName("FK_BnaExamAttendance_ClassRoutine");

                entity.HasOne(d => d.CourseDuration)
                    .WithMany(p => p.BnaExamAttendances)
                    .HasForeignKey(d => d.CourseDurationId)
                    .HasConstraintName("FK_BnaExamAttendance_CourseDuration");

                entity.HasOne(d => d.CourseName)
                    .WithMany(p => p.BnaExamAttendances)
                    .HasForeignKey(d => d.CourseNameId)
                    .HasConstraintName("FK_BnaExamAttendance_CourseName");

                entity.HasOne(d => d.ExamType)
                    .WithMany(p => p.BnaExamAttendances)
                    .HasForeignKey(d => d.ExamTypeId)
                    .HasConstraintName("FK_BnaExamAttendance_ExamType");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.BnaExamAttendances)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_BnaExamAttendance_TraineeBioDataGeneralInfo");
            });

            modelBuilder.Entity<BnaExamInstructorAssign>(entity =>
            {
                entity.ToTable("BnaExamInstructorAssign");

                entity.Property(e => e.CreatedBy).HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.ExamLocation).HasMaxLength(450);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.BaseSchoolName)
                    .WithMany(p => p.BnaExamInstructorAssigns)
                    .HasForeignKey(d => d.BaseSchoolNameId)
                    .HasConstraintName("FK_BnaExamInstructorAssign_BaseSchoolName");

                entity.HasOne(d => d.BnaInstructorType)
                    .WithMany(p => p.BnaExamInstructorAssigns)
                    .HasForeignKey(d => d.BnaInstructorTypeId)
                    .HasConstraintName("FK_BnaExamInstructorAssign_BnaInstructorType");

                entity.HasOne(d => d.BnaSubjectName)
                    .WithMany(p => p.BnaExamInstructorAssigns)
                    .HasForeignKey(d => d.BnaSubjectNameId)
                    .HasConstraintName("FK_BnaExamInstructorAssign_BnaSubjectName");

                entity.HasOne(d => d.ClassRoutine)
                    .WithMany(p => p.BnaExamInstructorAssigns)
                    .HasForeignKey(d => d.ClassRoutineId)
                    .HasConstraintName("FK_BnaExamInstructorAssign_ClassRoutine");

                entity.HasOne(d => d.CourseDuration)
                    .WithMany(p => p.BnaExamInstructorAssigns)
                    .HasForeignKey(d => d.CourseDurationId)
                    .HasConstraintName("FK_BnaExamInstructorAssign_CourseDuration");

                entity.HasOne(d => d.CourseModule)
                    .WithMany(p => p.BnaExamInstructorAssigns)
                    .HasForeignKey(d => d.CourseModuleId)
                    .HasConstraintName("FK_BnaExamInstructorAssign_CourseModule");

                entity.HasOne(d => d.CourseName)
                    .WithMany(p => p.BnaExamInstructorAssigns)
                    .HasForeignKey(d => d.CourseNameId)
                    .HasConstraintName("FK_BnaExamInstructorAssign_CourseName");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.BnaExamInstructorAssigns)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_BnaExamInstructorAssign_TraineeBioDataGeneralInfo");
            });

            modelBuilder.Entity<BnaExamMark>(entity =>
            {
                entity.ToTable("BnaExamMark");

                entity.Property(e => e.CreatedBy).HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.IsApprovedBy).HasMaxLength(450);

                entity.Property(e => e.IsApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PassMark).HasMaxLength(150);

                entity.Property(e => e.Remarks).HasMaxLength(150);

                entity.Property(e => e.TotalMark).HasMaxLength(150);

                entity.HasOne(d => d.BaseSchoolName)
                    .WithMany(p => p.BnaExamMarks)
                    .HasForeignKey(d => d.BaseSchoolNameId)
                    .HasConstraintName("FK_BnaExamMark_BaseSchoolName");

                entity.HasOne(d => d.BnaCurriculumType)
                    .WithMany(p => p.BnaExamMarks)
                    .HasForeignKey(d => d.BnaCurriculumTypeId)
                    .HasConstraintName("FK_BnaExamMark_BnaCurriculumType");

                entity.HasOne(d => d.BnaExamSchedule)
                    .WithMany(p => p.BnaExamMarks)
                    .HasForeignKey(d => d.BnaExamScheduleId)
                    .HasConstraintName("FK_BnaExamMark_BnaExamSchedule");

                entity.HasOne(d => d.BnaSemester)
                    .WithMany(p => p.BnaExamMarks)
                    .HasForeignKey(d => d.BnaSemesterId)
                    .HasConstraintName("FK_BnaExamMark_BnaSemester");

                entity.HasOne(d => d.BnaSubjectName)
                    .WithMany(p => p.BnaExamMarks)
                    .HasForeignKey(d => d.BnaSubjectNameId)
                    .HasConstraintName("FK_BnaExamMark_BnaSubjectName");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.BnaExamMarks)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_BnaExamMark_Branch");

                entity.HasOne(d => d.ClassRoutine)
                    .WithMany(p => p.BnaExamMarks)
                    .HasForeignKey(d => d.ClassRoutineId)
                    .HasConstraintName("FK_BnaExamMark_ClassRoutine");

                entity.HasOne(d => d.CourseDuration)
                    .WithMany(p => p.BnaExamMarks)
                    .HasForeignKey(d => d.CourseDurationId)
                    .HasConstraintName("FK_BnaExamMark_CourseDuration");

                entity.HasOne(d => d.CourseName)
                    .WithMany(p => p.BnaExamMarks)
                    .HasForeignKey(d => d.CourseNameId)
                    .HasConstraintName("FK_BnaExamMark_CourseName");

                entity.HasOne(d => d.ExamMarkRemarks)
                    .WithMany(p => p.BnaExamMarks)
                    .HasForeignKey(d => d.ExamMarkRemarksId)
                    .HasConstraintName("FK_BnaExamMark_ExamMarkRemarks");

                entity.HasOne(d => d.SubjectMark)
                    .WithMany(p => p.BnaExamMarks)
                    .HasForeignKey(d => d.SubjectMarkId)
                    .HasConstraintName("FK_BnaExamMark_SubjectMark");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.BnaExamMarks)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_BnaExamMark_TraineeBioDataGeneralInfo");

                entity.HasOne(d => d.TraineeNomination)
                    .WithMany(p => p.BnaExamMarks)
                    .HasForeignKey(d => d.TraineeNominationId)
                    .HasConstraintName("FK_BnaExamMark_TraineeNomination");
            });

            modelBuilder.Entity<BnaExamRoutineLog>(entity =>
            {
                entity.ToTable("BnaExamRoutineLog");

                entity.Property(e => e.CreatedBy).HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DurationForm).HasColumnType("datetime");

                entity.Property(e => e.DurationTo).HasColumnType("datetime");

                entity.Property(e => e.ExamDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.BnaClassSectionSelection)
                    .WithMany(p => p.BnaExamRoutineLogs)
                    .HasForeignKey(d => d.BnaClassSectionSelectionId)
                    .HasConstraintName("FK_BnaExamRoutineLog_BnaClassSectionSelection");

                entity.HasOne(d => d.BnaExamInstructorAssign)
                    .WithMany(p => p.BnaExamRoutineLogs)
                    .HasForeignKey(d => d.BnaExamInstructorAssignId)
                    .HasConstraintName("FK_BnaExamRoutineLog_BnaExamInstructorAssign");

                entity.HasOne(d => d.BnaExamSchedule)
                    .WithMany(p => p.BnaExamRoutineLogs)
                    .HasForeignKey(d => d.BnaExamScheduleId)
                    .HasConstraintName("FK_BnaExamRoutineLog_BnaExamSchedule");

                entity.HasOne(d => d.BnaSemester)
                    .WithMany(p => p.BnaExamRoutineLogs)
                    .HasForeignKey(d => d.BnaSemesterId)
                    .HasConstraintName("FK_BnaExamRoutineLog_BnaSemester");

                entity.HasOne(d => d.BnaSubjectName)
                    .WithMany(p => p.BnaExamRoutineLogs)
                    .HasForeignKey(d => d.BnaSubjectNameId)
                    .HasConstraintName("FK_BnaExamRoutineLog_BnaSubjectName");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.BnaExamRoutineLogs)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_BnaExamRoutineLog_TraineeBioDataGeneralInfo");
            });

            modelBuilder.Entity<BnaExamSchedule>(entity =>
            {
                entity.ToTable("BnaExamSchedule");

                entity.Property(e => e.ApprovedBy).HasMaxLength(450);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DurationFrom).HasColumnType("datetime");

                entity.Property(e => e.DurationTo).HasColumnType("datetime");

                entity.Property(e => e.ExamDate).HasColumnType("datetime");

                entity.Property(e => e.ExamLocation).HasMaxLength(450);

                entity.Property(e => e.IsApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.BnaSemesterDuration)
                    .WithMany(p => p.BnaExamSchedules)
                    .HasForeignKey(d => d.BnaSemesterDurationId)
                    .HasConstraintName("FK_BnaExamSchedule_BnaSemesterDuration");

                entity.HasOne(d => d.BnaSemester)
                    .WithMany(p => p.BnaExamSchedules)
                    .HasForeignKey(d => d.BnaSemesterId)
                    .HasConstraintName("FK_BnaExamSchedule_BnaSemester");

                entity.HasOne(d => d.BnaSubjectName)
                    .WithMany(p => p.BnaExamSchedules)
                    .HasForeignKey(d => d.BnaSubjectNameId)
                    .HasConstraintName("FK_BnaExamSchedule_BnaSubjectName");

                entity.HasOne(d => d.ExamType)
                    .WithMany(p => p.BnaExamSchedules)
                    .HasForeignKey(d => d.ExamTypeId)
                    .HasConstraintName("FK_BnaExamSchedule_ExamType");
            });

            modelBuilder.Entity<BnaInstructorType>(entity =>
            {
                entity.ToTable("BnaInstructorType");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.InstructorTypeName)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<BnaPromotionLog>(entity =>
            {
                entity.ToTable("BnaPromotionLog");

                entity.Property(e => e.CreatedBy).HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PromotionDate).HasColumnType("datetime");

                entity.HasOne(d => d.BnaPromotionStatus)
                    .WithMany(p => p.BnaPromotionLogs)
                    .HasForeignKey(d => d.BnaPromotionStatusId)
                    .HasConstraintName("FK_BnaPromotionLog_BnaPromotionStatus");

                entity.HasOne(d => d.BnaSemester)
                    .WithMany(p => p.BnaPromotionLogs)
                    .HasForeignKey(d => d.BnaSemesterId)
                    .HasConstraintName("FK_BnaPromotionLog_BnaSemester");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.BnaPromotionLogs)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_BnaPromotionLog_TraineeBioDataGeneralInfo");
            });

            modelBuilder.Entity<BnaPromotionStatus>(entity =>
            {
                entity.ToTable("BnaPromotionStatus");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PromotionStatusName)
                    .IsRequired()
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<BnaSemester>(entity =>
            {
                entity.ToTable("BnaSemester");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SemesterName)
                    .IsRequired()
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<BnaSemesterDuration>(entity =>
            {
                entity.ToTable("BnaSemesterDuration");

                entity.Property(e => e.ApprovedBy).HasMaxLength(450);

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Location).HasMaxLength(450);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.BnaSemester)
                    .WithMany(p => p.BnaSemesterDurationBnaSemesters)
                    .HasForeignKey(d => d.BnaSemesterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BnaSemesterDuration_BnaSemester");

                entity.HasOne(d => d.NextSemester)
                    .WithMany(p => p.BnaSemesterDurationNextSemesters)
                    .HasForeignKey(d => d.NextSemesterId)
                    .HasConstraintName("FK_BnaSemesterDuration_NextSemester");

                entity.HasOne(d => d.Rank)
                    .WithMany(p => p.BnaSemesterDurations)
                    .HasForeignKey(d => d.RankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BnaSemesterDuration_Rank");

                entity.HasOne(d => d.SemesterLocationTypeNavigation)
                    .WithMany(p => p.BnaSemesterDurations)
                    .HasForeignKey(d => d.SemesterLocationType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BnaSemesterDuration_CodeValue");
            });

            modelBuilder.Entity<BnaServiceType>(entity =>
            {
                entity.ToTable("BnaServiceType");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ServiceName)
                    .IsRequired()
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<BnaSubjectCurriculum>(entity =>
            {
                entity.ToTable("BnaSubjectCurriculum");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SubjectCurriculumName)
                    .IsRequired()
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<BnaSubjectName>(entity =>
            {
                entity.ToTable("BnaSubjectName");

                entity.Property(e => e.AssignmentMark).HasMaxLength(450);

                entity.Property(e => e.CaseStudyMark).HasMaxLength(450);

                entity.Property(e => e.ClassTestMark).HasMaxLength(450);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PaperNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PassMarkBna)
                    .HasMaxLength(450)
                    .HasColumnName("PassMarkBNA");

                entity.Property(e => e.PassMarkBup)
                    .HasMaxLength(450)
                    .HasColumnName("PassMarkBUP");

                entity.Property(e => e.QexamTime)
                    .HasMaxLength(150)
                    .HasColumnName("QExamTime");

                entity.Property(e => e.Remarks).HasMaxLength(450);

                entity.Property(e => e.SubjectCode).HasMaxLength(450);

                entity.Property(e => e.SubjectName).HasMaxLength(450);

                entity.Property(e => e.SubjectNameBangla).HasMaxLength(450);

                entity.Property(e => e.SubjectShortName).HasMaxLength(450);

                entity.Property(e => e.TotalMark).HasMaxLength(450);

                entity.Property(e => e.TotalPeriod).HasMaxLength(450);

                entity.HasOne(d => d.BaseSchoolName)
                    .WithMany(p => p.BnaSubjectNames)
                    .HasForeignKey(d => d.BaseSchoolNameId)
                    .HasConstraintName("FK_BnaSubjectName_BaseSchoolName");

                entity.HasOne(d => d.BnaSemester)
                    .WithMany(p => p.BnaSubjectNames)
                    .HasForeignKey(d => d.BnaSemesterId)
                    .HasConstraintName("FK_BnaSubjectName_BnaSemester");

                entity.HasOne(d => d.BnaSubjectCurriculum)
                    .WithMany(p => p.BnaSubjectNames)
                    .HasForeignKey(d => d.BnaSubjectCurriculumId)
                    .HasConstraintName("FK_BnaSubjectName_BnaSubjectCurriculum");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.BnaSubjectNames)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_BnaSubjectName_Branch");

                entity.HasOne(d => d.CourseModule)
                    .WithMany(p => p.BnaSubjectNames)
                    .HasForeignKey(d => d.CourseModuleId)
                    .HasConstraintName("FK_BnaSubjectName_CourseModule");

                entity.HasOne(d => d.CourseName)
                    .WithMany(p => p.BnaSubjectNames)
                    .HasForeignKey(d => d.CourseNameId)
                    .HasConstraintName("FK_BnaSubjectName_CourseName");

                entity.HasOne(d => d.CourseType)
                    .WithMany(p => p.BnaSubjectNames)
                    .HasForeignKey(d => d.CourseTypeId)
                    .HasConstraintName("FK_BnaSubjectName_CourseType");

                entity.HasOne(d => d.KindOfSubject)
                    .WithMany(p => p.BnaSubjectNames)
                    .HasForeignKey(d => d.KindOfSubjectId)
                    .HasConstraintName("FK_BnaSubjectName_KindOfSubject");

                entity.HasOne(d => d.ResultStatus)
                    .WithMany(p => p.BnaSubjectNames)
                    .HasForeignKey(d => d.ResultStatusId)
                    .HasConstraintName("FK_BnaSubjectName_CodeValue");

                entity.HasOne(d => d.SaylorBranch)
                    .WithMany(p => p.BnaSubjectNames)
                    .HasForeignKey(d => d.SaylorBranchId)
                    .HasConstraintName("FK_BnaSubjectName_SaylorBranch");

                entity.HasOne(d => d.SaylorSubBranch)
                    .WithMany(p => p.BnaSubjectNames)
                    .HasForeignKey(d => d.SaylorSubBranchId)
                    .HasConstraintName("FK_BnaSubjectName_SaylorSubBranch");

                entity.HasOne(d => d.SubjectCategory)
                    .WithMany(p => p.BnaSubjectNames)
                    .HasForeignKey(d => d.SubjectCategoryId)
                    .HasConstraintName("FK_BnaSubjectName_SubjectCategory");

                entity.HasOne(d => d.SubjectClassification)
                    .WithMany(p => p.BnaSubjectNames)
                    .HasForeignKey(d => d.SubjectClassificationId)
                    .HasConstraintName("FK_BnaSubjectName_SubjectClassification");

                entity.HasOne(d => d.SubjectType)
                    .WithMany(p => p.BnaSubjectNames)
                    .HasForeignKey(d => d.SubjectTypeId)
                    .HasConstraintName("FK_BnaSubjectName_SubjectType");
            });

            modelBuilder.Entity<Board>(entity =>
            {
                entity.Property(e => e.BoardName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.ToTable("Branch");

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ShortName).HasMaxLength(450);

                entity.HasOne(d => d.TraineeStatus)
                    .WithMany(p => p.Branches)
                    .HasForeignKey(d => d.TraineeStatusId)
                    .HasConstraintName("FK_Branch_TraineeStatus");
            });

            modelBuilder.Entity<BudgetAllocation>(entity =>
            {
                entity.ToTable("BudgetAllocation");

                entity.Property(e => e.BudgetCodeName).HasMaxLength(450);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Percentage).HasMaxLength(450);

                entity.Property(e => e.Remarks).HasMaxLength(450);

                entity.HasOne(d => d.BudgetCode)
                    .WithMany(p => p.BudgetAllocations)
                    .HasForeignKey(d => d.BudgetCodeId)
                    .HasConstraintName("FK_BudgetAllocation_BudgetCode");

                entity.HasOne(d => d.BudgetType)
                    .WithMany(p => p.BudgetAllocations)
                    .HasForeignKey(d => d.BudgetTypeId)
                    .HasConstraintName("FK_BudgetAllocation_BudgetType");

                entity.HasOne(d => d.FiscalYear)
                    .WithMany(p => p.BudgetAllocations)
                    .HasForeignKey(d => d.FiscalYearId)
                    .HasConstraintName("FK_BudgetAllocation_FiscalYear");
            });

            modelBuilder.Entity<BudgetCode>(entity =>
            {
                entity.ToTable("BudgetCode");

                entity.Property(e => e.BudgetCodes).HasMaxLength(450);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(450);
            });

            modelBuilder.Entity<BudgetType>(entity =>
            {
                entity.ToTable("BudgetType");

                entity.Property(e => e.BudgetTypeName).HasMaxLength(450);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Bulletin>(entity =>
            {
                entity.ToTable("Bulletin");

                entity.Property(e => e.BuletinDetails).HasMaxLength(4000);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.BaseSchoolName)
                    .WithMany(p => p.Bulletins)
                    .HasForeignKey(d => d.BaseSchoolNameId)
                    .HasConstraintName("FK_Bulletin_BaseSchoolName");

                entity.HasOne(d => d.CourseDuration)
                    .WithMany(p => p.Bulletins)
                    .HasForeignKey(d => d.CourseDurationId)
                    .HasConstraintName("FK_Bulletin_CourseDuration");

                entity.HasOne(d => d.CourseName)
                    .WithMany(p => p.Bulletins)
                    .HasForeignKey(d => d.CourseNameId)
                    .HasConstraintName("FK_Bulletin_CourseName");
            });

            modelBuilder.Entity<Caste>(entity =>
            {
                entity.ToTable("Caste");

                entity.Property(e => e.CastName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Religion)
                    .WithMany(p => p.Castes)
                    .HasForeignKey(d => d.ReligionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Caste_Religion");
            });

            modelBuilder.Entity<ClassInstructorAssign>(entity =>
            {
                entity.ToTable("ClassInstructorAssign");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.BnaClassSchedule)
                    .WithMany(p => p.ClassInstructorAssigns)
                    .HasForeignKey(d => d.BnaClassScheduleId)
                    .HasConstraintName("FK_ClassInstructorAssign_BnaClassSchedule");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.ClassInstructorAssigns)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_ClassInstructorAssign_TraineeBioDataGeneralInfo");
            });

            modelBuilder.Entity<ClassPeriod>(entity =>
            {
                entity.ToTable("ClassPeriod");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DurationForm).HasMaxLength(450);

                entity.Property(e => e.DurationTo).HasMaxLength(450);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PeriodName).HasMaxLength(450);

                entity.HasOne(d => d.BaseSchoolName)
                    .WithMany(p => p.ClassPeriods)
                    .HasForeignKey(d => d.BaseSchoolNameId)
                    .HasConstraintName("FK_ClassPeriod_BaseSchoolName");

                entity.HasOne(d => d.BnaClassScheduleStatus)
                    .WithMany(p => p.ClassPeriods)
                    .HasForeignKey(d => d.BnaClassScheduleStatusId)
                    .HasConstraintName("FK_ClassPeriod_BnaClassScheduleStatus");

                entity.HasOne(d => d.CourseName)
                    .WithMany(p => p.ClassPeriods)
                    .HasForeignKey(d => d.CourseNameId)
                    .HasConstraintName("FK_ClassPeriod_CourseName");
            });

            modelBuilder.Entity<ClassRoutine>(entity =>
            {
                entity.ToTable("ClassRoutine");

                entity.Property(e => e.ApprovedBy).HasMaxLength(450);

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.ClassLocation).HasMaxLength(1000);

                entity.Property(e => e.ClassRoomName).HasMaxLength(450);

                entity.Property(e => e.ClassTopic).HasMaxLength(450);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(2000);

                entity.Property(e => e.TimeDuration).HasMaxLength(450);

                entity.HasOne(d => d.BaseSchoolName)
                    .WithMany(p => p.ClassRoutines)
                    .HasForeignKey(d => d.BaseSchoolNameId)
                    .HasConstraintName("FK_ClassRoutine_BaseSchoolName");

                entity.HasOne(d => d.BnaSubjectName)
                    .WithMany(p => p.ClassRoutines)
                    .HasForeignKey(d => d.BnaSubjectNameId)
                    .HasConstraintName("FK_ClassRoutine_BnaSubjectName");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.ClassRoutines)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_ClassRoutine_Branch");

                entity.HasOne(d => d.ClassPeriod)
                    .WithMany(p => p.ClassRoutines)
                    .HasForeignKey(d => d.ClassPeriodId)
                    .HasConstraintName("FK_ClassRoutine_ClassPeriod");

                entity.HasOne(d => d.ClassType)
                    .WithMany(p => p.ClassRoutines)
                    .HasForeignKey(d => d.ClassTypeId)
                    .HasConstraintName("FK_ClassRoutine_ClassType");

                entity.HasOne(d => d.CourseDuration)
                    .WithMany(p => p.ClassRoutines)
                    .HasForeignKey(d => d.CourseDurationId)
                    .HasConstraintName("FK_ClassRoutine_CourseDuration");

                entity.HasOne(d => d.CourseModule)
                    .WithMany(p => p.ClassRoutines)
                    .HasForeignKey(d => d.CourseModuleId)
                    .HasConstraintName("FK_ClassRoutine_CourseModule");

                entity.HasOne(d => d.CourseName)
                    .WithMany(p => p.ClassRoutines)
                    .HasForeignKey(d => d.CourseNameId)
                    .HasConstraintName("FK_ClassRoutine_CourseName");

                entity.HasOne(d => d.CourseWeek)
                    .WithMany(p => p.ClassRoutines)
                    .HasForeignKey(d => d.CourseWeekId)
                    .HasConstraintName("FK_ClassRoutine_CourseWeek");
            });

            modelBuilder.Entity<ClassType>(entity =>
            {
                entity.ToTable("ClassType");

                entity.Property(e => e.ClassTypeName).HasMaxLength(450);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CoCurricularActivity>(entity =>
            {
                entity.ToTable("CoCurricularActivity");

                entity.Property(e => e.Achievement).HasMaxLength(450);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Participation).HasMaxLength(450);

                entity.HasOne(d => d.CoCurricularActivityType)
                    .WithMany(p => p.CoCurricularActivities)
                    .HasForeignKey(d => d.CoCurricularActivityTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CoCurricularActivity_CoCurricularActivityType");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.CoCurricularActivities)
                    .HasForeignKey(d => d.TraineeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CoCurricularActivity_TraineeBioDataGeneralInfo");
            });

            modelBuilder.Entity<CoCurricularActivityType>(entity =>
            {
                entity.ToTable("CoCurricularActivityType");

                entity.Property(e => e.CoCurricularActivityName)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CodeValue>(entity =>
            {
                entity.ToTable("CodeValue");

                entity.Property(e => e.AdditonalValue)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DisplayCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeValue)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodeValueType)
                    .WithMany(p => p.CodeValues)
                    .HasForeignKey(d => d.CodeValueTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CodeValue_CodeValueType");
            });

            modelBuilder.Entity<CodeValueType>(entity =>
            {
                entity.ToTable("CodeValueType");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<ColorOfEye>(entity =>
            {
                entity.ToTable("ColorOfEye");

                entity.Property(e => e.ColorOfEyeName)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Complexion>(entity =>
            {
                entity.ToTable("Complexion");

                entity.Property(e => e.ComplexionName)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ShortName).HasMaxLength(450);

                entity.HasOne(d => d.CountryGroup)
                    .WithMany(p => p.Countries)
                    .HasForeignKey(d => d.CountryGroupId)
                    .HasConstraintName("FK_Country_CountryGroup");

                entity.HasOne(d => d.CurrencyName)
                    .WithMany(p => p.Countries)
                    .HasForeignKey(d => d.CurrencyNameId)
                    .HasConstraintName("FK_Country_CurrencyName");
            });

            modelBuilder.Entity<CountryGroup>(entity =>
            {
                entity.ToTable("CountryGroup");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(450);
            });

            modelBuilder.Entity<CourseBudgetAllocation>(entity =>
            {
                entity.ToTable("CourseBudgetAllocation");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NextInstallmentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.HasOne(d => d.BudgetCode)
                    .WithMany(p => p.CourseBudgetAllocations)
                    .HasForeignKey(d => d.BudgetCodeId)
                    .HasConstraintName("FK_CourseBudgetAllocation_BudgetCode");

                entity.HasOne(d => d.CourseDuration)
                    .WithMany(p => p.CourseBudgetAllocations)
                    .HasForeignKey(d => d.CourseDurationId)
                    .HasConstraintName("FK_CourseBudgetAllocation_CourseDuration");

                entity.HasOne(d => d.CourseName)
                    .WithMany(p => p.CourseBudgetAllocations)
                    .HasForeignKey(d => d.CourseNameId)
                    .HasConstraintName("FK_CourseBudgetAllocation_CourseName");

                entity.HasOne(d => d.CourseType)
                    .WithMany(p => p.CourseBudgetAllocations)
                    .HasForeignKey(d => d.CourseTypeId)
                    .HasConstraintName("FK_CourseBudgetAllocation_CourseType");

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.CourseBudgetAllocations)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .HasConstraintName("FK_CourseBudgetAllocation_PaymentType");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.CourseBudgetAllocations)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_CourseBudgetAllocation_TraineeBioDataGeneralInfo");
            });

            modelBuilder.Entity<CourseDuration>(entity =>
            {
                entity.ToTable("CourseDuration");

                entity.Property(e => e.ApprovedBy).HasMaxLength(450);

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.CourseTitle).HasMaxLength(450);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DurationFrom).HasColumnType("datetime");

                entity.Property(e => e.DurationTo).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Nbcd).HasMaxLength(450);

                entity.Property(e => e.NbcdDurationFrom).HasColumnType("datetime");

                entity.Property(e => e.NbcdDurationTo).HasColumnType("datetime");

                entity.Property(e => e.NoOfCandidates).HasMaxLength(450);

                entity.Property(e => e.Professional).HasMaxLength(450);

                entity.Property(e => e.Remark).HasMaxLength(450);

                entity.HasOne(d => d.BaseSchoolName)
                    .WithMany(p => p.CourseDurations)
                    .HasForeignKey(d => d.BaseSchoolNameId)
                    .HasConstraintName("FK_CourseDuration_BaseSchoolName");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CourseDurations)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_CourseDuration_Country");

                entity.HasOne(d => d.CourseName)
                    .WithMany(p => p.CourseDurations)
                    .HasForeignKey(d => d.CourseNameId)
                    .HasConstraintName("FK_CourseDuration_CourseName");

                entity.HasOne(d => d.CourseType)
                    .WithMany(p => p.CourseDurations)
                    .HasForeignKey(d => d.CourseTypeId)
                    .HasConstraintName("FK_CourseDuration_CourseType");

                entity.HasOne(d => d.FiscalYear)
                    .WithMany(p => p.CourseDurations)
                    .HasForeignKey(d => d.FiscalYearId)
                    .HasConstraintName("FK_CourseDuration_FiscalYear");

                entity.HasOne(d => d.OrganizationName)
                    .WithMany(p => p.CourseDurations)
                    .HasForeignKey(d => d.OrganizationNameId)
                    .HasConstraintName("FK_CourseDuration_OrganizationName");
            });

            modelBuilder.Entity<CourseGradingEntry>(entity =>
            {
                entity.ToTable("CourseGradingEntry");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Grade).HasMaxLength(250);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MarkFrom).HasMaxLength(250);

                entity.Property(e => e.MarkTo).HasMaxLength(250);

                entity.HasOne(d => d.Assessment)
                    .WithMany(p => p.CourseGradingEntries)
                    .HasForeignKey(d => d.AssessmentId)
                    .HasConstraintName("FK_CourseGradingEntry_Assessment");

                entity.HasOne(d => d.BaseSchoolName)
                    .WithMany(p => p.CourseGradingEntries)
                    .HasForeignKey(d => d.BaseSchoolNameId)
                    .HasConstraintName("FK_CourseGradingEntry_BaseSchoolName");

                entity.HasOne(d => d.CourseName)
                    .WithMany(p => p.CourseGradingEntries)
                    .HasForeignKey(d => d.CourseNameId)
                    .HasConstraintName("FK_CourseGradingEntry_CourseName");
            });

            modelBuilder.Entity<CourseInstructor>(entity =>
            {
                entity.ToTable("CourseInstructor");

                entity.Property(e => e.CreatedBy).HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.BaseSchoolName)
                    .WithMany(p => p.CourseInstructors)
                    .HasForeignKey(d => d.BaseSchoolNameId)
                    .HasConstraintName("FK_CourseInstructor_BaseSchoolName");

                entity.HasOne(d => d.BnaSubjectName)
                    .WithMany(p => p.CourseInstructors)
                    .HasForeignKey(d => d.BnaSubjectNameId)
                    .HasConstraintName("FK_CourseInstructor_BnaSubjectName");

                entity.HasOne(d => d.CourseDuration)
                    .WithMany(p => p.CourseInstructors)
                    .HasForeignKey(d => d.CourseDurationId)
                    .HasConstraintName("FK_CourseInstructor_CourseDuration");

                entity.HasOne(d => d.CourseModule)
                    .WithMany(p => p.CourseInstructors)
                    .HasForeignKey(d => d.CourseModuleId)
                    .HasConstraintName("FK_CourseInstructor_CourseModule");

                entity.HasOne(d => d.CourseName)
                    .WithMany(p => p.CourseInstructors)
                    .HasForeignKey(d => d.CourseNameId)
                    .HasConstraintName("FK_CourseInstructor_CourseName");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.CourseInstructors)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_CourseInstructor_TraineeBioDataGeneralInfo");
            });

            modelBuilder.Entity<CourseModule>(entity =>
            {
                entity.ToTable("CourseModule");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModuleName).HasMaxLength(450);

                entity.Property(e => e.NameOfModule)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.HasOne(d => d.BaseSchoolName)
                    .WithMany(p => p.CourseModules)
                    .HasForeignKey(d => d.BaseSchoolNameId)
                    .HasConstraintName("FK_CourseModule_BaseSchoolName");

                entity.HasOne(d => d.CourseName)
                    .WithMany(p => p.CourseModules)
                    .HasForeignKey(d => d.CourseNameId)
                    .HasConstraintName("FK_CourseModule_CourseName");
            });

            modelBuilder.Entity<CourseName>(entity =>
            {
                entity.ToTable("CourseName");

                entity.Property(e => e.Course)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.CourseSyllabus).HasMaxLength(500);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ShortName).HasMaxLength(450);

                entity.HasOne(d => d.CourseType)
                    .WithMany(p => p.CourseNames)
                    .HasForeignKey(d => d.CourseTypeId)
                    .HasConstraintName("FK_CourseName_CourseType");
            });

            modelBuilder.Entity<CoursePlanCreate>(entity =>
            {
                entity.ToTable("CoursePlanCreate");

                entity.Property(e => e.CoursePlanName).HasMaxLength(450);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Value).HasMaxLength(450);

                entity.HasOne(d => d.BaseSchoolName)
                    .WithMany(p => p.CoursePlanCreates)
                    .HasForeignKey(d => d.BaseSchoolNameId)
                    .HasConstraintName("FK_CoursePlanCreate_BaseSchoolName");

                entity.HasOne(d => d.CourseDuration)
                    .WithMany(p => p.CoursePlanCreates)
                    .HasForeignKey(d => d.CourseDurationId)
                    .HasConstraintName("FK_CoursePlanCreate_CourseDuration");

                entity.HasOne(d => d.CourseName)
                    .WithMany(p => p.CoursePlanCreates)
                    .HasForeignKey(d => d.CourseNameId)
                    .HasConstraintName("FK_CoursePlanCreate_CourseName");
            });

            modelBuilder.Entity<CourseSection>(entity =>
            {
                entity.ToTable("CourseSection");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SectionName).HasMaxLength(450);

                entity.Property(e => e.SectionShortName)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.HasOne(d => d.BaseSchoolName)
                    .WithMany(p => p.CourseSections)
                    .HasForeignKey(d => d.BaseSchoolNameId)
                    .HasConstraintName("FK_CourseSection_BaseSchoolName");

                entity.HasOne(d => d.CourseName)
                    .WithMany(p => p.CourseSections)
                    .HasForeignKey(d => d.CourseNameId)
                    .HasConstraintName("FK_CourseSection_CourseName");
            });

            modelBuilder.Entity<CourseTask>(entity =>
            {
                entity.ToTable("CourseTask");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(450);

                entity.HasOne(d => d.BaseSchoolName)
                    .WithMany(p => p.CourseTasks)
                    .HasForeignKey(d => d.BaseSchoolNameId)
                    .HasConstraintName("FK_CourseTask_BaseSchoolName");

                entity.HasOne(d => d.BnaSubjectName)
                    .WithMany(p => p.CourseTasks)
                    .HasForeignKey(d => d.BnaSubjectNameId)
                    .HasConstraintName("FK_CourseTask_BnaSubjectName");

                entity.HasOne(d => d.CourseDuration)
                    .WithMany(p => p.CourseTasks)
                    .HasForeignKey(d => d.CourseDurationId)
                    .HasConstraintName("FK_CourseTask_CourseDuration");

                entity.HasOne(d => d.CourseName)
                    .WithMany(p => p.CourseTasks)
                    .HasForeignKey(d => d.CourseNameId)
                    .HasConstraintName("FK_CourseTask_CourseName");
            });

            modelBuilder.Entity<CourseType>(entity =>
            {
                entity.ToTable("CourseType");

                entity.Property(e => e.CourseTypeName)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CourseWeek>(entity =>
            {
                entity.ToTable("CourseWeek");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateFrom).HasColumnType("datetime");

                entity.Property(e => e.DateTo).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(450);

                entity.Property(e => e.WeekName).HasMaxLength(450);

                entity.HasOne(d => d.BaseSchoolName)
                    .WithMany(p => p.CourseWeeks)
                    .HasForeignKey(d => d.BaseSchoolNameId)
                    .HasConstraintName("FK_CourseWeek_BaseSchoolName");

                entity.HasOne(d => d.CourseDuration)
                    .WithMany(p => p.CourseWeeks)
                    .HasForeignKey(d => d.CourseDurationId)
                    .HasConstraintName("FK_CourseWeek_CourseDuration");

                entity.HasOne(d => d.CourseName)
                    .WithMany(p => p.CourseWeeks)
                    .HasForeignKey(d => d.CourseNameId)
                    .HasConstraintName("FK_CourseWeek_CourseName");
            });

            modelBuilder.Entity<CovidVaccine>(entity =>
            {
                entity.ToTable("CovidVaccine");

                entity.Property(e => e.CovidVaccineId).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NoOfDose).HasMaxLength(450);

                entity.Property(e => e.Place).HasMaxLength(450);

                entity.Property(e => e.Remarks).HasMaxLength(250);

                entity.Property(e => e.VaccineName).HasMaxLength(450);

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.CovidVaccines)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_CovidVaccine_TraineeBioDataGeneralInfo");
            });

            modelBuilder.Entity<CurrencyName>(entity =>
            {
                entity.ToTable("CurrencyName");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(450);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CurrencyNames)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_CurrencyName_Country");
            });

            modelBuilder.Entity<DefenseType>(entity =>
            {
                entity.ToTable("DefenseType");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DefenseTypeName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.ToTable("District");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DistrictName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.Districts)
                    .HasForeignKey(d => d.DivisionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_District_Division");
            });

            modelBuilder.Entity<Division>(entity =>
            {
                entity.ToTable("Division");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DivisionName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.ToTable("Document");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DocumentName).HasMaxLength(450);

                entity.Property(e => e.DocumentUpload).HasMaxLength(450);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CourseDuration)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.CourseDurationId)
                    .HasConstraintName("FK_Document_CourseDuration");

                entity.HasOne(d => d.CourseName)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.CourseNameId)
                    .HasConstraintName("FK_Document_CourseName");

                entity.HasOne(d => d.CourseType)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.CourseTypeId)
                    .HasConstraintName("FK_Document_CourseType");

                entity.HasOne(d => d.InterServiceCourseDocType)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.InterServiceCourseDocTypeId)
                    .HasConstraintName("FK_Document_InterServiceCourseDocType");
            });

            modelBuilder.Entity<DocumentType>(entity =>
            {
                entity.ToTable("DocumentType");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DocumentTypeName).HasMaxLength(450);

                entity.Property(e => e.IconName).HasMaxLength(450);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DojBod>(entity =>
            {
                entity.ToTable("Doj_bod");

                entity.Property(e => e.DojBodid).HasColumnName("Doj_bodid");

                entity.Property(e => e.Branch).HasMaxLength(550);

                entity.Property(e => e.DateofBirth).HasColumnType("datetime");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.FatherName).HasMaxLength(550);

                entity.Property(e => e.FullName).HasMaxLength(550);

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.Mobile1).HasMaxLength(50);

                entity.Property(e => e.MotherName).HasMaxLength(550);

                entity.Property(e => e.NextofKin).HasMaxLength(550);

                entity.Property(e => e.Nid).HasMaxLength(50);

                entity.Property(e => e.NikName).HasMaxLength(550);

                entity.Property(e => e.Pno).HasMaxLength(50);

                entity.Property(e => e.PostingUnitName).HasMaxLength(550);

                entity.Property(e => e.PresentAddress).HasMaxLength(550);

                entity.Property(e => e.Rank).HasMaxLength(50);

                entity.Property(e => e.Relegion).HasMaxLength(50);

                entity.Property(e => e.Sex).HasMaxLength(50);
            });

            modelBuilder.Entity<DownloadRight>(entity =>
            {
                entity.ToTable("DownloadRight");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DownloadRightName).HasMaxLength(450);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EducationalInstitution>(entity =>
            {
                entity.ToTable("EducationalInstitution");

                entity.Property(e => e.AdditionaInformation).HasMaxLength(450);

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.ClassStudiedFrom)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.ClassStudiedTo)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.InstituteName)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.YearFrom).HasColumnType("datetime");

                entity.Property(e => e.YearTo).HasColumnType("datetime");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.EducationalInstitutions)
                    .HasForeignKey(d => d.DistrictId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EducationalInstitutions_District");

                entity.HasOne(d => d.Thana)
                    .WithMany(p => p.EducationalInstitutions)
                    .HasForeignKey(d => d.ThanaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EducationalInstitutions_Thana");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.EducationalInstitutions)
                    .HasForeignKey(d => d.TraineeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EducationalInstitution_TraineeBioDataGeneralInfo");
            });

            modelBuilder.Entity<EducationalQualification>(entity =>
            {
                entity.ToTable("EducationalQualification");

                entity.Property(e => e.AdditionaInformation).HasMaxLength(250);

                entity.Property(e => e.Address).HasMaxLength(150);

                entity.Property(e => e.CourseDuration).HasMaxLength(150);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateAttendedFrom).HasColumnType("datetime");

                entity.Property(e => e.DateAttendedTo).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.InstituteName).HasMaxLength(250);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OutOfResult).HasMaxLength(150);

                entity.Property(e => e.PassingYear).HasMaxLength(150);

                entity.Property(e => e.Result)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Subject).HasMaxLength(150);

                entity.HasOne(d => d.Board)
                    .WithMany(p => p.EducationalQualifications)
                    .HasForeignKey(d => d.BoardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EducationalQualification_Boards");

                entity.HasOne(d => d.ExamType)
                    .WithMany(p => p.EducationalQualifications)
                    .HasForeignKey(d => d.ExamTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EducationalQualification_ExamType");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.EducationalQualifications)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EducationalQualification_Group");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.EducationalQualifications)
                    .HasForeignKey(d => d.TraineeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EducationalQualification_TraineeBioDataGeneralInfo");
            });

            modelBuilder.Entity<Elected>(entity =>
            {
                entity.ToTable("Elected");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.ElectedType)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Election>(entity =>
            {
                entity.ToTable("Election");

                entity.Property(e => e.AdditionalInformation).HasMaxLength(250);

                entity.Property(e => e.AppointmentName).HasMaxLength(150);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DurationFrom).HasColumnType("datetime");

                entity.Property(e => e.DurationTo).HasColumnType("datetime");

                entity.Property(e => e.InstituteName).HasMaxLength(150);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Elected)
                    .WithMany(p => p.Elections)
                    .HasForeignKey(d => d.ElectedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Election_Elected");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.Elections)
                    .HasForeignKey(d => d.TraineeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Election_TraineeBioDataGeneralInfo");
            });

            modelBuilder.Entity<EmploymentBeforeJoinBna>(entity =>
            {
                entity.ToTable("EmploymentBeforeJoinBna");

                entity.Property(e => e.AdditionalInformation).HasMaxLength(150);

                entity.Property(e => e.Appointment)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DurationFrom).HasColumnType("datetime");

                entity.Property(e => e.DurationTo).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Remarks).HasMaxLength(150);

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.EmploymentBeforeJoinBnas)
                    .HasForeignKey(d => d.TraineeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmploymentBeforeJoinBna_TraineeBioDataGeneralInfo");
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.ToTable("Event");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.EventDetails).HasMaxLength(1000);

                entity.Property(e => e.EventHeading).HasMaxLength(450);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.BaseSchoolName)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.BaseSchoolNameId)
                    .HasConstraintName("FK_Event_BaseSchoolName");

                entity.HasOne(d => d.CourseDuration)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.CourseDurationId)
                    .HasConstraintName("FK_Event_CourseDuration");

                entity.HasOne(d => d.CourseName)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.CourseNameId)
                    .HasConstraintName("FK_Event_CourseName");
            });

            modelBuilder.Entity<ExamAttemptType>(entity =>
            {
                entity.ToTable("ExamAttemptType");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.ExamAttemptTypeName).HasMaxLength(450);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ExamCenter>(entity =>
            {
                entity.ToTable("ExamCenter");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.ExamCenterName).HasMaxLength(450);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ExamCenterSelection>(entity =>
            {
                entity.ToTable("ExamCenterSelection");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.BnaExamSchedule)
                    .WithMany(p => p.ExamCenterSelections)
                    .HasForeignKey(d => d.BnaExamScheduleId)
                    .HasConstraintName("FK_ExamCenterSelection_BnaExamSchedule");

                entity.HasOne(d => d.ExamCenter)
                    .WithMany(p => p.ExamCenterSelections)
                    .HasForeignKey(d => d.ExamCenterId)
                    .HasConstraintName("FK_ExamCenterSelection_ExamCenter");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.ExamCenterSelections)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_ExamCenterSelection_TraineeBioDataGeneralInfo");

                entity.HasOne(d => d.TraineeNomination)
                    .WithMany(p => p.ExamCenterSelections)
                    .HasForeignKey(d => d.TraineeNominationId)
                    .HasConstraintName("FK_ExamCenterSelection_TraineeNomination");
            });

            modelBuilder.Entity<ExamMarkRemark>(entity =>
            {
                entity.HasKey(e => e.ExamMarkRemarksId)
                    .HasName("PK_ExamMarkRemarks_1");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MarkRemark).HasMaxLength(250);
            });

            modelBuilder.Entity<ExamPeriodType>(entity =>
            {
                entity.ToTable("ExamPeriodType");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.ExamPeriodName).HasMaxLength(150);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ExamType>(entity =>
            {
                entity.ToTable("ExamType");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.ExamTypeName)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<FailureStatus>(entity =>
            {
                entity.ToTable("FailureStatus");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.FailureStatusName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<FamilyInfo>(entity =>
            {
                entity.ToTable("FamilyInfo");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.FullName).HasMaxLength(250);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.Nid).HasMaxLength(50);

                entity.Property(e => e.Passport).HasMaxLength(250);

                entity.Property(e => e.PermanentAddress).HasMaxLength(500);

                entity.Property(e => e.PresentAddress).HasMaxLength(500);

                entity.Property(e => e.Remarks).HasMaxLength(250);

                entity.HasOne(d => d.Caste)
                    .WithMany(p => p.FamilyInfos)
                    .HasForeignKey(d => d.CasteId)
                    .HasConstraintName("FK_FamilyInfo_Caste");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.FamilyInfos)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_FamilyInfo_District");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.FamilyInfos)
                    .HasForeignKey(d => d.DivisionId)
                    .HasConstraintName("FK_FamilyInfo_Division");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.FamilyInfos)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK_FamilyInfo_Gender");

                entity.HasOne(d => d.Nationality)
                    .WithMany(p => p.FamilyInfos)
                    .HasForeignKey(d => d.NationalityId)
                    .HasConstraintName("FK_FamilyInfo_Nationality");

                entity.HasOne(d => d.RelationType)
                    .WithMany(p => p.FamilyInfos)
                    .HasForeignKey(d => d.RelationTypeId)
                    .HasConstraintName("FK_FamilyInfo_RelationType");

                entity.HasOne(d => d.Religion)
                    .WithMany(p => p.FamilyInfos)
                    .HasForeignKey(d => d.ReligionId)
                    .HasConstraintName("FK_FamilyInfo_Religion");

                entity.HasOne(d => d.Thana)
                    .WithMany(p => p.FamilyInfos)
                    .HasForeignKey(d => d.ThanaId)
                    .HasConstraintName("FK_FamilyInfo_Thana");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.FamilyInfos)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_FamilyInfo_TraineeBioDataGeneralInfo");
            });

            modelBuilder.Entity<FamilyNomination>(entity =>
            {
                entity.ToTable("FamilyNomination");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(450);

                entity.HasOne(d => d.CourseDuration)
                    .WithMany(p => p.FamilyNominations)
                    .HasForeignKey(d => d.CourseDurationId)
                    .HasConstraintName("FK_FamilyNomination_CourseDuration");

                entity.HasOne(d => d.FamilyInfo)
                    .WithMany(p => p.FamilyNominations)
                    .HasForeignKey(d => d.FamilyInfoId)
                    .HasConstraintName("FK_FamilyNomination_FamilyInfo");

                entity.HasOne(d => d.FundingDetail)
                    .WithMany(p => p.FamilyNominations)
                    .HasForeignKey(d => d.FundingDetailId)
                    .HasConstraintName("FK_FamilyNomination_CodeValue");

                entity.HasOne(d => d.RelationType)
                    .WithMany(p => p.FamilyNominations)
                    .HasForeignKey(d => d.RelationTypeId)
                    .HasConstraintName("FK_FamilyNomination_RelationType");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.FamilyNominations)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_FamilyNomination_TraineeBioDataGeneralInfo");

                entity.HasOne(d => d.TraineeNomination)
                    .WithMany(p => p.FamilyNominations)
                    .HasForeignKey(d => d.TraineeNominationId)
                    .HasConstraintName("FK_FamilyNomination_TraineeNomination");
            });

            modelBuilder.Entity<Favorite>(entity =>
            {
                entity.HasKey(e => e.FavoritesId);

                entity.Property(e => e.AdditionalInformation).HasMaxLength(450);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.FavoritesName).HasMaxLength(450);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.FavoritesType)
                    .WithMany(p => p.Favorites)
                    .HasForeignKey(d => d.FavoritesTypeId)
                    .HasConstraintName("FK_Favorites_FavoritesType");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.Favorites)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_Favorites_TraineeBioDataGeneralInfo");
            });

            modelBuilder.Entity<FavoritesType>(entity =>
            {
                entity.ToTable("FavoritesType");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.FavoritesTypeName)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Feature>(entity =>
            {
                entity.ToTable("Feature");

                entity.Property(e => e.Class).HasMaxLength(250);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.FeatureName)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.GroupTitle).HasMaxLength(250);

                entity.Property(e => e.Icon).HasMaxLength(250);

                entity.Property(e => e.IconName).HasMaxLength(250);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.Features)
                    .HasForeignKey(d => d.ModuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Feature_Module");
            });

            modelBuilder.Entity<FiscalYear>(entity =>
            {
                entity.ToTable("FiscalYear");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.FiscalYearName).HasMaxLength(450);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ShortName).HasMaxLength(450);
            });

            modelBuilder.Entity<ForceType>(entity =>
            {
                entity.ToTable("ForceType");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.ForceTypeName)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ForeignCourseDocType>(entity =>
            {
                entity.ToTable("ForeignCourseDocType");

                entity.Property(e => e.ForeignCourseDocTypeId).HasColumnName("ForeignCourseDocTypeID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(450);

                entity.Property(e => e.Remarks).HasMaxLength(450);
            });

            modelBuilder.Entity<ForeignCourseGoinfo>(entity =>
            {
                entity.ToTable("ForeignCourseGOInfo");

                entity.Property(e => e.ForeignCourseGoinfoId).HasColumnName("ForeignCourseGOInfoId");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DocumentName).HasMaxLength(450);

                entity.Property(e => e.FileUpload).HasMaxLength(450);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(450);

                entity.HasOne(d => d.CourseDuration)
                    .WithMany(p => p.ForeignCourseGoinfos)
                    .HasForeignKey(d => d.CourseDurationId)
                    .HasConstraintName("FK_ForeignCourseGOInfo_CourseDuration");

                entity.HasOne(d => d.CourseName)
                    .WithMany(p => p.ForeignCourseGoinfos)
                    .HasForeignKey(d => d.CourseNameId)
                    .HasConstraintName("FK_ForeignCourseGOInfo_CourseName");
            });

            modelBuilder.Entity<ForeignCourseOtherDoc>(entity =>
            {
                entity.ToTable("ForeignCourseOtherDoc");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.FamilyGo).HasMaxLength(450);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MedicalDocument).HasMaxLength(450);

                entity.Property(e => e.Remark).HasMaxLength(450);

                entity.HasOne(d => d.CourseDuration)
                    .WithMany(p => p.ForeignCourseOtherDocs)
                    .HasForeignKey(d => d.CourseDurationId)
                    .HasConstraintName("FK_ForeignCourseOtherDoc_CourseDuration");

                entity.HasOne(d => d.CourseName)
                    .WithMany(p => p.ForeignCourseOtherDocs)
                    .HasForeignKey(d => d.CourseNameId)
                    .HasConstraintName("FK_ForeignCourseOtherDoc_CourseName");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.ForeignCourseOtherDocs)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_ForeignCourseOtherDoc_TraineeBioDataGeneralInfo");

                entity.HasOne(d => d.TraineeNomination)
                    .WithMany(p => p.ForeignCourseOtherDocs)
                    .HasForeignKey(d => d.TraineeNominationId)
                    .HasConstraintName("FK_ForeignCourseOtherDoc_TraineeNomination");
            });

            modelBuilder.Entity<ForeignCourseOthersDocument>(entity =>
            {
                entity.ToTable("ForeignCourseOthersDocument");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.FileUpload).HasMaxLength(450);

                entity.Property(e => e.ForeignCourseDocTypeId).HasColumnName("ForeignCourseDocTypeID");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(450);

                entity.HasOne(d => d.CourseDuration)
                    .WithMany(p => p.ForeignCourseOthersDocuments)
                    .HasForeignKey(d => d.CourseDurationId)
                    .HasConstraintName("FK_ForeignCourseOthersDocument_CourseDuration");

                entity.HasOne(d => d.CourseName)
                    .WithMany(p => p.ForeignCourseOthersDocuments)
                    .HasForeignKey(d => d.CourseNameId)
                    .HasConstraintName("FK_ForeignCourseOthersDocument_CourseName");

                entity.HasOne(d => d.ForeignCourseDocType)
                    .WithMany(p => p.ForeignCourseOthersDocuments)
                    .HasForeignKey(d => d.ForeignCourseDocTypeId)
                    .HasConstraintName("FK_ForeignCourseOthersDocument_ForeignCourseDocType");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.ForeignCourseOthersDocuments)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_ForeignCourseOthersDocument_TraineeBioDataGeneralInfo");
            });

            modelBuilder.Entity<Game>(entity =>
            {
                entity.ToTable("Game");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.GameName)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<GameSport>(entity =>
            {
                entity.ToTable("GameSport");

                entity.Property(e => e.AdditionalInformation).HasMaxLength(450);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LevelOfParticipation).HasMaxLength(450);

                entity.Property(e => e.Performance).HasMaxLength(450);

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.GameSports)
                    .HasForeignKey(d => d.GameId)
                    .HasConstraintName("FK_GameSports_Game");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.GameSports)
                    .HasForeignKey(d => d.TraineeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GameSport_TraineeBioDataGeneralInfo");
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.ToTable("Gender");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.GenderName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<GrandFather>(entity =>
            {
                entity.ToTable("GrandFather");

                entity.Property(e => e.AdditionalInformation).HasMaxLength(150);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.GrandFathersName).HasMaxLength(150);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.DeadStatusNavigation)
                    .WithMany(p => p.GrandFathers)
                    .HasForeignKey(d => d.DeadStatus)
                    .HasConstraintName("FK_GrandFather_CodeValue");

                entity.HasOne(d => d.GrandFatherType)
                    .WithMany(p => p.GrandFathers)
                    .HasForeignKey(d => d.GrandFatherTypeId)
                    .HasConstraintName("FK_GrandFather_GrandFatherType");

                entity.HasOne(d => d.Nationality)
                    .WithMany(p => p.GrandFathers)
                    .HasForeignKey(d => d.NationalityId)
                    .HasConstraintName("FK_GrandFather_Nationality");

                entity.HasOne(d => d.Occupation)
                    .WithMany(p => p.GrandFathers)
                    .HasForeignKey(d => d.OccupationId)
                    .HasConstraintName("FK_GrandFather_Occupation");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.GrandFathers)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_GrandFather_TraineeBioDataGeneralInfo");
            });

            modelBuilder.Entity<GrandFatherType>(entity =>
            {
                entity.ToTable("GrandFatherType");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.GrandfatherTypeName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.ToTable("Group");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<GuestSpeakerActionStatus>(entity =>
            {
                entity.ToTable("GuestSpeakerActionStatus");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(450);
            });

            modelBuilder.Entity<GuestSpeakerGroupResult>(entity =>
            {
                entity.ToTable("GuestSpeakerGroupResult");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<GuestSpeakerQuationGroup>(entity =>
            {
                entity.ToTable("GuestSpeakerQuationGroup");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.BaseSchoolName)
                    .WithMany(p => p.GuestSpeakerQuationGroups)
                    .HasForeignKey(d => d.BaseSchoolNameId)
                    .HasConstraintName("FK_GuestSpeakerQuationGroup_BaseSchoolName");

                entity.HasOne(d => d.BnaExamInstructorAssign)
                    .WithMany(p => p.GuestSpeakerQuationGroups)
                    .HasForeignKey(d => d.BnaExamInstructorAssignId)
                    .HasConstraintName("FK_GuestSpeakerQuationGroup_BnaExamInstructorAssign");

                entity.HasOne(d => d.BnaSubjectName)
                    .WithMany(p => p.GuestSpeakerQuationGroups)
                    .HasForeignKey(d => d.BnaSubjectNameId)
                    .HasConstraintName("FK_GuestSpeakerQuationGroup_BnaSubjectName");

                entity.HasOne(d => d.CourseDuration)
                    .WithMany(p => p.GuestSpeakerQuationGroups)
                    .HasForeignKey(d => d.CourseDurationId)
                    .HasConstraintName("FK_GuestSpeakerQuationGroup_CourseDuration");

                entity.HasOne(d => d.CourseName)
                    .WithMany(p => p.GuestSpeakerQuationGroups)
                    .HasForeignKey(d => d.CourseNameId)
                    .HasConstraintName("FK_GuestSpeakerQuationGroup_CourseName");

                entity.HasOne(d => d.GuestSpeakerQuestionName)
                    .WithMany(p => p.GuestSpeakerQuationGroups)
                    .HasForeignKey(d => d.GuestSpeakerQuestionNameId)
                    .HasConstraintName("FK_GuestSpeakerQuationGroup_GuestSpeakerQuestionName");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.GuestSpeakerQuationGroups)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_GuestSpeakerQuationGroup_TraineeBioDataGeneralInfo");
            });

            modelBuilder.Entity<GuestSpeakerQuestionName>(entity =>
            {
                entity.ToTable("GuestSpeakerQuestionName");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(450);
            });

            modelBuilder.Entity<HairColor>(entity =>
            {
                entity.ToTable("HairColor");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.HairColorName)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Height>(entity =>
            {
                entity.ToTable("Height");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.HeightName)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<IndividualBulletin>(entity =>
            {
                entity.ToTable("IndividualBulletin");

                entity.Property(e => e.BulletinDetails).HasMaxLength(4000);

                entity.Property(e => e.CreatedBy).HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.BaseSchoolName)
                    .WithMany(p => p.IndividualBulletins)
                    .HasForeignKey(d => d.BaseSchoolNameId)
                    .HasConstraintName("FK_IndividualBulletin_BaseSchoolName");

                entity.HasOne(d => d.CourseDuration)
                    .WithMany(p => p.IndividualBulletins)
                    .HasForeignKey(d => d.CourseDurationId)
                    .HasConstraintName("FK_IndividualBulletin_CourseDuration");

                entity.HasOne(d => d.CourseInstructor)
                    .WithMany(p => p.IndividualBulletins)
                    .HasForeignKey(d => d.CourseInstructorId)
                    .HasConstraintName("FK_IndividualBulletin_CourseInstructor");

                entity.HasOne(d => d.CourseName)
                    .WithMany(p => p.IndividualBulletins)
                    .HasForeignKey(d => d.CourseNameId)
                    .HasConstraintName("FK_IndividualBulletin_CourseName");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.IndividualBulletins)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_IndividualBulletin_TraineeBioDataGeneralInfo");

                entity.HasOne(d => d.TraineeNomination)
                    .WithMany(p => p.IndividualBulletins)
                    .HasForeignKey(d => d.TraineeNominationId)
                    .HasConstraintName("FK_IndividualBulletin_TraineeNomination");
            });

            modelBuilder.Entity<IndividualNotice>(entity =>
            {
                entity.ToTable("IndividualNotice");

                entity.Property(e => e.CreatedBy).HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NoticeDetails).HasMaxLength(4000);

                entity.Property(e => e.NoticeHeading).HasMaxLength(450);

                entity.HasOne(d => d.BaseSchoolName)
                    .WithMany(p => p.IndividualNotices)
                    .HasForeignKey(d => d.BaseSchoolNameId)
                    .HasConstraintName("FK_IndividualNotice_BaseSchoolName");

                entity.HasOne(d => d.CourseDuration)
                    .WithMany(p => p.IndividualNotices)
                    .HasForeignKey(d => d.CourseDurationId)
                    .HasConstraintName("FK_IndividualNotice_CourseDuration");

                entity.HasOne(d => d.CourseInstructor)
                    .WithMany(p => p.IndividualNotices)
                    .HasForeignKey(d => d.CourseInstructorId)
                    .HasConstraintName("FK_IndividualNotice_CourseInstructor");

                entity.HasOne(d => d.CourseName)
                    .WithMany(p => p.IndividualNotices)
                    .HasForeignKey(d => d.CourseNameId)
                    .HasConstraintName("FK_IndividualNotice_CourseName");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.IndividualNotices)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_IndividualNotice_TraineeBioDataGeneralInfo");

                entity.HasOne(d => d.TraineeNomination)
                    .WithMany(p => p.IndividualNotices)
                    .HasForeignKey(d => d.TraineeNominationId)
                    .HasConstraintName("FK_IndividualNotice_TraineeNomination");
            });

            modelBuilder.Entity<InstallmentPaidDetail>(entity =>
            {
                entity.ToTable("InstallmentPaidDetail");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(150);

                entity.Property(e => e.ScheduleDate).HasColumnType("datetime");

                entity.HasOne(d => d.CourseDuration)
                    .WithMany(p => p.InstallmentPaidDetails)
                    .HasForeignKey(d => d.CourseDurationId)
                    .HasConstraintName("FK_InstallmentPaidDetail_CourseDuration");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.InstallmentPaidDetails)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_InstallmentPaidDetail_TraineeBioDataGeneralInfo");
            });

            modelBuilder.Entity<InstructorAssignment>(entity =>
            {
                entity.ToTable("InstructorAssignment");

                entity.Property(e => e.CreatedBy).HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.BnaSubjectName)
                    .WithMany(p => p.InstructorAssignments)
                    .HasForeignKey(d => d.BnaSubjectNameId)
                    .HasConstraintName("FK_InstructorAssignment_BaseSchoolName");

                entity.HasOne(d => d.CourseDuration)
                    .WithMany(p => p.InstructorAssignments)
                    .HasForeignKey(d => d.CourseDurationId)
                    .HasConstraintName("FK_InstructorAssignment_CourseDuration");

                entity.HasOne(d => d.CourseInstructor)
                    .WithMany(p => p.InstructorAssignments)
                    .HasForeignKey(d => d.CourseInstructorId)
                    .HasConstraintName("FK_InstructorAssignment_CourseInstructor");

                entity.HasOne(d => d.CourseName)
                    .WithMany(p => p.InstructorAssignments)
                    .HasForeignKey(d => d.CourseNameId)
                    .HasConstraintName("FK_InstructorAssignment_CourseName");
            });

            modelBuilder.Entity<InterServiceCourseDocType>(entity =>
            {
                entity.ToTable("InterServiceCourseDocType");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(450);

                entity.Property(e => e.Remarks).HasMaxLength(450);
            });

            modelBuilder.Entity<InterServiceCourseReport>(entity =>
            {
                entity.ToTable("InterServiceCourseReport");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Doc).HasMaxLength(450);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(450);

                entity.HasOne(d => d.CourseDuration)
                    .WithMany(p => p.InterServiceCourseReports)
                    .HasForeignKey(d => d.CourseDurationId)
                    .HasConstraintName("FK_InterServiceCourseReport_CourseDuration");

                entity.HasOne(d => d.CourseName)
                    .WithMany(p => p.InterServiceCourseReports)
                    .HasForeignKey(d => d.CourseNameId)
                    .HasConstraintName("FK_InterServiceCourseReport_CourseName");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.InterServiceCourseReports)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_InterServiceCourseReport_TraineeBioDataGeneralInfo");
            });

            modelBuilder.Entity<InterServiceMark>(entity =>
            {
                entity.ToTable("InterServiceMark");

                entity.Property(e => e.CoursePosition).HasMaxLength(450);

                entity.Property(e => e.CreatedBy).HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Doc).HasMaxLength(450);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ObtaintMark).HasMaxLength(450);

                entity.Property(e => e.Remarks).HasMaxLength(450);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.InterServiceMarks)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_InterServiceMark_Country");

                entity.HasOne(d => d.CourseDuration)
                    .WithMany(p => p.InterServiceMarks)
                    .HasForeignKey(d => d.CourseDurationId)
                    .HasConstraintName("FK_InterServiceMark_CourseDuration");

                entity.HasOne(d => d.CourseName)
                    .WithMany(p => p.InterServiceMarks)
                    .HasForeignKey(d => d.CourseNameId)
                    .HasConstraintName("FK_InterServiceMark_CourseName");

                entity.HasOne(d => d.CourseType)
                    .WithMany(p => p.InterServiceMarks)
                    .HasForeignKey(d => d.CourseTypeId)
                    .HasConstraintName("FK_InterServiceMark_CourseType");

                entity.HasOne(d => d.OrganizationName)
                    .WithMany(p => p.InterServiceMarks)
                    .HasForeignKey(d => d.OrganizationNameId)
                    .HasConstraintName("FK_InterServiceMark_OrganizationName");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.InterServiceMarks)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_InterServiceMark_TraineeBioDataGeneralInfo");

                entity.HasOne(d => d.TraineeNomination)
                    .WithMany(p => p.InterServiceMarks)
                    .HasForeignKey(d => d.TraineeNominationId)
                    .HasConstraintName("FK_InterServiceMark_TraineeNomination");
            });

            modelBuilder.Entity<InterServiceOthersDoc>(entity =>
            {
                entity.ToTable("InterServiceOthersDoc");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.FileUpload).HasMaxLength(450);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(450);

                entity.HasOne(d => d.CourseDuration)
                    .WithMany(p => p.InterServiceOthersDocs)
                    .HasForeignKey(d => d.CourseDurationId)
                    .HasConstraintName("FK_InterServiceOthersDoc_CourseDuration");

                entity.HasOne(d => d.CourseName)
                    .WithMany(p => p.InterServiceOthersDocs)
                    .HasForeignKey(d => d.CourseNameId)
                    .HasConstraintName("FK_InterServiceOthersDoc_CourseName");

                entity.HasOne(d => d.InterServiceCourseDocType)
                    .WithMany(p => p.InterServiceOthersDocs)
                    .HasForeignKey(d => d.InterServiceCourseDocTypeId)
                    .HasConstraintName("FK_InterServiceOthersDoc_InterServiceCourseDocType");
            });

            modelBuilder.Entity<JoiningReason>(entity =>
            {
                entity.ToTable("JoiningReason");

                entity.Property(e => e.AdditionlInformation).HasMaxLength(450);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.IfAnotherReason).HasMaxLength(450);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ReasonType)
                    .WithMany(p => p.JoiningReasons)
                    .HasForeignKey(d => d.ReasonTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JoiningReason_ReasonType");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.JoiningReasons)
                    .HasForeignKey(d => d.TraineeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JoiningReason_TraineeBioDataGeneralInfo");
            });

            modelBuilder.Entity<KindOfSubject>(entity =>
            {
                entity.ToTable("KindOfSubject");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.KindOfSubjectName).HasMaxLength(450);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.ToTable("Language");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LanguageName)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MaritalStatus>(entity =>
            {
                entity.ToTable("MaritalStatus");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MaritalStatusName)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<MarkType>(entity =>
            {
                entity.ToTable("MarkType");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ShortName).HasMaxLength(250);

                entity.Property(e => e.TypeName).HasMaxLength(250);
            });

            modelBuilder.Entity<MemberShipType>(entity =>
            {
                entity.ToTable("MemberShipType");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MembershipTypeName)
                    .IsRequired()
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<MigrationDocument>(entity =>
            {
                entity.ToTable("MigrationDocument");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(150);

                entity.HasOne(d => d.CourseDuration)
                    .WithMany(p => p.MigrationDocuments)
                    .HasForeignKey(d => d.CourseDurationId)
                    .HasConstraintName("FK_MigrationDocuments_CourseDuration");

                entity.HasOne(d => d.RelationType)
                    .WithMany(p => p.MigrationDocuments)
                    .HasForeignKey(d => d.RelationTypeId)
                    .HasConstraintName("FK_MigrationDocuments_RelationType");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.MigrationDocuments)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_MigrationDocuments_TraineeBioDataGeneralInfo");

                entity.HasOne(d => d.TraineeNomination)
                    .WithMany(p => p.MigrationDocuments)
                    .HasForeignKey(d => d.TraineeNominationId)
                    .HasConstraintName("FK_MigrationDocuments_TraineeNomination");
            });

            modelBuilder.Entity<MilitaryTraining>(entity =>
            {
                entity.ToTable("MilitaryTraining");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateAttended).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DetailsOfCourse).HasMaxLength(450);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LocationOfTrg).HasMaxLength(450);

                entity.Property(e => e.Remarks).HasMaxLength(450);

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.MilitaryTrainings)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_MilitaryTraining_TraineeBioDataGeneralInfo");
            });

            modelBuilder.Entity<Module>(entity =>
            {
                entity.ToTable("Module");

                entity.Property(e => e.Class).HasMaxLength(250);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.GroupTitle).HasMaxLength(250);

                entity.Property(e => e.Icon).HasMaxLength(250);

                entity.Property(e => e.IconName).HasMaxLength(250);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModuleName).HasMaxLength(450);

                entity.Property(e => e.Title).HasMaxLength(450);
            });

            modelBuilder.Entity<Nationality>(entity =>
            {
                entity.ToTable("Nationality");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NationalityName)
                    .IsRequired()
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<NewAtempt>(entity =>
            {
                entity.ToTable("NewAtempt");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(450);
            });

            modelBuilder.Entity<NewEntryEvaluation>(entity =>
            {
                entity.ToTable("NewEntryEvaluation");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(450);

                entity.HasOne(d => d.BaseSchoolName)
                    .WithMany(p => p.NewEntryEvaluations)
                    .HasForeignKey(d => d.BaseSchoolNameId)
                    .HasConstraintName("FK_NewEntryEvaluation_BaseSchoolName");

                entity.HasOne(d => d.CourseDuration)
                    .WithMany(p => p.NewEntryEvaluations)
                    .HasForeignKey(d => d.CourseDurationId)
                    .HasConstraintName("FK_NewEntryEvaluation_CourseDuration");

                entity.HasOne(d => d.CourseModule)
                    .WithMany(p => p.NewEntryEvaluations)
                    .HasForeignKey(d => d.CourseModuleId)
                    .HasConstraintName("FK_NewEntryEvaluation_CourseModule");

                entity.HasOne(d => d.CourseName)
                    .WithMany(p => p.NewEntryEvaluations)
                    .HasForeignKey(d => d.CourseNameId)
                    .HasConstraintName("FK_NewEntryEvaluation_CourseName");

                entity.HasOne(d => d.CourseWeek)
                    .WithMany(p => p.NewEntryEvaluations)
                    .HasForeignKey(d => d.CourseWeekId)
                    .HasConstraintName("FK_NewEntryEvaluation_CourseWeek");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.NewEntryEvaluations)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_NewEntryEvaluation_TraineeBioDataGeneralInfo");

                entity.HasOne(d => d.TraineeNomination)
                    .WithMany(p => p.NewEntryEvaluations)
                    .HasForeignKey(d => d.TraineeNominationId)
                    .HasConstraintName("FK_NewEntryEvaluation_TraineeNomination");
            });

            modelBuilder.Entity<Notice>(entity =>
            {
                entity.ToTable("Notice");

                entity.Property(e => e.CreatedBy).HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NoticeDetails).HasMaxLength(4000);

                entity.Property(e => e.NoticeHeading).HasMaxLength(450);

                entity.HasOne(d => d.BaseSchoolName)
                    .WithMany(p => p.Notices)
                    .HasForeignKey(d => d.BaseSchoolNameId)
                    .HasConstraintName("FK_Notice_BaseSchoolName");

                entity.HasOne(d => d.CourseDuration)
                    .WithMany(p => p.Notices)
                    .HasForeignKey(d => d.CourseDurationId)
                    .HasConstraintName("FK_Notice_CourseDuration");

                entity.HasOne(d => d.CourseInstructor)
                    .WithMany(p => p.Notices)
                    .HasForeignKey(d => d.CourseInstructorId)
                    .HasConstraintName("FK_Notice_CourseInstructor");

                entity.HasOne(d => d.CourseName)
                    .WithMany(p => p.Notices)
                    .HasForeignKey(d => d.CourseNameId)
                    .HasConstraintName("FK_Notice_CourseName");

                entity.HasOne(d => d.TraineeNomination)
                    .WithMany(p => p.Notices)
                    .HasForeignKey(d => d.TraineeNominationId)
                    .HasConstraintName("FK_Notice_TraineeNomination");
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.ToTable("Notification");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Notes).HasMaxLength(1500);

                entity.Property(e => e.ReceiverRole).HasMaxLength(450);

                entity.Property(e => e.SenderRole).HasMaxLength(450);

                entity.HasOne(d => d.ReceivedBaseSchoolName)
                    .WithMany(p => p.NotificationReceivedBaseSchoolNames)
                    .HasForeignKey(d => d.ReceivedBaseSchoolNameId)
                    .HasConstraintName("FK_Notification_BaseSchoolName1");

                entity.HasOne(d => d.SendBaseSchoolName)
                    .WithMany(p => p.NotificationSendBaseSchoolNames)
                    .HasForeignKey(d => d.SendBaseSchoolNameId)
                    .HasConstraintName("FK_Notification_BaseSchoolName");
            });

            modelBuilder.Entity<Occupation>(entity =>
            {
                entity.ToTable("Occupation");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OccupationName)
                    .IsRequired()
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<OrganizationName>(entity =>
            {
                entity.ToTable("OrganizationName");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(450);

                entity.HasOne(d => d.ForceType)
                    .WithMany(p => p.OrganizationNames)
                    .HasForeignKey(d => d.ForceTypeId)
                    .HasConstraintName("FK_OrganizationName_ForceType");
            });

            modelBuilder.Entity<ParentRelative>(entity =>
            {
                entity.ToTable("ParentRelative");

                entity.Property(e => e.AdditionalInformation).HasMaxLength(450);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.DateOfExpiry).HasColumnType("datetime");

                entity.Property(e => e.DateOfMarriage).HasColumnType("datetime");

                entity.Property(e => e.DualNationality)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EducationQualification).HasMaxLength(250);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.IsDefenceJobExperience)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MigrationDate).HasColumnType("datetime");

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.MonthlyIncome).HasMaxLength(150);

                entity.Property(e => e.NameInFull).HasMaxLength(150);

                entity.Property(e => e.OccupationDetail).HasMaxLength(250);

                entity.Property(e => e.ParmanentAddress).HasMaxLength(450);

                entity.Property(e => e.PlaceOfBirth).HasMaxLength(450);

                entity.Property(e => e.PostCode).HasMaxLength(20);

                entity.Property(e => e.PresentAddress).HasMaxLength(450);

                entity.Property(e => e.ReasonOfMigration).HasMaxLength(450);

                entity.Property(e => e.Remarks).HasMaxLength(450);

                entity.Property(e => e.RetiredDate).HasColumnType("datetime");

                entity.HasOne(d => d.Caste)
                    .WithMany(p => p.ParentRelatives)
                    .HasForeignKey(d => d.CasteId)
                    .HasConstraintName("FK_ParentRelative_Caste");

                entity.HasOne(d => d.DeadStatusNavigation)
                    .WithMany(p => p.ParentRelatives)
                    .HasForeignKey(d => d.DeadStatus)
                    .HasConstraintName("FK_ParentRelative_CodeValue");

                entity.HasOne(d => d.DefenseType)
                    .WithMany(p => p.ParentRelatives)
                    .HasForeignKey(d => d.DefenseTypeId)
                    .HasConstraintName("FK_ParentRelative_DefenseType");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.ParentRelatives)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_ParentRelative_District");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.ParentRelatives)
                    .HasForeignKey(d => d.DivisionId)
                    .HasConstraintName("FK_ParentRelative_Division");

                entity.HasOne(d => d.MaritalStatus)
                    .WithMany(p => p.ParentRelatives)
                    .HasForeignKey(d => d.MaritalStatusId)
                    .HasConstraintName("FK_ParentRelative_MaritalStatus");

                entity.HasOne(d => d.Nationality)
                    .WithMany(p => p.ParentRelativeNationalities)
                    .HasForeignKey(d => d.NationalityId)
                    .HasConstraintName("FK_ParentRelative_Nationality");

                entity.HasOne(d => d.Occupation)
                    .WithMany(p => p.ParentRelativeOccupations)
                    .HasForeignKey(d => d.OccupationId)
                    .HasConstraintName("FK_ParentRelative_Occupation");

                entity.HasOne(d => d.PreviousOccupation)
                    .WithMany(p => p.ParentRelativePreviousOccupations)
                    .HasForeignKey(d => d.PreviousOccupationId)
                    .HasConstraintName("FK_ParentRelative_PreviousOccupation");

                entity.HasOne(d => d.Rank)
                    .WithMany(p => p.ParentRelatives)
                    .HasForeignKey(d => d.RankId)
                    .HasConstraintName("FK_ParentRelative_Rank");

                entity.HasOne(d => d.RelationType)
                    .WithMany(p => p.ParentRelatives)
                    .HasForeignKey(d => d.RelationTypeId)
                    .HasConstraintName("FK_ParentRelative_RelationType");

                entity.HasOne(d => d.Religion)
                    .WithMany(p => p.ParentRelatives)
                    .HasForeignKey(d => d.ReligionId)
                    .HasConstraintName("FK_ParentRelative_Religion");

                entity.HasOne(d => d.SecondNationality)
                    .WithMany(p => p.ParentRelativeSecondNationalities)
                    .HasForeignKey(d => d.SecondNationalityId)
                    .HasConstraintName("FK_ParentRelative_SecondNationality");

                entity.HasOne(d => d.Thana)
                    .WithMany(p => p.ParentRelatives)
                    .HasForeignKey(d => d.ThanaId)
                    .HasConstraintName("FK_ParentRelative_Thana");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.ParentRelatives)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_ParentRelative_TraineeBioDataGeneralInfo");
            });

            modelBuilder.Entity<PaymentDetail>(entity =>
            {
                entity.ToTable("PaymentDetail");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NumberOfInstallment).HasMaxLength(150);

                entity.Property(e => e.Remarks).HasMaxLength(150);

                entity.Property(e => e.TotalBdt).HasMaxLength(150);

                entity.Property(e => e.TotalUsd).HasMaxLength(150);

                entity.Property(e => e.UsdRate).HasMaxLength(150);

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.PaymentDetails)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_PaymentDetail_TraineeBioDataGeneralInfo");
            });

            modelBuilder.Entity<PaymentType>(entity =>
            {
                entity.ToTable("PaymentType");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentTypeName).HasMaxLength(450);
            });

            modelBuilder.Entity<PresentBillet>(entity =>
            {
                entity.ToTable("PresentBillet");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PresentBilletName)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.ToTable("Question");

                entity.Property(e => e.AdditionalInformation).HasMaxLength(250);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.QuestionType)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.QuestionTypeId)
                    .HasConstraintName("FK_Question_QuestionType");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_Question_TraineeBioDataGeneralInfo");
            });

            modelBuilder.Entity<QuestionType>(entity =>
            {
                entity.ToTable("QuestionType");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<Rank>(entity =>
            {
                entity.ToTable("Rank");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.RankName)
                    .IsRequired()
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<ReadingMaterial>(entity =>
            {
                entity.ToTable("ReadingMaterial");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.ApprovedUser).HasMaxLength(250);

                entity.Property(e => e.AurhorName).HasMaxLength(450);

                entity.Property(e => e.CreatedBy).HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DocumentLink).HasMaxLength(250);

                entity.Property(e => e.DocumentName).HasMaxLength(250);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PublisherName).HasMaxLength(450);

                entity.HasOne(d => d.BaseSchoolName)
                    .WithMany(p => p.ReadingMaterials)
                    .HasForeignKey(d => d.BaseSchoolNameId)
                    .HasConstraintName("FK_ReadingMaterial_BaseSchoolName");

                entity.HasOne(d => d.CourseName)
                    .WithMany(p => p.ReadingMaterials)
                    .HasForeignKey(d => d.CourseNameId)
                    .HasConstraintName("FK_ReadingMaterial_CourseName");

                entity.HasOne(d => d.DocumentType)
                    .WithMany(p => p.ReadingMaterials)
                    .HasForeignKey(d => d.DocumentTypeId)
                    .HasConstraintName("FK_ReadingMaterial_DocumentType");

                entity.HasOne(d => d.DownloadRight)
                    .WithMany(p => p.ReadingMaterials)
                    .HasForeignKey(d => d.DownloadRightId)
                    .HasConstraintName("FK_ReadingMaterial_DownloadRight");

                entity.HasOne(d => d.ReadingMaterialTitle)
                    .WithMany(p => p.ReadingMaterials)
                    .HasForeignKey(d => d.ReadingMaterialTitleId)
                    .HasConstraintName("FK_ReadingMaterial_ReadingMaterialTitle");
            });

            modelBuilder.Entity<ReadingMaterialTitle>(entity =>
            {
                entity.ToTable("ReadingMaterialTitle");

                entity.Property(e => e.CreatedBy).HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(450);
            });

            modelBuilder.Entity<ReasonType>(entity =>
            {
                entity.ToTable("ReasonType");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ReasonTypeName)
                    .IsRequired()
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<RecordOfService>(entity =>
            {
                entity.ToTable("RecordOfService");

                entity.Property(e => e.Appointment).HasMaxLength(550);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateFrom).HasColumnType("datetime");

                entity.Property(e => e.DateTo).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(550);

                entity.Property(e => e.ShipEstablishment).HasMaxLength(1050);

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.RecordOfServices)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_RecordOfService_TraineeBioDataGeneralInfo");
            });

            modelBuilder.Entity<RelationType>(entity =>
            {
                entity.ToTable("RelationType");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RelationTypeName)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Religion>(entity =>
            {
                entity.ToTable("Religion");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ReligionName)
                    .IsRequired()
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<ResultStatus>(entity =>
            {
                entity.ToTable("ResultStatus");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ResultStatusName).HasMaxLength(450);
            });

            modelBuilder.Entity<RoleFeature>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.FeatureKey })
                    .HasName("PK_Company.RoleFeature");

                entity.ToTable("RoleFeature");
            });

            modelBuilder.Entity<RoutineNote>(entity =>
            {
                entity.ToTable("RoutineNote");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RoutineNotes).HasMaxLength(4000);

                entity.HasOne(d => d.BaseSchoolName)
                    .WithMany(p => p.RoutineNotes)
                    .HasForeignKey(d => d.BaseSchoolNameId)
                    .HasConstraintName("FK_RoutineNote_BaseSchoolName");

                entity.HasOne(d => d.BnaSubjectName)
                    .WithMany(p => p.RoutineNotes)
                    .HasForeignKey(d => d.BnaSubjectNameId)
                    .HasConstraintName("FK_RoutineNote_BnaSubjectName");

                entity.HasOne(d => d.ClassRoutine)
                    .WithMany(p => p.RoutineNotes)
                    .HasForeignKey(d => d.ClassRoutineId)
                    .HasConstraintName("FK_RoutineNote_ClassRoutine");

                entity.HasOne(d => d.CourseDuration)
                    .WithMany(p => p.RoutineNotes)
                    .HasForeignKey(d => d.CourseDurationId)
                    .HasConstraintName("FK_RoutineNote_CourseDuration");

                entity.HasOne(d => d.CourseName)
                    .WithMany(p => p.RoutineNotes)
                    .HasForeignKey(d => d.CourseNameId)
                    .HasConstraintName("FK_RoutineNote_CourseName");
            });

            modelBuilder.Entity<RoutineSoftCopyUpload>(entity =>
            {
                entity.ToTable("RoutineSoftCopyUpload");

                entity.Property(e => e.CreatedBy).HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DocumentLink).HasMaxLength(250);

                entity.Property(e => e.DocumentName).HasMaxLength(450);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.BaseSchoolName)
                    .WithMany(p => p.RoutineSoftCopyUploads)
                    .HasForeignKey(d => d.BaseSchoolNameId)
                    .HasConstraintName("FK_RoutineSoftCopyUpload_BaseSchoolName");

                entity.HasOne(d => d.CourseDuration)
                    .WithMany(p => p.RoutineSoftCopyUploads)
                    .HasForeignKey(d => d.CourseDurationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RoutineSoftCopyUpload_CourseDuration");
            });

            modelBuilder.Entity<SaylorBranch>(entity =>
            {
                entity.ToTable("SaylorBranch");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(450);
            });

            modelBuilder.Entity<SaylorRank>(entity =>
            {
                entity.ToTable("SaylorRank");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(450);
            });

            modelBuilder.Entity<SaylorSubBranch>(entity =>
            {
                entity.ToTable("SaylorSubBranch");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(450);

                entity.HasOne(d => d.SaylorBranch)
                    .WithMany(p => p.SaylorSubBranches)
                    .HasForeignKey(d => d.SaylorBranchId)
                    .HasConstraintName("FK_SaylorSubBranch_SaylorBranch");
            });

            modelBuilder.Entity<SocialMediaType>(entity =>
            {
                entity.ToTable("SocialMediaType");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SocialMediaTypeName)
                    .IsRequired()
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<SocialMedium>(entity =>
            {
                entity.HasKey(e => e.SocialMediaId);

                entity.Property(e => e.AdditionalInformation).HasMaxLength(250);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SocialMediaAccountName).HasMaxLength(150);

                entity.HasOne(d => d.SocialMediaType)
                    .WithMany(p => p.SocialMedia)
                    .HasForeignKey(d => d.SocialMediaTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SocialMedia_SocialMediaType");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.SocialMedia)
                    .HasForeignKey(d => d.TraineeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SocialMedia_TraineeBioDataGeneralInfo");
            });

            modelBuilder.Entity<StepRelation>(entity =>
            {
                entity.ToTable("StepRelation");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StepRelationType).HasMaxLength(150);
            });

            modelBuilder.Entity<SubjectCategory>(entity =>
            {
                entity.ToTable("SubjectCategory");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SubjectCategoryName)
                    .IsRequired()
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<SubjectClassification>(entity =>
            {
                entity.ToTable("SubjectClassification");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SubjectClassificationName)
                    .IsRequired()
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<SubjectCurriculum>(entity =>
            {
                entity.ToTable("SubjectCurriculum");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.CurriculumName).HasMaxLength(250);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SubjectMark>(entity =>
            {
                entity.ToTable("SubjectMark");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(250);

                entity.HasOne(d => d.BaseSchoolName)
                    .WithMany(p => p.SubjectMarks)
                    .HasForeignKey(d => d.BaseSchoolNameId)
                    .HasConstraintName("FK_SubjectMark_BaseSchoolName");

                entity.HasOne(d => d.BnaSubjectName)
                    .WithMany(p => p.SubjectMarks)
                    .HasForeignKey(d => d.BnaSubjectNameId)
                    .HasConstraintName("FK_SubjectMark_BnaSubjectName");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.SubjectMarks)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_SubjectMark_Branch");

                entity.HasOne(d => d.CourseModule)
                    .WithMany(p => p.SubjectMarks)
                    .HasForeignKey(d => d.CourseModuleId)
                    .HasConstraintName("FK_SubjectMark_CourseModule");

                entity.HasOne(d => d.CourseName)
                    .WithMany(p => p.SubjectMarks)
                    .HasForeignKey(d => d.CourseNameId)
                    .HasConstraintName("FK_SubjectMark_CourseName");

                entity.HasOne(d => d.MarkType)
                    .WithMany(p => p.SubjectMarks)
                    .HasForeignKey(d => d.MarkTypeId)
                    .HasConstraintName("FK_SubjectMark_MarkType");

                entity.HasOne(d => d.SaylorBranch)
                    .WithMany(p => p.SubjectMarks)
                    .HasForeignKey(d => d.SaylorBranchId)
                    .HasConstraintName("FK_SubjectMark_SaylorBranch");

                entity.HasOne(d => d.SaylorSubBranch)
                    .WithMany(p => p.SubjectMarks)
                    .HasForeignKey(d => d.SaylorSubBranchId)
                    .HasConstraintName("FK_SubjectMark_SaylorSubBranch");
            });

            modelBuilder.Entity<SubjectType>(entity =>
            {
                entity.ToTable("SubjectType");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SubjectTypeName).HasMaxLength(450);
            });

            modelBuilder.Entity<SwimmingDriving>(entity =>
            {
                entity.ToTable("SwimmingDriving");

                entity.Property(e => e.AdditionalInformation)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.SwimmingDrivings)
                    .HasForeignKey(d => d.TraineeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SwimmingDriving_TraineeBioDataGeneralInfo");
            });

            modelBuilder.Entity<SwimmingDrivingLevel>(entity =>
            {
                entity.ToTable("SwimmingDrivingLevel");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.LevelType)
                    .WithMany(p => p.SwimmingDrivingLevels)
                    .HasForeignKey(d => d.LevelTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SwimmingDrivingLevel_CodeValue");

                entity.HasOne(d => d.SwimmingDriving)
                    .WithMany(p => p.SwimmingDrivingLevels)
                    .HasForeignKey(d => d.SwimmingDrivingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SwimmingDrivingLevel_SwimmingDriving");
            });

            modelBuilder.Entity<TdecActionStatus>(entity =>
            {
                entity.ToTable("TdecActionStatus");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(450);
            });

            modelBuilder.Entity<TdecGroupResult>(entity =>
            {
                entity.ToTable("TdecGroupResult");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.TdecActionStatus)
                    .WithMany(p => p.TdecGroupResults)
                    .HasForeignKey(d => d.TdecActionStatusId)
                    .HasConstraintName("FK_TdecGroupResult_TdecActionStatus");

                entity.HasOne(d => d.TdecQuationGroup)
                    .WithMany(p => p.TdecGroupResults)
                    .HasForeignKey(d => d.TdecQuationGroupId)
                    .HasConstraintName("FK_TdecGroupResult_TdecQuationGroup");

                entity.HasOne(d => d.TraineeNomination)
                    .WithMany(p => p.TdecGroupResults)
                    .HasForeignKey(d => d.TraineeNominationId)
                    .HasConstraintName("FK_TdecGroupResult_TraineeNomination");
            });

            modelBuilder.Entity<TdecQuationGroup>(entity =>
            {
                entity.ToTable("TdecQuationGroup");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.BaseSchoolName)
                    .WithMany(p => p.TdecQuationGroups)
                    .HasForeignKey(d => d.BaseSchoolNameId)
                    .HasConstraintName("FK_TdecQuationGroup_BaseSchoolName");

                entity.HasOne(d => d.BnaExamInstructorAssign)
                    .WithMany(p => p.TdecQuationGroups)
                    .HasForeignKey(d => d.BnaExamInstructorAssignId)
                    .HasConstraintName("FK_TdecQuationGroup_BnaExamInstructorAssign");

                entity.HasOne(d => d.BnaSubjectName)
                    .WithMany(p => p.TdecQuationGroups)
                    .HasForeignKey(d => d.BnaSubjectNameId)
                    .HasConstraintName("FK_TdecQuationGroup_BnaSubjectName");

                entity.HasOne(d => d.CourseDuration)
                    .WithMany(p => p.TdecQuationGroups)
                    .HasForeignKey(d => d.CourseDurationId)
                    .HasConstraintName("FK_TdecQuationGroup_CourseDuration");

                entity.HasOne(d => d.CourseName)
                    .WithMany(p => p.TdecQuationGroups)
                    .HasForeignKey(d => d.CourseNameId)
                    .HasConstraintName("FK_TdecQuationGroup_CourseName");

                entity.HasOne(d => d.TdecQuestionName)
                    .WithMany(p => p.TdecQuationGroups)
                    .HasForeignKey(d => d.TdecQuestionNameId)
                    .HasConstraintName("FK_TdecQuationGroup_TdecQuestionName1");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.TdecQuationGroups)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_TdecQuationGroup_TraineeBioDataGeneralInfo");
            });

            modelBuilder.Entity<TdecQuestionName>(entity =>
            {
                entity.ToTable("TdecQuestionName");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(450);
            });

            modelBuilder.Entity<Thana>(entity =>
            {
                entity.ToTable("Thana");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ThanaName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.District)
                    .WithMany(p => p.Thanas)
                    .HasForeignKey(d => d.DistrictId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Thana_District");
            });

            modelBuilder.Entity<TraineeAssessmentCreate>(entity =>
            {
                entity.ToTable("TraineeAssessmentCreate");

                entity.Property(e => e.AssessmentName).HasMaxLength(450);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(450);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.BaseSchoolName)
                    .WithMany(p => p.TraineeAssessmentCreates)
                    .HasForeignKey(d => d.BaseSchoolNameId)
                    .HasConstraintName("FK_TraineeAssessmentCreate_BaseSchoolName");

                entity.HasOne(d => d.CourseDuration)
                    .WithMany(p => p.TraineeAssessmentCreates)
                    .HasForeignKey(d => d.CourseDurationId)
                    .HasConstraintName("FK_TraineeAssessmentCreate_CourseDuration");
            });

            modelBuilder.Entity<TraineeAssessmentMark>(entity =>
            {
                entity.ToTable("TraineeAssessmentMark");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Knowledge).HasMaxLength(50);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Leadeship).HasMaxLength(50);

                entity.Property(e => e.Position).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(450);

                entity.Property(e => e.StaffDuty).HasMaxLength(50);

                entity.HasOne(d => d.BaseSchoolName)
                    .WithMany(p => p.TraineeAssessmentMarks)
                    .HasForeignKey(d => d.BaseSchoolNameId)
                    .HasConstraintName("FK_TraineeAssessmentMark_BaseSchoolName");

                entity.HasOne(d => d.CourseDuration)
                    .WithMany(p => p.TraineeAssessmentMarks)
                    .HasForeignKey(d => d.CourseDurationId)
                    .HasConstraintName("FK_TraineeAssessmentMark_CourseDuration");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.TraineeAssessmentMarks)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_TraineeAssessmentMark_TraineeBioDataGeneralInfo");

                entity.HasOne(d => d.TraineeNomination)
                    .WithMany(p => p.TraineeAssessmentMarks)
                    .HasForeignKey(d => d.TraineeNominationId)
                    .HasConstraintName("FK_TraineeAssessmentMark_TraineeNomination");
            });

            modelBuilder.Entity<TraineeAssignmentSubmit>(entity =>
            {
                entity.ToTable("TraineeAssignmentSubmit");

                entity.Property(e => e.CreatedBy).HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.ImageUpload).HasMaxLength(450);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.BaseSchoolName)
                    .WithMany(p => p.TraineeAssignmentSubmits)
                    .HasForeignKey(d => d.BaseSchoolNameId)
                    .HasConstraintName("FK_TraineeAssignmentSubmit_BaseSchoolName");

                entity.HasOne(d => d.BnaSubjectName)
                    .WithMany(p => p.TraineeAssignmentSubmits)
                    .HasForeignKey(d => d.BnaSubjectNameId)
                    .HasConstraintName("FK_TraineeAssignmentSubmit_BnaSubjectName");

                entity.HasOne(d => d.CourseDuration)
                    .WithMany(p => p.TraineeAssignmentSubmits)
                    .HasForeignKey(d => d.CourseDurationId)
                    .HasConstraintName("FK_TraineeAssignmentSubmit_CourseDuration");

                entity.HasOne(d => d.CourseInstructor)
                    .WithMany(p => p.TraineeAssignmentSubmits)
                    .HasForeignKey(d => d.CourseInstructorId)
                    .HasConstraintName("FK_TraineeAssignmentSubmit_CourseInstructor");

                entity.HasOne(d => d.CourseName)
                    .WithMany(p => p.TraineeAssignmentSubmits)
                    .HasForeignKey(d => d.CourseNameId)
                    .HasConstraintName("FK_TraineeAssignmentSubmit_CourseName");

                entity.HasOne(d => d.InstructorAssignment)
                    .WithMany(p => p.TraineeAssignmentSubmits)
                    .HasForeignKey(d => d.InstructorAssignmentId)
                    .HasConstraintName("FK_TraineeAssignmentSubmit_InstructorAssignment");

                entity.HasOne(d => d.Instructor)
                    .WithMany(p => p.TraineeAssignmentSubmitInstructors)
                    .HasForeignKey(d => d.InstructorId)
                    .HasConstraintName("FK_TraineeAssignmentSubmit_TraineeBioDataGeneralInfo");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.TraineeAssignmentSubmitTrainees)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_TraineeAssignmentSubmit_TraineeBioDataGeneralInfo1");
            });

            modelBuilder.Entity<TraineeAssissmentGroup>(entity =>
            {
                entity.ToTable("TraineeAssissmentGroup");

                entity.Property(e => e.AssissmentGroupName).HasMaxLength(450);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(450);

                entity.HasOne(d => d.CourseDuration)
                    .WithMany(p => p.TraineeAssissmentGroups)
                    .HasForeignKey(d => d.CourseDurationId)
                    .HasConstraintName("FK_TraineeAssissmentGroup_CourseDuration");

                entity.HasOne(d => d.TraineeAssissmentCreate)
                    .WithMany(p => p.TraineeAssissmentGroups)
                    .HasForeignKey(d => d.TraineeAssissmentCreateId)
                    .HasConstraintName("FK_TraineeAssissmentGroup_TraineeAssessmentCreate");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.TraineeAssissmentGroups)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_TraineeAssissmentGroup_TraineeBioDataGeneralInfo");

                entity.HasOne(d => d.TraineeNomination)
                    .WithMany(p => p.TraineeAssissmentGroups)
                    .HasForeignKey(d => d.TraineeNominationId)
                    .HasConstraintName("FK_TraineeAssissmentGroup_TraineeNomination");
            });

            modelBuilder.Entity<TraineeBioDataGeneralInfo>(entity =>
            {
                entity.HasKey(e => e.TraineeId)
                    .HasName("PK_TraineeBIODataGeneralInfo");

                entity.ToTable("TraineeBioDataGeneralInfo");

                entity.Property(e => e.BankAccount).HasMaxLength(450);

                entity.Property(e => e.BnaNo).HasMaxLength(150);

                entity.Property(e => e.BnaPhotoUrl).HasMaxLength(450);

                entity.Property(e => e.ChestNo).HasMaxLength(150);

                entity.Property(e => e.CloseRelative).HasMaxLength(250);

                entity.Property(e => e.CountryVisited).HasMaxLength(550);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.Dislikeness).HasMaxLength(550);

                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.EmergencyCommunicatePerson).HasMaxLength(550);

                entity.Property(e => e.FamilyLocation).HasMaxLength(450);

                entity.Property(e => e.Hobbies).HasMaxLength(450);

                entity.Property(e => e.IdCardNo).HasMaxLength(150);

                entity.Property(e => e.IdentificationMark).HasMaxLength(150);

                entity.Property(e => e.JoiningDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Likeness).HasMaxLength(550);

                entity.Property(e => e.LocalNo).HasMaxLength(150);

                entity.Property(e => e.MarriedDate).HasColumnType("datetime");

                entity.Property(e => e.MedicalCategory).HasMaxLength(550);

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.NameBangla).HasMaxLength(250);

                entity.Property(e => e.NameofWife).HasMaxLength(450);

                entity.Property(e => e.NickName).HasMaxLength(250);

                entity.Property(e => e.Nid).HasMaxLength(50);

                entity.Property(e => e.Nominee).HasMaxLength(250);

                entity.Property(e => e.PantSize).HasMaxLength(50);

                entity.Property(e => e.PassportNo).HasMaxLength(150);

                entity.Property(e => e.PermanentAddress).HasMaxLength(500);

                entity.Property(e => e.Place).HasMaxLength(450);

                entity.Property(e => e.Pno).HasMaxLength(150);

                entity.Property(e => e.PresentAddress).HasMaxLength(500);

                entity.Property(e => e.PresentBillet).HasMaxLength(450);

                entity.Property(e => e.RelativeRelation).HasMaxLength(250);

                entity.Property(e => e.Remarks).HasMaxLength(250);

                entity.Property(e => e.Seniority).HasMaxLength(450);

                entity.Property(e => e.ShoeSize).HasMaxLength(50);

                entity.Property(e => e.ShortCode).HasMaxLength(150);

                entity.Property(e => e.Sports).HasMaxLength(450);

                entity.HasOne(d => d.BloodGroup)
                    .WithMany(p => p.TraineeBioDataGeneralInfos)
                    .HasForeignKey(d => d.BloodGroupId)
                    .HasConstraintName("FK_TraineeBioDataGeneralInfo_BloodGroup");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.TraineeBioDataGeneralInfos)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_TraineeBioDataGeneralInfo_Branch");

                entity.HasOne(d => d.Caste)
                    .WithMany(p => p.TraineeBioDataGeneralInfos)
                    .HasForeignKey(d => d.CasteId)
                    .HasConstraintName("FK_TraineeBioDataGeneralInfo_Caste");

                entity.HasOne(d => d.ColorOfEye)
                    .WithMany(p => p.TraineeBioDataGeneralInfos)
                    .HasForeignKey(d => d.ColorOfEyeId)
                    .HasConstraintName("FK_TraineeBioDataGeneralInfo_ColorOfEye");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.TraineeBioDataGeneralInfos)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_TraineeBioDataGeneralInfo_Country");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.TraineeBioDataGeneralInfos)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_TraineeBioDataGeneralInfo_District");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.TraineeBioDataGeneralInfos)
                    .HasForeignKey(d => d.DivisionId)
                    .HasConstraintName("FK_TraineeBioDataGeneralInfo_Division");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.TraineeBioDataGeneralInfos)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK_TraineeBioDataGeneralInfo_Gender");

                entity.HasOne(d => d.HairColor)
                    .WithMany(p => p.TraineeBioDataGeneralInfos)
                    .HasForeignKey(d => d.HairColorId)
                    .HasConstraintName("FK_TraineeBioDataGeneralInfo_HairColor");

                entity.HasOne(d => d.Height)
                    .WithMany(p => p.TraineeBioDataGeneralInfos)
                    .HasForeignKey(d => d.HeightId)
                    .HasConstraintName("FK_TraineeBioDataGeneralInfo_Height");

                entity.HasOne(d => d.MaritalStatus)
                    .WithMany(p => p.TraineeBioDataGeneralInfos)
                    .HasForeignKey(d => d.MaritalStatusId)
                    .HasConstraintName("FK_TraineeBioDataGeneralInfo_MaritalStatus");

                entity.HasOne(d => d.Nationality)
                    .WithMany(p => p.TraineeBioDataGeneralInfos)
                    .HasForeignKey(d => d.NationalityId)
                    .HasConstraintName("FK_TraineeBioDataGeneralInfo_Nationality");

                entity.HasOne(d => d.Rank)
                    .WithMany(p => p.TraineeBioDataGeneralInfos)
                    .HasForeignKey(d => d.RankId)
                    .HasConstraintName("FK_TraineeBioDataGeneralInfo_Rank");

                entity.HasOne(d => d.Religion)
                    .WithMany(p => p.TraineeBioDataGeneralInfos)
                    .HasForeignKey(d => d.ReligionId)
                    .HasConstraintName("FK_TraineeBioDataGeneralInfo_Religion");

                entity.HasOne(d => d.SaylorBranch)
                    .WithMany(p => p.TraineeBioDataGeneralInfos)
                    .HasForeignKey(d => d.SaylorBranchId)
                    .HasConstraintName("FK_TraineeBioDataGeneralInfo_SaylorBranch");

                entity.HasOne(d => d.SaylorRank)
                    .WithMany(p => p.TraineeBioDataGeneralInfos)
                    .HasForeignKey(d => d.SaylorRankId)
                    .HasConstraintName("FK_TraineeBioDataGeneralInfo_SaylorRank");

                entity.HasOne(d => d.SaylorSubBranch)
                    .WithMany(p => p.TraineeBioDataGeneralInfos)
                    .HasForeignKey(d => d.SaylorSubBranchId)
                    .HasConstraintName("FK_TraineeBioDataGeneralInfo_SaylorSubBranch");

                entity.HasOne(d => d.Thana)
                    .WithMany(p => p.TraineeBioDataGeneralInfos)
                    .HasForeignKey(d => d.ThanaId)
                    .HasConstraintName("FK_TraineeBioDataGeneralInfo_Thana");

                entity.HasOne(d => d.TraineeStatus)
                    .WithMany(p => p.TraineeBioDataGeneralInfos)
                    .HasForeignKey(d => d.TraineeStatusId)
                    .HasConstraintName("FK_TraineeBioDataGeneralInfo_TraineeStatus");

                entity.HasOne(d => d.Weight)
                    .WithMany(p => p.TraineeBioDataGeneralInfos)
                    .HasForeignKey(d => d.WeightId)
                    .HasConstraintName("FK_TraineeBioDataGeneralInfo_Weight");
            });

            modelBuilder.Entity<TraineeBioDataOther>(entity =>
            {
                entity.ToTable("TraineeBioDataOther");

                entity.Property(e => e.AdditionalInformation).HasMaxLength(150);

                entity.Property(e => e.Age).HasMaxLength(100);

                entity.Property(e => e.BankAccount).HasMaxLength(50);

                entity.Property(e => e.CommissionDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.CreditCard).HasMaxLength(150);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateOfMarriage).HasColumnType("datetime");

                entity.Property(e => e.DrivingLiccense).HasMaxLength(150);

                entity.Property(e => e.DualNationality)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdentificationMark).HasMaxLength(150);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MigrationDate).HasColumnType("datetime");

                entity.Property(e => e.PassportNo).HasMaxLength(150);

                entity.Property(e => e.PermanentAddress).HasMaxLength(500);

                entity.Property(e => e.PlaceOfBirth).HasMaxLength(150);

                entity.Property(e => e.PostCode).HasMaxLength(50);

                entity.Property(e => e.PresentAddress).HasMaxLength(500);

                entity.Property(e => e.ReasonOfMigration).HasMaxLength(150);

                entity.Property(e => e.RelegationDate).HasColumnType("datetime");

                entity.Property(e => e.RelegationDocument).HasMaxLength(150);

                entity.Property(e => e.RelegationRemarks).HasMaxLength(150);

                entity.Property(e => e.Remarks).HasMaxLength(250);

                entity.Property(e => e.ShortCode).HasMaxLength(150);

                entity.Property(e => e.SnationalityId).HasColumnName("SNationalityId");

                entity.HasOne(d => d.BaseSchoolName)
                    .WithMany(p => p.TraineeBioDataOthers)
                    .HasForeignKey(d => d.BaseSchoolNameId)
                    .HasConstraintName("FK_TraineeBioDataOther_BaseSchoolName");

                entity.HasOne(d => d.BloodGroup)
                    .WithMany(p => p.TraineeBioDataOthers)
                    .HasForeignKey(d => d.BloodGroupId)
                    .HasConstraintName("FK_TraineeBioDataOther_BloodGroup");

                entity.HasOne(d => d.BnaClassSectionSelection)
                    .WithMany(p => p.TraineeBioDataOthers)
                    .HasForeignKey(d => d.BnaClassSectionSelectionId)
                    .HasConstraintName("FK_TraineeBioDataOther_BnaClassSectionSelection");

                entity.HasOne(d => d.BnaCurriculumType)
                    .WithMany(p => p.TraineeBioDataOthers)
                    .HasForeignKey(d => d.BnaCurriculumTypeId)
                    .HasConstraintName("FK_TraineeBioDataOther_BnaCurriculumType");

                entity.HasOne(d => d.BnaInstructorType)
                    .WithMany(p => p.TraineeBioDataOthers)
                    .HasForeignKey(d => d.BnaInstructorTypeId)
                    .HasConstraintName("FK_TraineeBioDataOther_BnaInstructorType");

                entity.HasOne(d => d.BnaPromotionStatus)
                    .WithMany(p => p.TraineeBioDataOthers)
                    .HasForeignKey(d => d.BnaPromotionStatusId)
                    .HasConstraintName("FK_TraineeBioDataOther_BnaPromotionStatus");

                entity.HasOne(d => d.BnaSemester)
                    .WithMany(p => p.TraineeBioDataOthers)
                    .HasForeignKey(d => d.BnaSemesterId)
                    .HasConstraintName("FK_TraineeBioDataOther_BnaSemester");

                entity.HasOne(d => d.BnaServiceType)
                    .WithMany(p => p.TraineeBioDataOthers)
                    .HasForeignKey(d => d.BnaServiceTypeId)
                    .HasConstraintName("FK_TraineeBioDataOther_BnaServiceType");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.TraineeBioDataOthers)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_TraineeBioDataOther_Branch");

                entity.HasOne(d => d.Caste)
                    .WithMany(p => p.TraineeBioDataOthers)
                    .HasForeignKey(d => d.CasteId)
                    .HasConstraintName("FK_TraineeBioDataOther_Caste");

                entity.HasOne(d => d.ColorOfEye)
                    .WithMany(p => p.TraineeBioDataOthers)
                    .HasForeignKey(d => d.ColorOfEyeId)
                    .HasConstraintName("FK_TraineeBioDataOther_ColorOfEye");

                entity.HasOne(d => d.Complexion)
                    .WithMany(p => p.TraineeBioDataOthers)
                    .HasForeignKey(d => d.ComplexionId)
                    .HasConstraintName("FK_TraineeBioDataOther_Complexion");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.TraineeBioDataOthers)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_TraineeBioDataOther_Country");

                entity.HasOne(d => d.CourseName)
                    .WithMany(p => p.TraineeBioDataOthers)
                    .HasForeignKey(d => d.CourseNameId)
                    .HasConstraintName("FK_TraineeBioDataOther_CourseName");

                entity.HasOne(d => d.FailureStatus)
                    .WithMany(p => p.TraineeBioDataOthers)
                    .HasForeignKey(d => d.FailureStatusId)
                    .HasConstraintName("FK_TraineeBioDataOther_FailureStatus");

                entity.HasOne(d => d.Height)
                    .WithMany(p => p.TraineeBioDataOthers)
                    .HasForeignKey(d => d.HeightId)
                    .HasConstraintName("FK_TraineeBioDataOther_Height");

                entity.HasOne(d => d.MaritalStatus)
                    .WithMany(p => p.TraineeBioDataOthers)
                    .HasForeignKey(d => d.MaritalStatusId)
                    .HasConstraintName("FK_TraineeBioDataOther_MaritalStatus");

                entity.HasOne(d => d.PresentBillet)
                    .WithMany(p => p.TraineeBioDataOthers)
                    .HasForeignKey(d => d.PresentBilletId)
                    .HasConstraintName("FK_TraineeBioDataOther_PresentBillet");

                entity.HasOne(d => d.Religion)
                    .WithMany(p => p.TraineeBioDataOthers)
                    .HasForeignKey(d => d.ReligionId)
                    .HasConstraintName("FK_TraineeBioDataOther_Religion");

                entity.HasOne(d => d.Snationality)
                    .WithMany(p => p.TraineeBioDataOthers)
                    .HasForeignKey(d => d.SnationalityId)
                    .HasConstraintName("FK_TraineeBioDataOther_Nationality");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.TraineeBioDataOthers)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_TraineeBioDataOther_TraineeBioDataGeneralInfo");

                entity.HasOne(d => d.UtofficerCategory)
                    .WithMany(p => p.TraineeBioDataOthers)
                    .HasForeignKey(d => d.UtofficerCategoryId)
                    .HasConstraintName("FK_TraineeBioDataOther_UtofficerCategory");

                entity.HasOne(d => d.UtofficerType)
                    .WithMany(p => p.TraineeBioDataOthers)
                    .HasForeignKey(d => d.UtofficerTypeId)
                    .HasConstraintName("FK_TraineeBioDataOther_UtofficerType");

                entity.HasOne(d => d.Weight)
                    .WithMany(p => p.TraineeBioDataOthers)
                    .HasForeignKey(d => d.WeightId)
                    .HasConstraintName("FK_TraineeBioDataOther_Weight");
            });

            modelBuilder.Entity<TraineeCourseStatus>(entity =>
            {
                entity.ToTable("TraineeCourseStatus");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TraineeCourseStatusName).HasMaxLength(250);
            });

            modelBuilder.Entity<TraineeLanguage>(entity =>
            {
                entity.ToTable("TraineeLanguage");

                entity.Property(e => e.AdditionalInformation).HasMaxLength(150);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Reading).HasMaxLength(150);

                entity.Property(e => e.Speaking).HasMaxLength(150);

                entity.Property(e => e.Writing).HasMaxLength(150);

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.TraineeLanguages)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TraineeLanguage_Language");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.TraineeLanguages)
                    .HasForeignKey(d => d.TraineeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TraineeLanguage_TraineeBioDataGeneralInfo");
            });

            modelBuilder.Entity<TraineeMembership>(entity =>
            {
                entity.ToTable("TraineeMembership");

                entity.Property(e => e.AdditionalInformation).HasMaxLength(450);

                entity.Property(e => e.Appointment)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.BriefAddress)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DurationFrom).HasColumnType("datetime");

                entity.Property(e => e.DurationTo).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrgName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.HasOne(d => d.MembershipType)
                    .WithMany(p => p.TraineeMemberships)
                    .HasForeignKey(d => d.MembershipTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TraineeMembership_MembershipType");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.TraineeMemberships)
                    .HasForeignKey(d => d.TraineeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TraineeMembership_TraineeBioDataGeneralInfo");
            });

            modelBuilder.Entity<TraineeNomination>(entity =>
            {
                entity.ToTable("TraineeNomination");

                entity.Property(e => e.CertificateSerialNo).HasMaxLength(20);

                entity.Property(e => e.CourseAttendStateRemark).HasMaxLength(450);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.FamilyAllowId)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.IndexNo).HasMaxLength(250);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PresentBillet).HasMaxLength(450);

                entity.Property(e => e.WithdrawnDate).HasColumnType("datetime");

                entity.Property(e => e.WithdrawnDocs).HasMaxLength(450);

                entity.Property(e => e.WithdrawnRemarks).HasMaxLength(250);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.TraineeNominations)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_TraineeNomination_Branch");

                entity.HasOne(d => d.CourseDuration)
                    .WithMany(p => p.TraineeNominations)
                    .HasForeignKey(d => d.CourseDurationId)
                    .HasConstraintName("FK_TraineeNomination_CourseDuration");

                entity.HasOne(d => d.CourseName)
                    .WithMany(p => p.TraineeNominations)
                    .HasForeignKey(d => d.CourseNameId)
                    .HasConstraintName("FK_TraineeNomination_CourseName");

                entity.HasOne(d => d.ExamAttemptType)
                    .WithMany(p => p.TraineeNominations)
                    .HasForeignKey(d => d.ExamAttemptTypeId)
                    .HasConstraintName("FK_TraineeNomination_ExamAttemptType");

                entity.HasOne(d => d.ExamCenter)
                    .WithMany(p => p.TraineeNominations)
                    .HasForeignKey(d => d.ExamCenterId)
                    .HasConstraintName("FK_TraineeNomination_ExamCenter");

                entity.HasOne(d => d.ExamType)
                    .WithMany(p => p.TraineeNominations)
                    .HasForeignKey(d => d.ExamTypeId)
                    .HasConstraintName("FK_TraineeNomination_ExamType");

                entity.HasOne(d => d.NewAtempt)
                    .WithMany(p => p.TraineeNominations)
                    .HasForeignKey(d => d.NewAtemptId)
                    .HasConstraintName("FK_TraineeNomination_NewAtempt");

                entity.HasOne(d => d.Rank)
                    .WithMany(p => p.TraineeNominations)
                    .HasForeignKey(d => d.RankId)
                    .HasConstraintName("FK_TraineeNomination_Rank");

                entity.HasOne(d => d.SaylorBranch)
                    .WithMany(p => p.TraineeNominations)
                    .HasForeignKey(d => d.SaylorBranchId)
                    .HasConstraintName("FK_TraineeNomination_SaylorBranch");

                entity.HasOne(d => d.SaylorRank)
                    .WithMany(p => p.TraineeNominations)
                    .HasForeignKey(d => d.SaylorRankId)
                    .HasConstraintName("FK_TraineeNomination_SaylorRank");

                entity.HasOne(d => d.SaylorSubBranch)
                    .WithMany(p => p.TraineeNominations)
                    .HasForeignKey(d => d.SaylorSubBranchId)
                    .HasConstraintName("FK_TraineeNomination_SaylorSubBranch");

                entity.HasOne(d => d.TraineeCourseStatus)
                    .WithMany(p => p.TraineeNominations)
                    .HasForeignKey(d => d.TraineeCourseStatusId)
                    .HasConstraintName("FK_TraineeNomination_TraineeCourseStatus");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.TraineeNominations)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_TraineeNomination_TraineeBioDataGeneralInfo");

                entity.HasOne(d => d.WithdrawnDoc)
                    .WithMany(p => p.TraineeNominations)
                    .HasForeignKey(d => d.WithdrawnDocId)
                    .HasConstraintName("FK_TraineeNomination_WithdrawnDoc");
            });

            modelBuilder.Entity<TraineePicture>(entity =>
            {
                entity.ToTable("TraineePicture");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.ImageLink).HasMaxLength(450);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.BnaSemesterDuration)
                    .WithMany(p => p.TraineePictures)
                    .HasForeignKey(d => d.BnaSemesterDurationId)
                    .HasConstraintName("FK_TraineePicture_BnaSemesterDuration");

                entity.HasOne(d => d.BnaSemester)
                    .WithMany(p => p.TraineePictures)
                    .HasForeignKey(d => d.BnaSemesterId)
                    .HasConstraintName("FK_TraineePicture_BnaSemester");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.TraineePictures)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_TraineePicture_TraineeBioDataGeneralInfo");
            });

            modelBuilder.Entity<TraineeSectionSelection>(entity =>
            {
                entity.ToTable("TraineeSectionSelection");

                entity.Property(e => e.ApprovedBy).HasMaxLength(150);

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.BnaClassSectionSelection)
                    .WithMany(p => p.TraineeSectionSelectionBnaClassSectionSelections)
                    .HasForeignKey(d => d.BnaClassSectionSelectionId)
                    .HasConstraintName("FK_TraineeSectionSelection_BnaClassSectionSelection");

                entity.HasOne(d => d.BnaSemester)
                    .WithMany(p => p.TraineeSectionSelections)
                    .HasForeignKey(d => d.BnaSemesterId)
                    .HasConstraintName("FK_TraineeSectionSelection_BnaSemester");

                entity.HasOne(d => d.PreviewsSection)
                    .WithMany(p => p.TraineeSectionSelectionPreviewsSections)
                    .HasForeignKey(d => d.PreviewsSectionId)
                    .HasConstraintName("FK_TraineeSectionSelection_PreviousSection");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.TraineeSectionSelections)
                    .HasForeignKey(d => d.TraineeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TraineeSectionSelection_TraineeBioDataGeneralInfo");
            });

            modelBuilder.Entity<TraineeStatus>(entity =>
            {
                entity.ToTable("TraineeStatus");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.Remarks).HasMaxLength(250);
            });

            modelBuilder.Entity<TraineeVisitedAboard>(entity =>
            {
                entity.ToTable("TraineeVisitedAboard");

                entity.Property(e => e.AdditionalInformation).HasMaxLength(350);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DurationFrom).HasColumnType("datetime");

                entity.Property(e => e.DurationTo).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PurposeOfVisit)
                    .IsRequired()
                    .HasMaxLength(350);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.TraineeVisitedAboards)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TraineeVisitedAboard_Country");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.TraineeVisitedAboards)
                    .HasForeignKey(d => d.TraineeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TraineeVisitedAboard_TraineeBioDataGeneralInfo");
            });

            modelBuilder.Entity<TrainingObjective>(entity =>
            {
                entity.ToTable("TrainingObjective");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(450);

                entity.HasOne(d => d.BaseSchoolName)
                    .WithMany(p => p.TrainingObjectives)
                    .HasForeignKey(d => d.BaseSchoolNameId)
                    .HasConstraintName("FK_TrainingObjective_BaseSchoolName");

                entity.HasOne(d => d.BnaSubjectName)
                    .WithMany(p => p.TrainingObjectives)
                    .HasForeignKey(d => d.BnaSubjectNameId)
                    .HasConstraintName("FK_TrainingObjective_BnaSubjectName");

                entity.HasOne(d => d.CourseDuration)
                    .WithMany(p => p.TrainingObjectives)
                    .HasForeignKey(d => d.CourseDurationId)
                    .HasConstraintName("FK_TrainingObjective_CourseDuration");

                entity.HasOne(d => d.CourseName)
                    .WithMany(p => p.TrainingObjectives)
                    .HasForeignKey(d => d.CourseNameId)
                    .HasConstraintName("FK_TrainingObjective_CourseName");

                entity.HasOne(d => d.CourseTask)
                    .WithMany(p => p.TrainingObjectives)
                    .HasForeignKey(d => d.CourseTaskId)
                    .HasConstraintName("FK_TrainingObjective_CourseTask");
            });

            modelBuilder.Entity<TrainingSyllabus>(entity =>
            {
                entity.ToTable("TrainingSyllabus");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(450);

                entity.HasOne(d => d.BaseSchoolName)
                    .WithMany(p => p.TrainingSyllabi)
                    .HasForeignKey(d => d.BaseSchoolNameId)
                    .HasConstraintName("FK_TrainingSyllabus_BaseSchoolName");

                entity.HasOne(d => d.BnaSubjectName)
                    .WithMany(p => p.TrainingSyllabi)
                    .HasForeignKey(d => d.BnaSubjectNameId)
                    .HasConstraintName("FK_TrainingSyllabus_BnaSubjectName");

                entity.HasOne(d => d.CourseDuration)
                    .WithMany(p => p.TrainingSyllabi)
                    .HasForeignKey(d => d.CourseDurationId)
                    .HasConstraintName("FK_TrainingSyllabus_CourseDuration");

                entity.HasOne(d => d.CourseName)
                    .WithMany(p => p.TrainingSyllabi)
                    .HasForeignKey(d => d.CourseNameId)
                    .HasConstraintName("FK_TrainingSyllabus_CourseName");

                entity.HasOne(d => d.CourseTask)
                    .WithMany(p => p.TrainingSyllabi)
                    .HasForeignKey(d => d.CourseTaskId)
                    .HasConstraintName("FK_TrainingSyllabus_CourseTask");

                entity.HasOne(d => d.TrainingObjective)
                    .WithMany(p => p.TrainingSyllabi)
                    .HasForeignKey(d => d.TrainingObjectiveId)
                    .HasConstraintName("FK_TrainingSyllabus_TrainingObjective");
            });

            modelBuilder.Entity<UserManual>(entity =>
            {
                entity.ToTable("UserManual");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Doc).HasMaxLength(1000);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RoleName).HasMaxLength(450);
            });

            modelBuilder.Entity<UtofficerCategory>(entity =>
            {
                entity.ToTable("UtofficerCategory");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.UtofficerCategoryName)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<UtofficerType>(entity =>
            {
                entity.ToTable("UtofficerType");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.UtofficerTypeName)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<WeekName>(entity =>
            {
                entity.ToTable("WeekName");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(450);

                entity.Property(e => e.Remarks).HasMaxLength(450);
            });

            modelBuilder.Entity<Weight>(entity =>
            {
                entity.ToTable("Weight");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.WeightName)
                    .IsRequired()
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<WithdrawnDoc>(entity =>
            {
                entity.ToTable("WithdrawnDoc");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.WithdrawnDocName).HasMaxLength(450);
            });

            modelBuilder.Entity<WithdrawnType>(entity =>
            {
                entity.ToTable("WithdrawnType");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(450);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(450);

                entity.Property(e => e.ShortName).HasMaxLength(450);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
