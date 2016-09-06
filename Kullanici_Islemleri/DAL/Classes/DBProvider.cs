
namespace DAL.Classes
{
   public  class DBProvider
    {
        public static USER_SQLEntities DbEntity()
        {

            return new USER_SQLEntities();
    }
    }
}
