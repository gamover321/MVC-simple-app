using System;
using EntityClasses;

namespace Core
{
    public class EntityConnector
    {
        public static T Connect<T>(Func<TestProjectEntities1, T> func)
        {
            try
            {
                using (var ec = new TestProjectEntities1())
                {                    
                    return func(ec);
                }
            }
            catch (Exception ex)
            {
                Log.Add(ex.ToString());
                return default(T);
            }
        }

       

        public static bool SaveChanges(TestProjectEntities1 ec)
        { 
            try
            {
                ec.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Log.Add(ex.ToString());
                return false;
            }
        }
    }


}