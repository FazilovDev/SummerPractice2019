using System.Collections.Generic;
using LiteDB;


namespace LeapMotionApplication.Model
{
    public abstract class Dao<T>
    {
        private static readonly string DATABASE_PATH = @"./Internal.db";

        private LiteDatabase Database
        {
            get
            {
                using (var db = new LiteDatabase(DATABASE_PATH))
                {
                    return db;
                }
            }
        }

        protected abstract string TableName { get; }

        protected LiteCollection<T> Collection
        {
            get
            {
                return Database.GetCollection<T>(TableName);
            }
        }

        public IEnumerable<T> Items
        {
            get
            {
                return Collection.FindAll();
            }
        }

        public T Get(string fieldName, object value)
        {
            return Collection.FindOne(Query.EQ(fieldName, new BsonValue(value)));
        }

        public long Count()
        {
            return Collection.Count();
        }

        public int Delete(string fieldName, object value)
        {
            return Collection.Delete(Query.EQ(fieldName, new BsonValue(value)));
        }

        public bool Exists(string fieldName, object value)
        {
            return Collection.Exists(Query.EQ(fieldName, new BsonValue(value)));
        }

        public bool Insert(T data)
        {
            return Collection.Upsert(data);
        }

        public bool Update(T data)
        {
            return Collection.Update(data);
        }
    }
}

