using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeapMotionApplication.Model
{
    public sealed class PressMotionDao : Dao<PressMotion>
    {
        protected override string TableName => "PressMotion";
        public static readonly string FIELD_ID = "_id";

        private static PressMotionDao instance = null;

        public static PressMotionDao Instance
        {
            get
            {
                if (instance == null)
                    instance = new PressMotionDao();
                return instance;
            }
        }

        private PressMotionDao()
        {
        }


        public PressMotion Get(long id)
        {
            return Get(FIELD_ID, id);
        }

        public bool Save(PressMotion pressMotion)
        {
            return Insert(pressMotion);
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
