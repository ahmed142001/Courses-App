﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CourseApp1.data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class courses_dbEntities : DbContext
    {
        public courses_dbEntities()
            : base("name=courses_dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Course_lessons> Course_lessons { get; set; }
        public virtual DbSet<Cours> Courses { get; set; }
        public virtual DbSet<Trainee> Trainees { get; set; }
        public virtual DbSet<Trainee_Courses> Trainee_Courses { get; set; }
        public virtual DbSet<Trainer> Trainers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Roadmap_courses> Roadmap_courses { get; set; }
        public virtual DbSet<Roadmap> Roadmaps { get; set; }
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<RoomQuestion> RoomQuestions { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoadmapLink> RoadmapLinks { get; set; }
        public virtual DbSet<Favourite> Favourites { get; set; }
        public virtual DbSet<Book> Books { get; set; }
    }
}
