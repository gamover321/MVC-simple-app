using System.Collections.Generic;
using Core;
using EntityClasses;

namespace Directories
{
    public abstract class DirectoryBase
    {
    }

    public abstract class NonCachedDirectory<TDirectory> : DirectoryBase where TDirectory : NonCachedDirectory<TDirectory>, new()
    {
        public int ID { get; set; }
        public string Name { get; set; }

        protected abstract IEnumerable<TDirectory> MassClone(TestProjectEntities1 ec);


        protected static IEnumerable<TDirectory> GetAllNonCache(TDirectory prototype)
        {
            var result = EntityConnector.Connect(prototype.MassClone);
            return result;
        }

        public static IEnumerable<TDirectory> GetAll()
        {
            return GetAllNonCache(new TDirectory());
        }
    }  
}
