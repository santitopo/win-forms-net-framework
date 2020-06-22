using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = Domain.Analysis.Type;

namespace Persistence
{
    public class Repository
    {
        public Repository() { }


        public void DeleteAllAuthors()
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    ctx.Authors.RemoveRange(ctx.Authors);
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error getting teachers", ex);
                }
            }
        }

        public void DeleteAllAlarms()
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    ctx.Alarms.RemoveRange(ctx.Alarms);
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error getting alarms", ex);
                }
            }
        }

        public void DeleteAllFeelings()
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    ctx.Feelings.RemoveRange(ctx.Feelings);
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error getting feelings", ex);
                }
            }
        }



        public void DeleteAllEntities()
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    ctx.Entities
.RemoveRange(ctx.Entities);
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error getting entities", ex);
                }
            }
        }

        public void DeleteAllAnalysis()
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    ctx.Analysis.RemoveRange(ctx.Analysis);
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error getting analysis", ex);
                }
            }
        }

        public void DeleteAllPhrases()
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    ctx.Phrases.RemoveRange(ctx.Phrases);
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error getting phrases", ex);
                }
            }
        }

        public void UpdateAuthorBD(Author anAuthor)
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    Author authorBD = ctx.Authors.Include("MentionedEntities").
                        SingleOrDefault(author => author.AuthorId == anAuthor.AuthorId);
                    authorBD.MentionedEntities.Clear();

                    foreach (Entity e in anAuthor.MentionedEntities)
                    {
                        authorBD.MentionedEntities.Add(ctx.Entities.SingleOrDefault(entity => entity.EntityId == e.EntityId));
                    }
                    authorBD.PositivePosts = anAuthor.PositivePosts;
                    authorBD.NegativePosts = anAuthor.NegativePosts;
                    authorBD.TotalPosts = anAuthor.TotalPosts;

                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error modifying author", ex);
                }
            }
        }

        public void UpdateAlarmBD(Alarm anAlarm)
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    if (anAlarm.GetType() == typeof(GeneralAlarm))
                    {
                        ctx.Alarms.Attach(anAlarm);
                        ctx.Entry(anAlarm).State = EntityState.Modified;
                    }
                    else if (anAlarm.GetType() == typeof(AuthorAlarm))
                    {

                        Alarm alarmBD = ctx.Alarms.OfType<AuthorAlarm>().
                        Include("AssociatedAuthors").SingleOrDefault(a => a.AlarmId == anAlarm.AlarmId);
                        AuthorAlarm authorAlarmBD = (AuthorAlarm)alarmBD;
                        authorAlarmBD.AssociatedAuthors.Clear();

                        AuthorAlarm authorAlarm = (AuthorAlarm)anAlarm;

                        foreach (Author a in authorAlarm.AssociatedAuthors)
                        {
                            authorAlarmBD.AssociatedAuthors.Add(ctx.Authors.SingleOrDefault(author => author.AuthorId == a.AuthorId));
                        }

                        authorAlarmBD.State = anAlarm.State;
                    }
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error modified Alarm", ex);
                }
            }
        }

        public void AddGeneralAlarm(GeneralAlarm anAlarm)
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    ctx.Entities.Attach(anAlarm.Entity);
                    ctx.Alarms.Add(anAlarm);
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error adding new alarm", ex);
                }
            }
        }

        public void AddAuthorAlarm(AuthorAlarm anAlarm)
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    //attach?
                    ctx.Alarms.Add(anAlarm);
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error adding new alarm", ex);
                }
            }
        }

        public void AddAnalysis(Analysis anAnalysis)
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    Phrase phBD = ctx.Phrases.Include("Author").Include("Author.MentionedEntities").SingleOrDefault(p => p.PhraseId == anAnalysis.Phrase.PhraseId);
                    anAnalysis.Phrase = phBD;

                    if (anAnalysis.Entity != null)
                    {
                        Entity eBD = ctx.Entities.SingleOrDefault(e => e.EntityId == anAnalysis.Entity.EntityId);
                        anAnalysis.Entity = eBD;
                    }

                    ctx.Analysis.Add(anAnalysis);
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error adding new analysis", ex);
                }
            }
        }
        public void AddAuthor(Author anAuthor)
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    List<Author> deletedAuthors = GetDeletedAuthors();
                    int pos = deletedAuthors.IndexOf(anAuthor);

                    if (pos == -1)
                    {
                        ctx.Authors.Add(anAuthor);
                    }
                    else
                    {
                        ctx.Authors.Attach(deletedAuthors[pos]);
                        deletedAuthors[pos].Deleted = false;
                    }

                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error adding new author", ex);
                }
            }
        }
        public void AddEntity(Entity aEntity)
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    List<Entity> deletedEntities = GetDeletedEntities();
                    int pos = deletedEntities.IndexOf(aEntity);

                    if (pos == -1)
                    {
                        ctx.Entities.Add(aEntity);
                    }
                    else
                    {
                        ctx.Entities.Attach(deletedEntities[pos]);
                        deletedEntities[pos].Deleted = false;
                    }

                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error adding new entity", ex);
                }
            }
        }

        public List<Entity> GetDeletedEntities()
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    return ctx.Entities.Where(e => e.Deleted).ToList();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error getting entities", ex);
                }
            }
        }

        public List<Author> GetDeletedAuthors()
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    return ctx.Authors.Where(a => a.Deleted).ToList();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error getting entities", ex);
                }
            }
        }

        public void AddFeeling(Feeling aFeeling)
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    ctx.Feelings.Add(aFeeling);
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error adding new feeling", ex);
                }
            }

            //feelings.Add(aFeeling);
        }
        public void AddPhrase(Phrase aPhrase)
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    ctx.Authors.Attach(aPhrase.Author);
                    ctx.Phrases.Add(aPhrase);
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error adding new phrase", ex);
                }
            }
        }

        //Pre-condition ~ Must exist in entities
        public Entity GetEntityByName(string name)
        {
            List<Entity> entities = GetEntities();
            foreach (Entity e in entities)
            {
                if (e.Name.Equals(name))
                {
                    return e;
                }
            }
            return null;
        }

        //Pre-condition ~ Must exist in authors
        public Author getAuthorByUsername(string username)
        {
            List<Author> authors = GetAuthors();
            foreach (Author a in authors)
            {
                if (a.Username.Equals(username))
                {
                    return a;
                }
            }
            return null;
        }

        public void DeleteAuthor(Author anAuthor)
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    Author auth = ctx.Authors.Single(a => a.AuthorId == anAuthor.AuthorId);
                    auth.Deleted = true;
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("No hay analisis en el sistema", ex);
                }
            }
        }

        public void DeleteEntity(Entity aEntity)
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    Entity deletedEntity = ctx.Entities.Single(e => e.EntityId == aEntity.EntityId);
                    deletedEntity.Deleted = true;
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("No hay entidades en el sistema", ex);
                }
            }
        }
        public void DeleteFeeling(Feeling aFeeling)
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    ctx.Feelings.Remove(ctx.Feelings.Single(f => f.FeelingId == aFeeling.FeelingId));
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("No hay sentimientos en el sistema", ex);
                }
            }
        }

        public List<Alarm> GetAlarms()
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    List<GeneralAlarm> l1 = ctx.Alarms.OfType<GeneralAlarm>().
                        Include("Entity").ToList();
                    List<AuthorAlarm> l2 = ctx.Alarms.OfType<AuthorAlarm>().
                        Include("AssociatedAuthors").ToList();
                    List<Alarm> ret = new List<Alarm>();

                    for (int i = 0; i < l1.Count; i++)
                    {
                        ret.Add(l1[i]);
                    }
                    for (int i = 0; i < l2.Count; i++)
                    {
                        ret.Add(l2[i]);
                    }
                    return ret;
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error getting alarms", ex);
                }
            }
        }
        public List<Analysis> GetAnalysis()
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    return ctx.Analysis.Include("Entity").Include("Phrase.Author").ToList();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error getting analysis", ex);
                }
            }
        }
        public List<Author> GetAuthors()
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    return ctx.Authors.Where(a => !a.Deleted).Include("MentionedEntities").ToList();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error getting authors", ex);
                }
            }
        }

        //Pos: Brings all authors, including deleted ones.
        public List<Author> GetAllAuthors()
        {
            try
            {
                using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
                {

                    return ctx.Authors.Include("MentionedEntities").ToList();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting authors", ex);
            }

        }

        public List<Entity> GetEntities()
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    return ctx.Entities.Where(e => !e.Deleted).ToList();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error getting entities", ex);
                }
            }

            //return entities;
        }
        public List<Feeling> GetFeelings()
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    return ctx.Feelings.ToList();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error getting feelings", ex);
                }
            }

            //return feelings;
        }
        public List<Phrase> GetPhrases()
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    return ctx.Phrases.Include("Author").ToList();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error getting phrases", ex);
                }
            }
        }

        public bool AuthorHasPhrases(Author anAuthor)
        {
            List<Phrase> phrases = GetPhrases();
            foreach (Phrase p in phrases)
            {
                if (p.Author.Equals(anAuthor))
                {
                    return true;
                }
            }
            return false;
        }

        //Pre: Author has phrases in System
        public DateTime GetFirstPhraseDate(Author anAuthor)
        {
            List<Phrase> phrases = GetPhrases();
            //returns Now if no phrases
            DateTime first = DateTime.Now;
            foreach (Phrase p in phrases)
            {

                if (p.Author.Equals(anAuthor))
                {
                    if (p.Date < first)
                    {
                        first = p.Date;
                    }
                }
            }
            return first;
        }

        //public DataTable DTEntityNumberDesc()
        //{
        //    DataTable customDT = new DataTable();
        //    DataColumn[] columns = {new DataColumn("Usuario"), new DataColumn("Nombre"), new DataColumn("Apellido"),
        //        new DataColumn("Entidades", System.Type.GetType("System.Int32")) };
        //    customDT.Columns.AddRange(columns);
        //    List<Author> lst = ListByEntityNumberDesc();
        //    foreach (Author a in lst)
        //    {
        //        DataRow row = customDT.NewRow();
        //        row[0] = a.Username;
        //        row[1] = a.Name;
        //        row[2] = a.Surname;
        //        row[3] = a.MentionedEntities.Count;
        //        customDT.Rows.Add(row);
        //    }
        //    return customDT;
        //}

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
                    List<custTypeAuthorAvgQuery> authorList = ctx.Database.SqlQuery<custTypeAuthorAvgQuery>("(SELECT a.Username,a.Name,a.TotalPosts, EarlierPosts.FirstPost " +
                        "FROM (SELECT p.Author_AuthorId, MIN(p.Date) AS FirstPost FROM Phrases p GROUP BY p.Author_AuthorId) " +
                        "AS EarlierPosts, Authors a WHERE a.AuthorId = EarlierPosts.Author_AuthorId and a.Deleted=0);").ToList();
                    return BuildPhraseAverageList(authorList);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al cargar los autores ordenados por entidades mencionadas", ex);
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
                        { Username = a.Username, Name = a.Name, Mentioned_Entities = a.MentionedEntities.Count })
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
            public int Mentioned_Entities { get; set; }

            public override bool Equals(object obj)
            {
                return Username == (((custTypeAuthorEntities)obj).Username)
                    && Name == (((custTypeAuthorEntities)obj).Name)
                    && Mentioned_Entities == (((custTypeAuthorEntities)obj).Mentioned_Entities);
            }

        }

        public class custTypeAuthorPosRatio
        {
            public string Username { get; set; }
            public string Name { get; set; }
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

            public int TotalPosts { get; set; }
            public DateTime FirstPost { get; set; }
        }

        public class custTypeAuthorAvgRatio
        {
            public string Username { get; set; }
            public string Name { get; set; }
            public double Post_average { get; set; }
        }
    }
}
