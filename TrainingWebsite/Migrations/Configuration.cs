namespace TrainingWebsite.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TrainingWebsite.Models.TrainingWebsiteContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TrainingWebsite.Models.TrainingWebsiteContext context)
        {
            context.Schedules.AddOrUpdate(new Schedule[] {
                new Schedule() { SyllabusId = 1, Week = 1, Topic = "C# 101: History of C#", Description = "A brief history of the C# programming language and its purpose."},
                new Schedule() { SyllabusId = 2, Week = 2, Topic = "C# 101: Variables & Data Types", Description = "Declaring variables and the value types that are stored. (Integers, strings, booleans, etc.)"},
                new Schedule() { SyllabusId = 3, Week = 3, Topic = "C# 101: Loops", Description = "Discuss the various loops. (For, While, Do-While, For-Each)"},
                new Schedule() { SyllabusId = 4, Week = 4, Topic = "C# 101: Classes & Objects", Description = "Declaring classes and instantiating objects."},
                new Schedule() { SyllabusId = 5, Week = 5, Topic = "C# 101: Methods/Functions", Description = "Using methods."},
        });
        }
    }
}
