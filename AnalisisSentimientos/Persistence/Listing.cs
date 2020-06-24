using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class Listing
    {
        public Listing()
        {

        }

        private List<custTypeAuthorAvgRatio> BuildPhraseAverageList(List<custTypeAuthorAvgQuery> queryList)
        {
            List<custTypeAuthorAvgRatio> customAuthorList = new List<custTypeAuthorAvgRatio>();
            foreach (custTypeAuthorAvgQuery a in queryList)
            {
                int activeDays = (DateTime.Now - a.FirstPost).Days;
                double Post_ratio = (activeDays == 0) ? 0 : Math.Truncate((double)a.TotalPosts / activeDays * 1000) / 1000;
                custTypeAuthorAvgRatio newAuthor = new custTypeAuthorAvgRatio()
                {
                    Name = a.Name,
                    Surname = a.Surname,
                    Username = a.Username,
                    Post_average = Post_ratio,
                };
                customAuthorList.Add(newAuthor);
            }
            return customAuthorList;
        }

        public List<custTypeAuthorAvgRatio> ListByPhraseAverage()
        {
            try
            {
                using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
                {
                    List<custTypeAuthorAvgQuery> authorList = ctx.Database.SqlQuery<custTypeAuthorAvgQuery>(
                        "(SELECT a.Username,a.Name,a.Surname, a.TotalPosts, EarlierPosts.FirstPost " +
                        "FROM (SELECT p.Author_AuthorId, MIN(p.Date) AS FirstPost " +
                               "FROM Phrases p GROUP BY p.Author_AuthorId) AS EarlierPosts, Authors a " +
                        "WHERE a.AuthorId = EarlierPosts.Author_AuthorId and a.Deleted=0);").ToList();
                    return BuildPhraseAverageList(authorList);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al cargar los usuarios por promedio de frases", ex);
            }
        }

        public List<custTypeAuthorEntities> ListByEntityNumber()
        {
            try
            {
                using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
                {
                    List<custTypeAuthorEntities> authList = ctx.Authors
                        .Include("MentionedEntities")
                        .Where(a => !a.Deleted && a.MentionedEntities.Count > 0)
                        .Select(a => new custTypeAuthorEntities
                        {
                            Username = a.Username,
                            Name = a.Name,
                            Surname = a.Surname,
                            Entities = a.MentionedEntities.Count
                        })
                        //.OrderByDescending(x => x.Mentioned_Entities)
                        .ToList();
                    return authList;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al cargar los autores ordenados por entidades mencionadas", ex);
            }

        }

        public List<custTypeAuthorPosRatio> ListByPositiveRatio()
        {
            try
            {
                using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
                {
                    List<custTypeAuthorPosRatio> authList = ctx.Authors
                        .Include("MentionedEntities")
                        .Where(a => !a.Deleted && a.PositivePosts > 0)
                        .Select(a => new custTypeAuthorPosRatio
                        {
                            Username = a.Username,
                            Name = a.Name,
                            Surname = a.Surname,
                            Positive_Ratio = a.TotalPosts == 0 ? 0 :
                            Math.Truncate((double)a.PositivePosts / a.TotalPosts * 100) / 100
                        })
                        //.OrderByDescending(x => x.Positive_Ratio)
                        .ToList();
                    return authList;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al cargar los autores ordenados por " +
                    "ratio de comentarios positivos", ex);
            }

        }

        public List<custTypeAuthorNegRatio> ListByNegativeRatio()
        {
            try
            {
                using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
                {
                    List<custTypeAuthorNegRatio> authList = ctx.Authors
                        .Include("MentionedEntities")
                        .Where(a => !a.Deleted && a.NegativePosts > 0)
                        .Select(a => new custTypeAuthorNegRatio
                        {
                            Username = a.Username,
                            Name = a.Name,
                            Surname = a.Surname,
                            Negative_Ratio = a.TotalPosts == 0 ? 0 :
                            Math.Truncate((double)a.NegativePosts / a.TotalPosts * 100) / 100
                        })
                        // .OrderByDescending(x => x.Negative_Ratio)
                        .ToList();
                    return authList;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al cargar los autores ordenados por " +
                    "ratio de comentarios positivos", ex);
            }

        }

        public class custTypeAuthorEntities
        {
            public string Username { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public int Entities { get; set; }

            public override bool Equals(object obj)
            {
                return Username == (((custTypeAuthorEntities)obj).Username)
                    && Name == (((custTypeAuthorEntities)obj).Name)
                    && Entities == (((custTypeAuthorEntities)obj).Entities);
            }

        }

        public class custTypeAuthorPosRatio
        {
            public string Username { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public double Positive_Ratio { get; set; }

            public override bool Equals(object obj)
            {
                return Username == (((custTypeAuthorPosRatio)obj).Username)
                    && Name == (((custTypeAuthorPosRatio)obj).Name)
                    && Positive_Ratio == (((custTypeAuthorPosRatio)obj).Positive_Ratio);
            }
        }

        public class custTypeAuthorNegRatio
        {
            public string Username { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public double Negative_Ratio { get; set; }
            public override bool Equals(object obj)
            {
                return Username == (((custTypeAuthorNegRatio)obj).Username)
                    && Name == (((custTypeAuthorNegRatio)obj).Name)
                    && Negative_Ratio == (((custTypeAuthorNegRatio)obj).Negative_Ratio);
            }
        }

        public class custTypeAuthorAvgQuery
        {
            public string Username { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public int TotalPosts { get; set; }
            public DateTime FirstPost { get; set; }
        }

        public class custTypeAuthorAvgRatio
        {
            public string Username { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public double Post_average { get; set; }
            public override bool Equals(object obj)
            {
                return Username == (((custTypeAuthorAvgRatio)obj).Username)
                    && Name == (((custTypeAuthorAvgRatio)obj).Name)
                    && Post_average == (((custTypeAuthorAvgRatio)obj).Post_average);
            }
        }

    }
}
