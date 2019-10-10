using post.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace post.Data
{
    public class DbInitializer
    {
        public static void Initialize(postContext context)
        {
            context.Database.EnsureCreated();

            if (context.User.Any())
            {
                return;
            }

            var users = new User[]
            {
            new User{UserName="Азат" },
            new User{UserName="Альберт" },
            new User{UserName="Ильнур" },
            new User{UserName="Булат" }
            };
            foreach (User u in users)
            {
                context.User.Add(u);
            }
            context.SaveChanges();

            var categories = new Category[]
            {
            new Category{CategoryName="Природа" },
            new Category{CategoryName="Животные" },
            new Category{CategoryName="Дом" },
            new Category{CategoryName="Путешествие" }
            };
            foreach (Category c in categories)
            {
                context.Category.Add(c);
            }
            context.SaveChanges();

            var posts = new Post[]
            {
            new Post{UserID=1,CategoryID=1,PostContent="Большая голубая дыра – общий термин, применяемый к ряду однотипных образований, расположенных ниже уровня моря. Столь любопытное название было присвоено явлению из-за поразительного сочетания голубой воды насыщенного темного тона и более светлых вод, размещенных вокруг. Результатом подобного союза выступает визуальная иллюзия того, что на поверхности морской глади находится гигантских размеров пустое пространство. Зрелище настолько впечатляющее, что интерес к голубой дыре не угасает, а лишь возрастает с каждым годом. Причем любознательным жителям планеты интересно не только увидеть воронку, но и узнать, как именно она появилась."},
            new Post{UserID=4,CategoryID=4,PostContent="Недавно счет на 430 евро за пасту, рыбу и воду в итальянском ресторане возмутил пользователей Сети. Японским туристкам, которым пришлось оплатить столь дорогой обед, еще повезло. В сентябре в Манчестере у австралийского блогера списали с карты 61 200 евро за пинту пива, а шаурма в уличном кафе в Иерусалиме обошлась отдыхающей в 2 500 евро. О том, как обманывают путешественников в ресторанах, почему обедать лучше там, где это делают местные, и кто поможет оспорить огромный счет, — в материале РИА Новости."}
            };
            foreach (Post p in posts)
            {
                context.Post.Add(p);
            }
            context.SaveChanges();
        }
    }
}
