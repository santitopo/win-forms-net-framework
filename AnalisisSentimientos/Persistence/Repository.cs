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
            try
            {
                using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
                {
                    ctx.Authors.RemoveRange(ctx.Authors);
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al eliminar todos los autores", ex);
            }
        }

        public void DeleteAllAlarms()
        {
            try
            {
                using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
                {
                    ctx.Alarms.RemoveRange(ctx.Alarms);
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al eliminar todos las alarmas", ex);
            }
        }

        public void DeleteAllFeelings()
        {
            try
            {
                using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
                {
                    ctx.Feelings.RemoveRange(ctx.Feelings);
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al eliminar todos los sentimientos", ex);
            }
        }



        public void DeleteAllEntities()
        {
            try
            {
                using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
                {
                    ctx.Entities.RemoveRange(ctx.Entities);
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al eliminar todas las entidades", ex);
            }
        }

        public void DeleteAllAnalysis()
        {
            try
            {
                using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
                {
                    ctx.Analysis.RemoveRange(ctx.Analysis);
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al eliminar todos los analisis", ex);
            }
        }

        public void DeleteAllPhrases()
        {
            try
            {
                using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
                {
                    ctx.Phrases.RemoveRange(ctx.Phrases);
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al eliminar todas las frases", ex);
            }
        }

        public void UpdateAuthorBD(Author anAuthor)
        {
            try
            {
                using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
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
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al modificar un autor", ex);
            }
        }

        public void UpdateAlarmBD(Alarm anAlarm)
        {
            try
            {
                using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
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
                            authorAlarmBD.AssociatedAuthors.Add
                                (ctx.Authors.SingleOrDefault(author => author.AuthorId == a.AuthorId));
                        }

                        authorAlarmBD.State = anAlarm.State;
                    }
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al modificar una alarma", ex);
            }
        }

        public void AddGeneralAlarm(GeneralAlarm anAlarm)
        {
            try
            {
                using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
                {
                    ctx.Entities.Attach(anAlarm.Entity);
                    ctx.Alarms.Add(anAlarm);
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al agregar una nueva alarma", ex);
            }
        }

        public void AddAuthorAlarm(AuthorAlarm anAlarm)
        {
            try
            {
                using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
                {
                    ctx.Alarms.Add(anAlarm);
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al agregar una nueva alarma", ex);
            }
        }

        public void AddAnalysis(Analysis anAnalysis)
        {
            try
            {
                using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
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
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al agregar un nuevo analisis", ex);
            }
        }
        public void AddAuthor(Author anAuthor)
        {
            try
            {
                using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
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
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al agregar un nuevo autor", ex);
            }
        }
        public void AddEntity(Entity aEntity)
        {
            try
            {
                using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
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
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al agregar una nueva entidad", ex);
            }
        }


        public void AddFeeling(Feeling aFeeling)
        {
            try
            {
                using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
                {
                    ctx.Feelings.Add(aFeeling);
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al agregar un nuevo sentimiento", ex);
            }
        }
        public void AddPhrase(Phrase aPhrase)
        {
            try
            {
                using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
                {
                    ctx.Authors.Attach(aPhrase.Author);
                    ctx.Phrases.Add(aPhrase);
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al agregar una nueva frase", ex);
            }
        }

        public List<Entity> GetDeletedEntities()
        {
            try
            {
                using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
                {
                    return ctx.Entities.Where(e => e.Deleted).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al obtener entidades", ex);
            }
        }

        public List<Author> GetDeletedAuthors()
        {
            try
            {
                using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
                {
                    return ctx.Authors.Where(a => a.Deleted).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al obtener autores", ex);
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
        public Author GetAuthorByUsername(string username)
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
            try
            {
                using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
                {
                    Author auth = ctx.Authors.Single(a => a.AuthorId == anAuthor.AuthorId);
                    auth.Deleted = true;
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al eliminar autor", ex);
            }
        }

        public void DeleteEntity(Entity aEntity)
        {
            try
            {
                using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
                {
                    Entity deletedEntity = ctx.Entities.Single(e => e.EntityId == aEntity.EntityId);
                    deletedEntity.Deleted = true;
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al eliminar entidad", ex);
            }
        }
        public void DeleteFeeling(Feeling aFeeling)
        {

            try
            {
                using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
                {
                    ctx.Feelings.Remove(ctx.Feelings.Single(f => f.FeelingId == aFeeling.FeelingId));
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al eliminar sentimiento", ex);
            }
        }

        public List<Alarm> GetAlarms()
        {
            try
            {
                using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
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
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al obtener alarmas", ex);
            }
        }
        public List<Analysis> GetAnalysis()
        {
            try
            {
                using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
                {
                    return ctx.Analysis.Include("Entity").Include("Phrase.Author").ToList();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al obtener analisis", ex);
            }
        }
        public List<Author> GetAuthors()
        {
            try
            {
                using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
                {
                    return ctx.Authors.Where(a => !a.Deleted).Include("MentionedEntities").ToList();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al obtener autores", ex);
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
                throw new ApplicationException("Error al obtener autores", ex);
            }

        }

        public List<Entity> GetEntities()
        {
            try
            {
                using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
                {
                    return ctx.Entities.Where(e => !e.Deleted).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al obtener entidades", ex);
            }
        }
        public List<Feeling> GetFeelings()
        {
            try
            {
                using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
                {
                    return ctx.Feelings.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al obtener sentimientos", ex);
            }
        }
        public List<Phrase> GetPhrases()
        {
            try
            {
                using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
                {
                    return ctx.Phrases.Include("Author").ToList();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al obtener frases", ex);
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
            public override bool Equals(object obj)
            {
                return Username == (((custTypeAuthorAvgRatio)obj).Username)
                    && Name == (((custTypeAuthorAvgRatio)obj).Name)
                    && Post_average == (((custTypeAuthorAvgRatio)obj).Post_average);
            }
        }
    }
}
