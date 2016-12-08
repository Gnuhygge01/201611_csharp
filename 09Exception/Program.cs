using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Exception
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {

            logger.Debug("App start");

            try
            {
                int y = 10;
                logger.Debug("Kalder A");
                A(1);
                logger.Debug("Retur fra A");

            }

            catch (Exception ex)
            {
                logger.Error(ex);
                // log ex....
            }
            finally
            {
                // evt luk/ryd op
            }
            logger.Debug("App end");
        }
        public static void A(int id)
        {
            logger.Debug("Enter med {0}", id);
            B();
            logger.Debug("Exit");

        }

        public static int es() {
            return 1;
        }
        public static void B()

        {
            logger.Debug("Enter");
            C();
            logger.Debug("Exit");

        }
        public static void C()
        {
            logger.Debug("Enter");
            D();
            logger.Debug("Exit");
        }
        public static void D()
        {
            logger.Debug("Enter");
            object o = null;
            o.ToString();
            logger.Debug("Exit");
        }

    }


}

