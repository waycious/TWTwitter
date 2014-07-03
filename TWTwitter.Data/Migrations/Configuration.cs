namespace TWTwitter.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TWTwitter.Data.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TWTwitter.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TWTwitter.Data.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Users.AddOrUpdate(
                u => u.Id,
                new User { Id = "waycious", password = "asdf" },
                new User { Id = "deanwood", password = "asdf" },
                new User { Id = "dickiez", password = "asdf" },
                new User { Id = "thefonz", password = "asdf" },
                new User { Id = "gershwin", password = "asdf" }
            );
            context.SaveChanges();
            context.Tweets.AddOrUpdate(
                t => t.Text,
                new Tweet { Text = "Phasellus aliquet, urna sit amet eleifend ullamcorper, mi sapien adipiscing urna, eu gravida velit justo sollicitudin nulla. Mauris posuere arcu elit, at ultricies lectus eleifend sodales.", UserId = "waycious", TargetId = "deanwood" },
                new Tweet { Text = "Sed tempus pharetra dictum. Nam eget enim eros. Proin convallis dignissim felis, id dictum erat elementum rutrum. Mauris volutpat orci quis enim pulvinar condimentum.", UserId = "waycious", TargetId = "dickiez" },
                new Tweet { Text = "Nam et ligula ut sem feugiat accumsan. Praesent accumsan sagittis ligula, id dictum libero consequat id. Donec elementum, urna scelerisque ornare ultricies", UserId = "waycious", TargetId = "thefonz" },
                new Tweet { Text = "Morbi tellus magna, condimentum sed lacinia pellentesque, vehicula ut tellus. Duis at mauris eu risus feugiat ullamcorper quis vitae quam. Pellentesque ac dignissim sapien, at congue diam.", UserId = "waycious", TargetId = "gershwin" },
                new Tweet { Text = "Proin laoreet lacus ac rutrum rhoncus. Aliquam consectetur posuere nisi. Praesent eget accumsan leo. Sed vitae lectus eu tellus rutrum molestie. Maecenas convallis molestie massa quis rhoncus.", UserId = "deanwood", TargetId = "waycious" },
                new Tweet { Text = "Praesent porta leo at mauris feugiat, quis commodo massa eleifend. Ut in urna mollis, pulvinar mauris nec, rhoncus mauris. Suspendisse vulputate condimentum pulvinar.", UserId = "deanwood", TargetId = "dickiez" },
                new Tweet { Text = "Fusce commodo imperdiet dui sit amet tempus. Donec pulvinar orci leo, et molestie velit placerat tempus. Mauris vitae semper velit, eget eleifend diam.", UserId = "deanwood", TargetId = "thefonz" },
                new Tweet { Text = "Phasellus ut urna a dolor sodales suscipit. Etiam ligula urna, dapibus sed dignissim vel, rutrum in est. Proin ultrices nunc nec purus ultricies dapibus. Nulla facilisi. Nullam scelerisque lacinia placerat.", UserId = "deanwood", TargetId = "gershwin" },
                new Tweet { Text = "Aenean nec quam bibendum, viverra lacus sit amet, consectetur purus. Morbi at nisi a odio tempus iaculis. Donec luctus lacinia lacus, non dignissim nibh molestie non.", UserId = "dickiez", TargetId = "waycious" },
                new Tweet { Text = "Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Cras pretium at leo sit amet commodo. Donec congue accumsan sapien, sit amet scelerisque dui porttitor vel.", UserId = "dickiez", TargetId = "deanwood" },
                new Tweet { Text = "In quis rhoncus velit, malesuada tristique ante. Vestibulum eleifend ipsum sapien, quis bibendum tortor adipiscing vitae. Fusce iaculis sit amet ante id dignissim. In varius tincidunt ligula sed convallis.", UserId = "dickiez", TargetId = "thefonz" },
                new Tweet { Text = "Aliquam sagittis felis quis enim tincidunt euismod. Integer eleifend, ante ac sodales facilisis, mauris est faucibus orci, id cursus quam nibh sed lorem.", UserId = "dickiez", TargetId = "gershwin" },
                new Tweet { Text = "Integer feugiat arcu vitae lobortis feugiat. Aliquam non mi nec neque rutrum imperdiet. Etiam in massa magna. Fusce mollis scelerisque semper. Sed consectetur vel lorem eu auctor.", UserId = "thefonz", TargetId = "waycious" },
                new Tweet { Text = "Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Cras pretium at leo sit amet commodo. Donec congue accumsan sapien, sit amet scelerisque dui porttitor vel.", UserId = "thefonz", TargetId = "deanwood" },
                new Tweet { Text = "In quis rhoncus velit, malesuada tristique ante. Vestibulum eleifend ipsum sapien, quis bibendum tortor adipiscing vitae. Fusce iaculis sit amet ante id dignissim. In varius tincidunt ligula sed convallis.", UserId = "thefonz", TargetId = "dickiez" },
                new Tweet { Text = "Aliquam sagittis felis quis enim tincidunt euismod. Integer eleifend, ante ac sodales facilisis, mauris est faucibus orci, id cursus quam nibh sed lorem. Integer feugiat arcu vitae lobortis feugiat.", UserId = "thefonz", TargetId = "gershwin" },
                new Tweet { Text = "Aliquam non mi nec neque rutrum imperdiet. Etiam in massa magna. Fusce mollis scelerisque semper. Sed consectetur vel lorem eu auctor. In sagittis cursus ultricies. Nulla nec blandit leo, sit amet lacinia mi.", UserId = "gershwin", TargetId = "waycious" },
                new Tweet { Text = "Curabitur lectus arcu, venenatis in cursus eu, pharetra non lorem. Nullam venenatis fermentum purus, eget convallis ipsum congue eu. Maecenas sed sapien quis metus hendrerit molestie rhoncus nec nulla.", UserId = "gershwin", TargetId = "deanwood" },
                new Tweet { Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent ornare, elit tempor vehicula gravida, metus velit aliquet enim, a imperdiet urna turpis at ipsum. Cras facilisis arcu sit amet arcu vestibulum semper.", UserId = "gershwin", TargetId = "dickiez" },
                new Tweet { Text = "Integer urna dui, posuere non bibendum vel, mollis et turpis. Sed et orci enim. In risus lacus, auctor eu erat non, ullamcorper suscipit lacus. Nulla a sapien risus. Aenean cursus odio non consequat tempor. Nunc porta tincidunt metus nec adipiscing.", UserId = "gershwin", TargetId = "thefonz" }
            );
            context.SaveChanges();
            context.Messages.AddOrUpdate(
                m => m.Text,
                new Message { UserId = "deanwood", TargetId = "waycious", Subject = "Class aptent taciti sociosqu", Text = "Integer convallis bibendum rhoncus. Aliquam hendrerit aliquam sapien. Aenean non tellus urna. Duis placerat iaculis sem, ac egestas leo commodo in. Nulla tempus, quam congue elementum aliquet, arcu odio eleifend orci, in accumsan justo risus ac sapien. Donec congue nisl felis, sed " },
                new Message { UserId = "thefonz", TargetId = "waycious", Subject = "In quis rhoncus velit, males", Text = "ullamcorper est feugiat sit amet. Praesent quis metus ac lorem dictum semper sed a nunc. Aenean nec venenatis tellus. Cras tincidunt sit amet nulla a imperdiet. In nec ante blandit, rutrum diam ac, rhoncus nulla. Pellentesque ultrices, velit ac consequat sodales, sem erat iaculis diam, eu euismod " },
                new Message { UserId = "gershwin", TargetId = "waycious", Subject = "Aliquam sagittis felis quis ", Text = "Integer quis risus non neque aliquam semper at sed nisl. Nullam congue, leo eget mollis suscipit, elit ipsum mattis magna, sed varius sapien nulla ut urna. Vivamus non nisl ante. Praesent iaculis euismod sagittis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia " }
            );
            context.SaveChanges();
            context.UserFollows.AddOrUpdate(
                u => u.Id,
                new UserFollow { Id = 1, UserId = "waycious", FollowedUserId = "deanwood"},
                new UserFollow { Id = 2, UserId = "waycious", FollowedUserId = "dickiez"},
                new UserFollow { Id = 3, UserId = "waycious", FollowedUserId = "thefonz"},
                new UserFollow { Id = 4, UserId = "waycious", FollowedUserId = "gershwin"},
                new UserFollow { Id = 5, UserId = "deanwood", FollowedUserId = "waycious" },
                new UserFollow { Id = 6, UserId = "dickiez", FollowedUserId = "waycious" },
                new UserFollow { Id = 7, UserId = "thefonz", FollowedUserId = "waycious" },
                new UserFollow { Id = 8, UserId = "gershwin", FollowedUserId = "waycious" }
            );
            context.SaveChanges();
        }
    }
}
