using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LeapMotionApplication.Model
{
    public sealed class PressDao : Dao<Press>
    {
        protected override string TableName => "PressKeyboard";
        public static readonly string FIELD_ID = "_id";

        private static PressDao instance = null;

        public static PressDao Instance
        {
            get
            {
                if (instance == null)
                    instance = new PressDao();
                return instance;
            }
        }

        private PressDao()
        {
        }


        public Press Get(long id)
        {
            return Get(FIELD_ID, id);
        }

        public bool Save(Press trial)
        {
            return Insert(trial);
        }

        public bool Exists(long id)
        {
            return Exists(FIELD_ID, id);
        }

        public int Delete(long id)
        {
            return Delete(FIELD_ID, id);
        }
    }
}
