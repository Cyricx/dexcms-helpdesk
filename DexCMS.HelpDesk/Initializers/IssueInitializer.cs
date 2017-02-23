using DexCMS.Core.Extensions;
using DexCMS.Core.Globals;
using DexCMS.HelpDesk.Contexts;
using DexCMS.HelpDesk.Initializers.Helpers;
using DexCMS.HelpDesk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DexCMS.HelpDesk.Initializers
{
    class IssueInitializer : DexCMSInitializer<IDexCMSHelpDeskContext>
    {
        private IssueModulesReference Modules;
        private IssuePrioritiesReference Priorities;
        private IssueCustomersReference Customers;
        private HelpDeskUsersReference Users;
        private IssueTypesReference Types;
        private IssueStatusesReference Statuses;
        private IssueEffortsReference Efforts;

        public IssueInitializer(IDexCMSHelpDeskContext context) : base(context)
        {
        }

        public override void Run(bool addDemoContent = true)
        {
            if (addDemoContent)
            {
                Context.Issues.AddIfNotExists(x => x.Title,
                    new Issue
                    {
                        Title = "How do I abc?",
                        IssuePriorityID = Priorities.Medium,
                        IssueCustomerID = Customers.TestCustomer,
                        Created = DateTime.Now.AddDays(-7),
                        CreatedByID = Users.HelpDeskCustomer.Id,
                        Details = "<p>Spice girls rad move it football head gak natalie imbruglia, yo quiero taco bell accent braids moby razor scooter. Mad props leopard print scrunchies scrunched socks desert storm, seinfeld david duchovny boy meets world dolly the sheep chandler bing trucks. Instant messaging gotta have my pops toni braxton pulp fiction pop punk, flip flops scrolling text dallas cowboys the macarena nickelodeon. Visor toyota previa michael jordan dream team sugar ray trainers.</p>",
                        IssueTypeID = Types.Question,
                        IssueStatusID = Statuses.Entered
                    },
                    new Issue
                    {
                        Title = "XYZ is broken!",
                        IssuePriorityID = Priorities.Urgent,
                        OtherModule = "I think this is Mod.Xyz.No.Idea",
                        IssueCustomerID = Customers.TestCustomer,
                        Created = DateTime.Now.AddHours(-1),
                        CreatedByID = Users.HelpDeskCustomer.Id,
                        Details = "<p>Destiny’s child keepin’ it real sitcoms topanga, frasier acid wash world wide web sega genesis end of the road dennis rodman. Velcro sneakers snoop dogg boo-ya y2k discovery zone garth brooks, instant messaging meg ryan gatorade cheetos ford bronco snapple. My heart will go on flat tops trl the simpsons vertically striped shirts piercings. Toni braxton atlanta braves yo-yos scrolling text.</p>",
                        IssueTypeID = Types.Bug,
                        IssueStatusID = Statuses.GatheringRequirements,
                        IssueEffortID = Efforts.High
                    },
                    new Issue
                    {
                        Title = "I would love if X could do Y",
                        IssuePriorityID = Priorities.High,
                        IssueModules = new List<IssueModule> { Modules.Blogs },
                        IssueCustomerID = Customers.TestCustomer,
                        Created = DateTime.Now.AddDays(-3),
                        CreatedByID = Users.HelpDeskCustomer.Id,
                        Details = "<p>Yo quiero taco bell super soaker nylon windbreaker bike caps grunge. Chandler bing roseanne smashing pumpkins toy story backstreet boys oversized sweaters. The rachel haircut the simpsons pizza bagels hip hop, tamagotchi internet keepin’ it real natalie imbruglia yin yang. Wayne’s world arsenio hall berry lips babyface full house flat tops, hotmail skate tees your mom turquoise alternative rock jurassic park.</p>",
                        IssueTypeID = Types.Enhancement,
                        IssueStatusID = Statuses.ReadyToSchedule,
                        IssueEffortID = Efforts.Low
                    },
                    new Issue
                    {
                        Title = "Can you make something that will Z?",
                        IssuePriorityID = Priorities.Low,
                        OtherModule = "DexCMS.AmazingUpcomingModule",
                        IssueCustomerID = Customers.TestCustomer,
                        Created = DateTime.Now.AddDays(-14),
                        CreatedByID = Users.HelpDeskCustomer.Id,
                        Details = "<p>Visor cargo pants crimped hair discman. Mario lemieux west wing dennis rodman jagged little pill bleached hair, independence day trippin’ nirvana ghost pottery scene denim jackets slacker. Nintendo 64 vertically striped shirts jonathan taylor thomas kurt cobain, new jack city fresh prince of bel-air natalie imbruglia boy meets world. Tlc parting your hair down the middle dsl christina aguilera airwalk.</p>",
                        IssueTypeID = Types.NewFeature,
                        IssueStatusID = Statuses.Scheduled,
                        ReleaseDate = DateTime.Now.AddDays(14),
                        IssueEffortID = Efforts.Medium
                    },
                    new Issue
                    {
                        Title = "We should build X",
                        IssuePriorityID = Priorities.Low,
                        IssueModules = new List<IssueModule> { Modules.Tickets },
                        Created = DateTime.Now.AddDays(-5),
                        CreatedByID = Users.HelpDeskDeveloper.Id,
                        Details = "<p>Hottie discovery zone tlc cassette tape. Green day saved by the bell george michael fly crimped hair, zebra stripes your mom toyota supra ghost pottery scene marky mark. Discman baby got back piercings yo. Digital pets courtney love vhs tapes nerf guns, chat rooms david duchovny smarter child honda accord g-shocks.</p>",
                        IssueTypeID = Types.NewFeature,
                        IssueStatusID = Statuses.FailedInStaging,
                        ReleaseDate = DateTime.Now.AddDays(7),
                        IssueEffortID = Efforts.High
                    },
                    new Issue
                    {
                        Title = "DEF went boom",
                        IssuePriorityID = Priorities.Low,
                        IssueModules = new List<IssueModule> { Modules.Base },
                        IssueCustomerID = Customers.TestCustomer,
                        Created = DateTime.Now.AddHours(-1),
                        CreatedByID = Users.HelpDeskCustomer.Id,
                        Details = "<p>Destiny’s child keepin’ it real sitcoms topanga, frasier acid wash world wide web sega genesis end of the road dennis rodman. Velcro sneakers snoop dogg boo-ya y2k discovery zone garth brooks, instant messaging meg ryan gatorade cheetos ford bronco snapple. My heart will go on flat tops trl the simpsons vertically striped shirts piercings. Toni braxton atlanta braves yo-yos scrolling text.</p>",
                        IssueTypeID = Types.Bug,
                        IssueStatusID = Statuses.FailedInProduction,
                        IssueEffortID = Efforts.Low
                    },
                    new Issue
                    {
                        Title = "Can you make A also do B",
                        IssuePriorityID = Priorities.Medium,
                        IssueModules = new List<IssueModule> { Modules.Portfolios },
                        IssueCustomerID = Customers.TestCustomer,
                        Created = DateTime.Now.AddDays(-3),
                        CreatedByID = Users.HelpDeskCustomer.Id,
                        Details = "<p>Yo quiero taco bell super soaker nylon windbreaker bike caps grunge. Chandler bing roseanne smashing pumpkins toy story backstreet boys oversized sweaters. The rachel haircut the simpsons pizza bagels hip hop, tamagotchi internet keepin’ it real natalie imbruglia yin yang. Wayne’s world arsenio hall berry lips babyface full house flat tops, hotmail skate tees your mom turquoise alternative rock jurassic park.</p>",
                        IssueTypeID = Types.Enhancement,
                        IssueStatusID = Statuses.InProgress,
                        IssueEffortID = Efforts.Medium
                    },
                    new Issue
                    {
                        Title = "It would be great if we could do C",
                        IssuePriorityID = Priorities.High,
                        IssueModules = new List<IssueModule> { Modules.Alerts },
                        IssueCustomerID = Customers.TestCustomer,
                        Created = DateTime.Now.AddDays(-14),
                        CreatedByID = Users.HelpDeskCustomer.Id,
                        Details = "<p>Visor cargo pants crimped hair discman. Mario lemieux west wing dennis rodman jagged little pill bleached hair, independence day trippin’ nirvana ghost pottery scene denim jackets slacker. Nintendo 64 vertically striped shirts jonathan taylor thomas kurt cobain, new jack city fresh prince of bel-air natalie imbruglia boy meets world. Tlc parting your hair down the middle dsl christina aguilera airwalk.</p>",
                        IssueTypeID = Types.NewFeature,
                        IssueStatusID = Statuses.DevelopmentTesting,
                        ReleaseDate = DateTime.Now.AddDays(14),
                        IssueEffortID = Efforts.High
                    },
                    new Issue
                    {
                        Title = "Awesome Killer Functionality of Dreams",
                        IssuePriorityID = Priorities.Urgent,
                        IssueModules = new List<IssueModule> { Modules.Mileage },
                        Created = DateTime.Now.AddDays(-5),
                        CreatedByID = Users.HelpDeskDeveloper.Id,
                        Details = "<p>Hottie discovery zone tlc cassette tape. Green day saved by the bell george michael fly crimped hair, zebra stripes your mom toyota supra ghost pottery scene marky mark. Discman baby got back piercings yo. Digital pets courtney love vhs tapes nerf guns, chat rooms david duchovny smarter child honda accord g-shocks.</p>",
                        IssueTypeID = Types.NewFeature,
                        IssueStatusID = Statuses.ReadyForStaging,
                        ReleaseDate = DateTime.Now.AddDays(7),
                        IssueEffortID = Efforts.Low
                    },
                    new Issue
                    {
                        Title = "What happened to Y??",
                        IssuePriorityID = Priorities.Medium,
                        IssueModules = new List<IssueModule> { Modules.HelpDesk },
                        IssueCustomerID = Customers.TestCustomer,
                        Created = DateTime.Now.AddHours(-1),
                        CreatedByID = Users.HelpDeskCustomer.Id,
                        Details = "<p>Destiny’s child keepin’ it real sitcoms topanga, frasier acid wash world wide web sega genesis end of the road dennis rodman. Velcro sneakers snoop dogg boo-ya y2k discovery zone garth brooks, instant messaging meg ryan gatorade cheetos ford bronco snapple. My heart will go on flat tops trl the simpsons vertically striped shirts piercings. Toni braxton atlanta braves yo-yos scrolling text.</p>",
                        IssueTypeID = Types.Bug,
                        IssueStatusID = Statuses.Testing,
                        IssueEffortID = Efforts.Medium
                    },
                    new Issue
                    {
                        Title = "Can you add X to Y?",
                        IssuePriorityID = Priorities.Low,
                        IssueModules = new List<IssueModule> { Modules.Calendars },
                        IssueCustomerID = Customers.TestCustomer,
                        Created = DateTime.Now.AddDays(-3),
                        CreatedByID = Users.HelpDeskCustomer.Id,
                        Details = "<p>Yo quiero taco bell super soaker nylon windbreaker bike caps grunge. Chandler bing roseanne smashing pumpkins toy story backstreet boys oversized sweaters. The rachel haircut the simpsons pizza bagels hip hop, tamagotchi internet keepin’ it real natalie imbruglia yin yang. Wayne’s world arsenio hall berry lips babyface full house flat tops, hotmail skate tees your mom turquoise alternative rock jurassic park.</p>",
                        IssueTypeID = Types.Enhancement,
                        IssueStatusID = Statuses.ReadyToDeploy,
                        IssueEffortID = Efforts.High
                    },
                    new Issue
                    {
                        Title = "I'd love it if I could make B",
                        IssuePriorityID = Priorities.Urgent,
                        IssueModules = new List<IssueModule> { Modules.HelpDeskClient },
                        IssueCustomerID = Customers.TestCustomer,
                        Created = DateTime.Now.AddDays(-14),
                        CreatedByID = Users.HelpDeskCustomer.Id,
                        Details = "<p>Visor cargo pants crimped hair discman. Mario lemieux west wing dennis rodman jagged little pill bleached hair, independence day trippin’ nirvana ghost pottery scene denim jackets slacker. Nintendo 64 vertically striped shirts jonathan taylor thomas kurt cobain, new jack city fresh prince of bel-air natalie imbruglia boy meets world. Tlc parting your hair down the middle dsl christina aguilera airwalk.</p>",
                        IssueTypeID = Types.NewFeature,
                        IssueStatusID = Statuses.Deployed,
                        ReleaseDate = DateTime.Now.AddDays(14),
                        IssueEffortID = Efforts.Low
                    },
                    new Issue
                    {
                        Title = "X Y Z can be Z Y X",
                        IssuePriorityID = Priorities.High,
                        IssueModules = new List<IssueModule> { Modules.Core },
                        Created = DateTime.Now.AddDays(-5),
                        CreatedByID = Users.HelpDeskDeveloper.Id,
                        Details = "<p>Hottie discovery zone tlc cassette tape. Green day saved by the bell george michael fly crimped hair, zebra stripes your mom toyota supra ghost pottery scene marky mark. Discman baby got back piercings yo. Digital pets courtney love vhs tapes nerf guns, chat rooms david duchovny smarter child honda accord g-shocks.</p>",
                        IssueTypeID = Types.NewFeature,
                        IssueStatusID = Statuses.ConfirmingInProduction,
                        ReleaseDate = DateTime.Now.AddDays(7),
                        IssueEffortID = Efforts.Medium
                    },
                    new Issue
                    {
                        Title = "It's Broken!",
                        ReleaseDate = DateTime.Now.AddDays(-14),
                        IssuePriorityID = Priorities.Urgent,
                        IssueModules = new List<IssueModule> {
                            Modules.Alerts, Modules.Base, Modules.Blogs, Modules.Faqs },
                        IssueCustomerID = Customers.TestCustomer,
                        Created = DateTime.Now.AddMinutes(-30),
                        CreatedByID = Users.HelpDeskCustomer.Id,
                        Details = "<p>Tae bo saved by the bell whitney houston spice girls, julia roberts girl power hook leggings t-shirts. Did I do that crib honda accord trl macaulay culkin the matrix, fresh aviators super soaker flannel shirts. Renting movies at a store snapple chuck taylor all-stars puff daddy paper fortune teller personal computer, atlanta summer olympics hootie and the blowfish sega genesis velcro sneakers vanilla ice.</p><p>I'm king of the world cornrows maxin’ independence day bomber jacket g-shocks. Berry lips doug natalie imbruglia ain’t no thang flip flops wayne’s world, babyface west wing reebok pumps velcro sneakers discovery zone britney spears. Airwalk alternative rock grunge doc martens britpop, bandanas hoodies fargo real world yo quiero taco bell. Fly napster des’ree accent braids.</p><p>Schindler’s list buddy list the matrix pogs razor scooter wonderwall. Millenials gordon bombay marky mark free willy as I lay me down to sleep. Punk y2k smashing pumpkins I don’t want no scrubs slap bracelet lunchables, wesley snipes nirvana animated gifs new kids on the block umbro shorts. Denim jackets push pencils hot pockets wayne gretzky extreme sports, geo metro courtney love skidz and zubas dallas cowboys arsenio hall the mighty ducks.</p>",
                        IssueTypeID = Types.Bug,
                        IssueStatusID = Statuses.Canceled

                    },
                    new Issue
                    {
                        Title = "You ruined everything!",
                        ReleaseDate = DateTime.Now.AddDays(-14),
                        IssuePriorityID = Priorities.Urgent,
                        IssueModules = new List<IssueModule> {
                            Modules.Alerts, Modules.Base, Modules.Blogs, Modules.Calendars,
                            Modules.Core, Modules.Faqs, Modules.ExampleSite, Modules.HelpDesk,
                            Modules.HelpDeskClient, Modules.Mileage,
                            Modules.Portfolios, Modules.Tickets },
                        IssueCustomerID = Customers.TestCustomer,
                        Created = DateTime.Now.AddMinutes(-30),
                        CreatedByID = Users.HelpDeskCustomer.Id,
                        Details = "<p>Tae bo saved by the bell whitney houston spice girls, julia roberts girl power hook leggings t-shirts. Did I do that crib honda accord trl macaulay culkin the matrix, fresh aviators super soaker flannel shirts. Renting movies at a store snapple chuck taylor all-stars puff daddy paper fortune teller personal computer, atlanta summer olympics hootie and the blowfish sega genesis velcro sneakers vanilla ice.</p><p>I'm king of the world cornrows maxin’ independence day bomber jacket g-shocks. Berry lips doug natalie imbruglia ain’t no thang flip flops wayne’s world, babyface west wing reebok pumps velcro sneakers discovery zone britney spears. Airwalk alternative rock grunge doc martens britpop, bandanas hoodies fargo real world yo quiero taco bell. Fly napster des’ree accent braids.</p><p>Schindler’s list buddy list the matrix pogs razor scooter wonderwall. Millenials gordon bombay marky mark free willy as I lay me down to sleep. Punk y2k smashing pumpkins I don’t want no scrubs slap bracelet lunchables, wesley snipes nirvana animated gifs new kids on the block umbro shorts. Denim jackets push pencils hot pockets wayne gretzky extreme sports, geo metro courtney love skidz and zubas dallas cowboys arsenio hall the mighty ducks.</p>",
                        IssueTypeID = Types.Bug,
                        IssueStatusID = Statuses.Closed,
                        IssueEffortID = Efforts.High

                    }
                );
                Context.SaveChanges();
            }
        }
    }
}
