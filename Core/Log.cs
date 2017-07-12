using System;
using EntityClasses;

namespace Core
{
    public class Log
    {
        public static void Add(string result)
        {
            try
            {
                using (var ec = new TestProjectEntities1())
                {
                    var log = new tb_log
                    {
                        date = DateTime.Now,
                        result = result,
                    };
                    ec.tb_log.Add(log);
                    EntityConnector.SaveChanges(ec);
                }
            }
            catch (Exception ex)
            {

                //add saving to text file

            }
        }

    }

}
